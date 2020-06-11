using Microsoft.Win32;
using RegisteryApi.Registery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Dialogs
{
    public partial class Wizard : Form
    {
        public Wizard()
        {
            InitializeComponent();
            BindValues();
        }
        private void BindValues()
        {
            //chkFastStartMenu
            {
                chkFastStartMenu.Checked = RegistryManager.GetKeyValue("HKEY_CURRENT_USER\\CONTROL PANEL\\DESKTOP", "MenuShowDelay").Value.ToString() == "1";
            }
            //chkRestrictChangingDesktopWallpaper
            {
                chkRestrictChangingDesktopWallpaper.Checked = RegistryManager.GetRegistryKey(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System") != null;
            }
            //chkHideDrives
            {
                chkHideDrives.Checked = RegistryManager.GetKeyValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDrives") != null;
            }
        }
        private void chkFastStartMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFastStartMenu.Checked)
            {
                RegistryManager.EditValue("HKEY_CURRENT_USER\\CONTROL PANEL\\DESKTOP", "MenuShowDelay", new RegistryValue()
                {
                    Name = "MenuShowDelay",
                    ValueKind = RegistryValueKind.String,
                    Value = "1"
                });
            }
            else
            {
                RegistryManager.EditValue("HKEY_CURRENT_USER\\CONTROL PANEL\\DESKTOP", "MenuShowDelay", new RegistryValue()
                {
                    Name = "MenuShowDelay",
                    ValueKind = RegistryValueKind.String,
                    Value = "400"
                });
            }
        }

        private void Wizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("برای اعمال تغییرات سیستم باید ریستارت شود.آیا برای ریستارت اطمینان دارید؟", "اعمال تغیرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.FileName = "cmd";
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Arguments = "/C shutdown -f -r -t 5";
                Process.Start(proc);
            }
        }

        private void chkRestrictChangingDesktopWallpaper_CheckedChanged(object sender, EventArgs e)
        {
            string parentKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies";
            if (chkRestrictChangingDesktopWallpaper.Checked)
            {
                RegistryKey key = RegistryManager.CreateKey(parentKey, "System");
                string lastWallpaper = RegistryManager.GetKeyValue(@"HKEY_CURRENT_USER\Control Panel\Desktop", "WallPaper").Value.ToString();
                RegistryManager.AddValue(key.Name, new RegistryValue()
                {
                    Name = "WallPaper",
                    Value = lastWallpaper,
                    ValueKind = RegistryValueKind.String
                });
            }
            else
            {
                RegistryManager.DeleteKey(parentKey, "System");
            }
        }

        private void chkHideDrives_CheckedChanged(object sender, EventArgs e)
        {
            string key = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer";
            if (chkHideDrives.Checked)
            {
                RegistryManager.AddValue(key, new RegistryValue()
                {
                    Name = "NoDrives",
                    Value = 67108863,
                    ValueKind = RegistryValueKind.DWord
                });
            }
            else
            {
                RegistryManager.DeleteValue($"{key}\\NoDrives");
            }
        }

        private void chkClearRunHistory_CheckedChanged(object sender, EventArgs e)
        {
            string key = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU";
            if (chkClearRunHistory.Checked)
            {
                RegistryValue[] values = RegistryManager.GetKeyValues(key);
                foreach (RegistryValue item in values)
                {
                    RegistryManager.DeleteValue($"{key}\\{item.Name}");
                }
            }
        }

        private void chkContextMenuCopyTo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
