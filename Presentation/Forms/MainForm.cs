using MetroFramework.Forms;
using Microsoft.Win32;
using Presentation.Dialogs;
using RegisteryApi;
using RegisteryApi.Registery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class MainForm : MetroForm
    {
        Thread thLoadKeys;
        public MainForm()
        {
            InitializeComponent();
            //Init Globals
            thLoadKeys = new Thread(LoadKeys);
        }
        private void LoadKeys()
        {
            Debug.WriteLine("Root Data Init");
            RegistryKey[] keys = RegistryManager.GetRootKeys();
            Invoke(new Action(() =>
            {
                Log("درحال بارگذاری داده های اولیه");
                treeViewRegistery.BeginUpdate();
                treeViewRegistery.Nodes.Clear();
                treeViewRegistery.Nodes.AddRange(keys.Select(key =>
                {
                    TreeNode node = new TreeNode()
                    {
                        ImageIndex = 0,
                        Name = key.Name,
                        SelectedImageIndex = 1,
                        Text = key.Name
                    };
                    node.Nodes.Add(".");
                    return node;
                }).ToArray());

                treeViewRegistery.EndUpdate();
                Debug.WriteLine("Root Data Loaded");
                Log("داده ها بارگذاری شدند");
            }));
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            FocusMe();
            //Load Data
            thLoadKeys.Start();
        }

        private void treeViewRegistery_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!(e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.Expand)) return;
            BindNodesOnNode(e.Node);
        }
        private void BindNodesOnNode(TreeNode tnode)
        {
            txtAddress.Text = tnode.FullPath;
            Debug.WriteLine("treeViewRegistery_AfterSelect");
            Debug.WriteLine($"Load Data For:{tnode.FullPath}");
            Log($"درحال بارگذاری داده ها برای {tnode.FullPath}");
            if (tnode.Nodes.Count > 0)
                if (tnode.Nodes[0].Text == ".")
                    tnode.Nodes.RemoveAt(0);
            try
            {
                string path = tnode.FullPath;
                RegistryKey[] keys = RegistryManager.GetRegistryKeys(path);
                int keysCount = keys.Length;
                int index = 0;
                foreach (RegistryKey item in keys)
                {
                    string nodeName = item.Name.Split('\\').Last();
                    TreeNode node = new TreeNode()
                    {
                        Text = nodeName
                    };
                    if (item.SubKeyCount > 0)
                        node.Nodes.Add(".");
                    tnode.Nodes.Add(node);
                    Log($"در حال بارگذاری داده ها {++index}/{keysCount}");
                    Application.DoEvents();
                }
                tnode.Expand();
                BindValues(tnode);
                Debug.WriteLine($"Data Loaded For {tnode.FullPath}");
                Log($"داده ها بارگذاری شدند.تعداد : {keysCount}");
            }
            catch (UserHandledException ex)
            {
                Debug.WriteLine("UserHandledException Error", ex);
                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                treeViewRegistery_SelectWithoutEvent(tnode);
            }
            catch (SecurityException ex)
            {
                Debug.WriteLine("SecurityException Error", ex);
                MessageBox.Show("شما به این کلید دسترسی ندارید.لطفا با حساب مدیر سیستم وارد شوید.", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                treeViewRegistery_SelectWithoutEvent(tnode);
            }
        }

        private void BindValues(TreeNode tnode)
        {
            RegistryValue[] values = RegistryManager.GetKeyValues(tnode.FullPath);
            gridValues.Rows.Clear();
            foreach (RegistryValue item in values)
            {
                string val = "";
                switch (item.ValueKind)
                {
                    case RegistryValueKind.String:
                    case RegistryValueKind.ExpandString:
                    case RegistryValueKind.DWord:
                    case RegistryValueKind.QWord:
                        {
                            val = item.Value.ToString();
                        }
                        break;
                    case RegistryValueKind.Binary:
                        {
                            char[] bytesList = ((byte[])item.Value).Select(c => (char)c).ToArray();
                            string v = string.Join("", bytesList);
                            val = v;
                        }
                        break;
                    case RegistryValueKind.MultiString:
                        {
                            val = item.Value.ToString().Replace('\0', ';');
                        }
                        break;
                }
                gridValues.Rows.Add(item.Name, item.ValueKind,val);
            }
        }

        private void treeViewRegistery_SelectWithoutEvent(TreeNode node)
        {

            treeViewRegistery.AfterSelect -= treeViewRegistery_AfterSelect;
            treeViewRegistery.AfterExpand -= treeViewRegistery_AfterExpand;
            treeViewRegistery.SelectedNode = node;
            treeViewRegistery.AfterSelect += treeViewRegistery_AfterSelect;
            treeViewRegistery.AfterExpand += treeViewRegistery_AfterExpand;
        }
        private void treeViewRegistery_AfterExpand(object sender, TreeViewEventArgs e)
        {
            Debug.WriteLine("treeViewRegistery_AfterExpand");
            Debug.WriteLine(e.Node.FullPath);
            treeViewRegistery_AfterSelect(sender, e);
            treeViewRegistery.SelectedNode = e.Node;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("FormClosing Requested");
            DialogResult result = MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "خروج از برنامه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void Log(string message)
        {
            txtLog.Text = message;
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                try
                {
                    string path = txtAddress.Text.Trim();
                    List<string> pathDirection = path.Split('\\').ToList();
                    RegistryKey basekey = RegistryManager.GetBaseKeyByName(pathDirection[0]);
                    if (basekey == null)
                        throw new UserHandledException("آدرس وارد شده صحیح نمیباشد");
                    RegistryKey key = RegistryManager.GetRegistryKey(basekey, string.Join("\\", pathDirection.Skip(1)));
                    if (key == null)
                        throw new UserHandledException("آدرس وارد شده صحیح نمیباشد");

                    TreeNode[] treeNodesClone = new TreeNode[treeViewRegistery.Nodes.Count];
                    treeViewRegistery.Nodes.CopyTo(treeNodesClone, 0);
                    TreeNode node = treeNodesClone.Where(n => n.Text == pathDirection[0]).FirstOrDefault();
                    treeViewRegistery.SelectedNode = node;
                    BindNodesOnNode(treeViewRegistery.SelectedNode);
                    foreach (string dir in pathDirection.Skip(1))
                    {
                        treeNodesClone = new TreeNode[treeViewRegistery.SelectedNode.Nodes.Count];
                        treeViewRegistery.SelectedNode.Nodes.CopyTo(treeNodesClone, 0);
                        node = treeNodesClone.Where(n => n.Text == dir).FirstOrDefault();

                        treeViewRegistery.SelectedNode = node;
                        treeViewRegistery.SelectedNode.Checked = true;
                        BindNodesOnNode(treeViewRegistery.SelectedNode);
                    }
                    treeViewRegistery.SelectedNode.Collapse(true);
                    treeViewRegistery.Focus();
                    Log($"Found Node :{treeViewRegistery.SelectedNode.FullPath}");
                }
                catch (UserHandledException ex)
                {
                    Debug.WriteLine("UserHandledException Error", ex);
                    MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridContextMenu_Opening(object sender, CancelEventArgs e)
        {
            gridEdit.Enabled =
            gridDelete.Enabled =
            gridValues.SelectedRows.Count > 0;
            gridAdd.Enabled = treeViewRegistery.SelectedNode != null;
        }

        private void gridAdd_Click(object sender, EventArgs e)
        {
            AddValue addValue = new AddValue(treeViewRegistery.SelectedNode.FullPath);
            DialogResult result = addValue.ShowDialog();
            if (result == DialogResult.OK)
            {
                BindValues(treeViewRegistery.SelectedNode);
            }
            else
            {
                MessageBox.Show("عملیات توسط کاربر لغو شد.", "افزودن", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"آیا برای حذف {gridValues.SelectedRows[0].Cells[0].Value} اطمینان دارید؟", "حذف مقدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!RegistryManager.GetKeyValues(treeViewRegistery.SelectedNode.FullPath).Any(item => item.Name == gridValues.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    gridValues.Rows.Remove(gridValues.SelectedRows[0]);
                    MessageBox.Show("مقداری با این نام یافت نشد.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                RegistryManager.DeleteValue($"{treeViewRegistery.SelectedNode.FullPath}\\{gridValues.SelectedRows[0].Cells[0].Value}");
                BindValues(treeViewRegistery.SelectedNode);
            }
        }

        private void gridEdit_Click(object sender, EventArgs e)
        {
            EditValue addValue = new EditValue(treeViewRegistery.SelectedNode.FullPath, gridValues.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult result = addValue.ShowDialog();
            if (result == DialogResult.OK)
            {
                BindValues(treeViewRegistery.SelectedNode);
            }
            else
            {
                MessageBox.Show("عملیات توسط کاربر لغو شد.", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            AddValueNoKey add = new AddValueNoKey();
            add.ShowDialog();
        }

        private void toolBackup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ismilawd/RegisteryUtils/wiki");
        }

        private void toolAboutDeveloper_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ismilawd");
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {

        }

        private void toolWizard_Click(object sender, EventArgs e)
        {
            Wizard wizard = new Wizard();
            wizard.Show();
        }

        private void treeContextMenu_Opening(object sender, CancelEventArgs e)
        {
            treeAdd.Enabled = treeDelete.Enabled = treeViewRegistery.SelectedNode != null;
        }

        private void treeAdd_Click(object sender, EventArgs e)
        {
            AddKey addKey = new AddKey(treeViewRegistery.SelectedNode.FullPath);
            DialogResult result = addKey.ShowDialog();
            if (result == DialogResult.OK)
            {
                thLoadKeys = new Thread(LoadKeys);
                thLoadKeys.Start();
            }
            else
            {
                MessageBox.Show("عملیات توسط کاربر لغو شد.", "افزودن", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void treeDelete_Click(object sender, EventArgs e)
        {
            if(treeViewRegistery.SelectedNode.Parent==null)
            {
                MessageBox.Show("کلید روت نمیتواند حذف شود.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show($"آیا برای حذف {treeViewRegistery.SelectedNode.FullPath} اطمینان دارید؟", "حذف کلید", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RegistryManager.GetRegistryKey(treeViewRegistery.SelectedNode.FullPath) == null)
                {
                    treeViewRegistery.Nodes.Remove(treeViewRegistery.SelectedNode);
                    MessageBox.Show("کلیدی با این نام یافت نشد.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                RegistryManager.DeleteKey(treeViewRegistery.SelectedNode.Parent.FullPath,treeViewRegistery.SelectedNode.Text);
                thLoadKeys = new Thread(LoadKeys);
                thLoadKeys.Start();
            }
        }
    }
}
