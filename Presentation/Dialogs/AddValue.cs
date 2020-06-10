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
    public partial class AddValue : Form
    {
        public string _key = "";
        public AddValue(string key)
        {
            _key = key;
            InitializeComponent();
            if (_key.Length > 0)
                Text = $"{Text} ({key})";
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string type = cmbValueKind.Text.Trim();
            string value = txtValue.Text.Trim();
            if (RegistryManager.GetKeyValues(_key).Any(item => item.Name == name))
            {
                MessageBox.Show("این نام استفاده شده است.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (name.Length==0 || type.Length==0 || value.Length==0)
            {
                MessageBox.Show("لطفا مقادیر را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            RegistryManager.AddValue(_key, new RegistryValue
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
