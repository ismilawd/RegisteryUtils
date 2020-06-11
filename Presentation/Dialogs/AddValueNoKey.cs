using Microsoft.Win32;
using RegisteryApi.Registery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Dialogs
{
    public partial class AddValueNoKey : Form
    {
        public AddValueNoKey()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string key = txtKeyName.Text.Trim();
            string name = txtName.Text.Trim();
            string type = cmbValueKind.Text.Trim();
            string value = txtValue.Text.Trim();
            if (key.Length==0 || name.Length == 0 || type.Length == 0 || value.Length == 0)
            {
                MessageBox.Show("لطفا مقادیر را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (RegistryManager.GetRegistryKey(key) == null)
            {
                MessageBox.Show("نام کلید وارده صحیح نمیباشد.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (RegistryManager.HavePermissionsOnKey(System.Security.Permissions.RegistryPermissionAccess.AllAccess, key))
            {
                MessageBox.Show("شما به این کلید دسترسی ندارید.لطفا با حساب مدیر سیستم وارد شوید.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (RegistryManager.GetKeyValues(key).Any(item => item.Name == name))
            {
                MessageBox.Show("این نام استفاده شده است.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RegistryValueKind valueKind;
            if (!Enum.TryParse(type,out valueKind))
            {
                MessageBox.Show("نوع داده وارده صحیح نیست.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            object val = null;
            switch (valueKind)
            {
                case RegistryValueKind.String:
                case RegistryValueKind.ExpandString:
                    {
                        val = value;
                    }
                    break;
                case RegistryValueKind.Binary:
                    {
                        char[] bytesList = value.ToCharArray();
                        foreach (char item in bytesList)
                        {
                            if ((int)item > byte.MaxValue)
                            {
                                MessageBox.Show("مقدار وارده صحیح نیست.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        byte[] bytes = bytesList.Select(b => (byte)b).ToArray();
                        val = bytes;
                    }
                    break;
                case RegistryValueKind.DWord:
                    {
                        UInt32 v = 0;
                        if (!UInt32.TryParse(value, out v))
                        {
                            MessageBox.Show("مقدار وارده صحیح نیست.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        val = v;
                    }
                    break;
                case RegistryValueKind.MultiString:
                    {
                        val = value.Replace(';', '\0');
                    }
                    break;
                case RegistryValueKind.QWord:
                    {
                        UInt64 v = 0;
                        if (!UInt64.TryParse(value, out v))
                        {
                            MessageBox.Show("مقدار وارده صحیح نیست.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        val = v;
                    }
                    break;
            }
            RegistryManager.AddValue(key, new RegistryValue
            {
                Name=name,
                ValueKind=valueKind,
                Value=val
            });
            MessageBox.Show("مقدار افزوده شد.", "افزودن مقدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void cmbValueKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBinaryWarning.Visible = cmbValueKind.Text.Trim() == "Binary";
            lblWarnMulti.Visible = cmbValueKind.Text.Trim() == "MultiString";
        }
    }
}
