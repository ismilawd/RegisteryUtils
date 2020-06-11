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
    public partial class AddKey : Form
    {
        public string _key = "";
        public AddKey(string key)
        {
            _key = key;
            InitializeComponent();
            if (_key.Length > 0)
                Text = $"{Text} ({key})";
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (RegistryManager.GetRegistryKeys(_key).Any(item => item.Name == name))
            {
                MessageBox.Show("این نام استفاده شده است.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (name.Length==0)
            {
                MessageBox.Show("لطفا مقادیر را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            RegistryManager.CreateKey(_key,name);
            MessageBox.Show("کلید افزوده شد.", "افزودن کلید", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
