using MetroFramework.Forms;
using Microsoft.Win32;
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
                treeViewRegistery.Nodes.AddRange(keys.Select(key => {
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
            Debug.WriteLine("treeViewRegistery_AfterSelect");
            Debug.WriteLine($"Load Data For:{e.Node.FullPath}");
            Log($"درحال بارگذاری داده ها برای {e.Node.FullPath}");
            if (e.Node.Nodes.Count > 0)
                if (e.Node.Nodes[0].Text == ".")
                    e.Node.Nodes.RemoveAt(0);
            try
            {
                string path = e.Node.FullPath;
                RegistryKey[] keys = RegistryManager.GetRegistryKeys(path);
                foreach (RegistryKey item in keys)
                {
                    string nodeName = item.Name.Split('\\').Last();
                    TreeNode node = new TreeNode()
                    {
                        Text = nodeName
                    };
                    if (item.SubKeyCount > 0)
                        node.Nodes.Add(".");
                    e.Node.Nodes.Add(node);
                    Application.DoEvents();
                }
                e.Node.Expand();
                Debug.WriteLine($"Data Loaded For {e.Node.FullPath}");
                Log("داده ها بارگذاری شدند");
            }
            catch (UserHandledException ex)
            {
                Debug.WriteLine("UserHandledException Error", ex);
                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                treeViewRegistery_SelectWithoutEvent(e.Node);
            }
            catch (SecurityException ex)
            {
                Debug.WriteLine("SecurityException Error", ex);
                MessageBox.Show("شما به این کلید دسترسی ندارید.لطفا با حساب مدیر سیستم وارد شوید.", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                treeViewRegistery_SelectWithoutEvent(e.Node);
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
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("FormClosing Requested");
            DialogResult result = MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "خروج از برنامه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
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
    }
}
