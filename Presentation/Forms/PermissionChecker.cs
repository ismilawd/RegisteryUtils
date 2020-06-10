using MetroFramework.Forms;
using RegisteryApi.Registery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class PermissionChecker : MetroForm
    {
        Thread thCheckPermission;
        public PermissionChecker()
        {
            InitializeComponent();
            thCheckPermission = new Thread(CheckPermission);
        }

        private void CheckPermission()
        {
            Thread.Sleep(1000);
            if (RegisteryManager.HavePermissionsOnKey(System.Security.Permissions.RegistryPermissionAccess.AllAccess, "HKEY_LOCAL_MACHINE"))
            {
                Invoke(new Action(() =>
                {
                    lblPermissionStatus.UseCustomForeColor = true;
                    lblPermissionStatus.ForeColor = Color.Green;
                    lblPermissionStatus.Text = "دسترسی شما تثبیت شد.";
                }));
                Thread.Sleep(2000);
                Invoke(new Action(() =>
                {
                    MainForm form = new MainForm();
                    form.Show();
                    this.Hide();
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    lblPermissionStatus.UseCustomForeColor = true;
                    lblPermissionStatus.ForeColor = Color.Red;
                    lblPermissionStatus.Text = "شما به رجیستری سیستم دسترسی ندارید.لطفا با حساب مدیر وارد شوید.";
                }));
                Thread.Sleep(2000);
                Invoke(new Action(() =>
                {
                    Environment.Exit(-1);
                }));
            }
        }

        private void PermissionChecker_Shown(object sender, EventArgs e)
        {
            FocusMe();
            thCheckPermission.Start();
        }
    }
}
