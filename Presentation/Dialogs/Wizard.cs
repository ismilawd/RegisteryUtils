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
            //chkContextMenuCopyTo
            {
                chkContextMenuCopyTo.Checked = RegistryManager.GetRegistryKey(@"HKEY_CLASSES_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers\CopyTo") != null;
            }
            //chkContextMenuMoveTo
            {
                chkContextMenuMoveTo.Checked = RegistryManager.GetRegistryKey(@"HKEY_CLASSES_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers\MoveTo") != null;
            }
            //chkShortcutArrows
            {
                chkShortcutArrows.CheckedChanged -= chkShortcutArrows_CheckedChanged;
                chkShortcutArrows.Checked = RegistryManager.GetKeyValue(@"HKEY_CLASSES_ROOT\lnkfile", "IsShortcut") == null;
                chkShortcutArrows.CheckedChanged += chkShortcutArrows_CheckedChanged;
            }
            //chkFloatingSearch
            {
                chkFloatingSearch.Checked = RegistryManager.GetKeyValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "ImmersiveSearch") != null;
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
            string parent = @"HKEY_CLASSES_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers";
            if (chkContextMenuCopyTo.Checked)
            {
                RegistryKey key = RegistryManager.CreateKey(parent, "CopyTo");
                RegistryManager.EditValue(key.Name, "", new RegistryValue()
                {
                    Name = "",
                    Value = "{C2FBB630-2971-11D1-A18C-00C04FD75D13}",
                    ValueKind = RegistryValueKind.String
                });
            }
            else
            {
                RegistryManager.DeleteKey(parent, "CopyTo");
            }
        }

        private void chkContextMenuMoveTo_CheckedChanged(object sender, EventArgs e)
        {
            string parent = @"HKEY_CLASSES_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers";
            if (chkContextMenuMoveTo.Checked)
            {
                RegistryKey key = RegistryManager.CreateKey(parent, "MoveTo");
                RegistryManager.EditValue(key.Name, "", new RegistryValue()
                {
                    Name = "",
                    Value = "{C2FBB631-2971-11D1-A18C-00C04FD75D13}",
                    ValueKind = RegistryValueKind.String
                });
            }
            else
            {
                RegistryManager.DeleteKey(parent, "MoveTo");
            }
        }

        private void chkShortcutArrows_CheckedChanged(object sender, EventArgs e)
        {
            string key = @"HKEY_CLASSES_ROOT\lnkfile";
            if (chkShortcutArrows.Checked)
            {
                RegistryManager.DeleteValue($"{key}\\IsShortcut");
            }
            else
            {
                RegistryManager.AddValue(key, new RegistryValue
                {
                    Name = "IsShortcut",
                    Value = "",
                    ValueKind = RegistryValueKind.String
                });
            }
        }

        private void chkFloatingSearch_CheckedChanged(object sender, EventArgs e)
        {
            string parent = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search";
            if (chkFloatingSearch.Checked)
            {
                RegistryManager.AddValue(parent, new RegistryValue
                {
                    Name="ImmersiveSearch",
                    Value=1,
                    ValueKind=RegistryValueKind.DWord
                });
            }
            else
            {
                RegistryManager.DeleteValue($"{parent}\\ImmersiveSearch");
            }
        }
    }
}
