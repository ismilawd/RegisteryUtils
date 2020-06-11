using Presentation.Forms;
using RegisteryApi.Registery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PermissionChecker permissionChecker = new PermissionChecker();
            permissionChecker.ShowDialog();
            if (permissionChecker.HasPermission)

                Application.Run(new MainForm());
        }
    }
}
