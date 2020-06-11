namespace Presentation.Dialogs
{
    partial class Wizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard));
            this.chkFastStartMenu = new MetroFramework.Controls.MetroCheckBox();
            this.chkRestrictChangingDesktopWallpaper = new MetroFramework.Controls.MetroCheckBox();
            this.chkHideDrives = new MetroFramework.Controls.MetroCheckBox();
            this.chkClearRunHistory = new MetroFramework.Controls.MetroCheckBox();
            this.chkContextMenuCopyTo = new MetroFramework.Controls.MetroCheckBox();
            this.chkContextMenuMoveTo = new MetroFramework.Controls.MetroCheckBox();
            this.chkShortcutArrows = new MetroFramework.Controls.MetroCheckBox();
            this.chkFloatingSearch = new MetroFramework.Controls.MetroCheckBox();
            this.chkClockSeconds = new MetroFramework.Controls.MetroCheckBox();
            this.chkDisableLockScreen = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // chkFastStartMenu
            // 
            this.chkFastStartMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFastStartMenu.AutoSize = true;
            this.chkFastStartMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFastStartMenu.Location = new System.Drawing.Point(-562, 10);
            this.chkFastStartMenu.Name = "chkFastStartMenu";
            this.chkFastStartMenu.Size = new System.Drawing.Size(105, 15);
            this.chkFastStartMenu.TabIndex = 0;
            this.chkFastStartMenu.Text = "Fast Start Menu";
            this.chkFastStartMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFastStartMenu.UseSelectable = true;
            this.chkFastStartMenu.CheckedChanged += new System.EventHandler(this.chkFastStartMenu_CheckedChanged);
            // 
            // chkRestrictChangingDesktopWallpaper
            // 
            this.chkRestrictChangingDesktopWallpaper.AutoSize = true;
            this.chkRestrictChangingDesktopWallpaper.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRestrictChangingDesktopWallpaper.Location = new System.Drawing.Point(12, 31);
            this.chkRestrictChangingDesktopWallpaper.Name = "chkRestrictChangingDesktopWallpaper";
            this.chkRestrictChangingDesktopWallpaper.Size = new System.Drawing.Size(219, 15);
            this.chkRestrictChangingDesktopWallpaper.TabIndex = 1;
            this.chkRestrictChangingDesktopWallpaper.Text = "Restrict Changing Desktop Wallpaper";
            this.chkRestrictChangingDesktopWallpaper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRestrictChangingDesktopWallpaper.UseSelectable = true;
            this.chkRestrictChangingDesktopWallpaper.CheckedChanged += new System.EventHandler(this.chkRestrictChangingDesktopWallpaper_CheckedChanged);
            // 
            // chkHideDrives
            // 
            this.chkHideDrives.AutoSize = true;
            this.chkHideDrives.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHideDrives.Location = new System.Drawing.Point(12, 52);
            this.chkHideDrives.Name = "chkHideDrives";
            this.chkHideDrives.Size = new System.Drawing.Size(83, 15);
            this.chkHideDrives.TabIndex = 2;
            this.chkHideDrives.Text = "Hide Drives";
            this.chkHideDrives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHideDrives.UseSelectable = true;
            this.chkHideDrives.CheckedChanged += new System.EventHandler(this.chkHideDrives_CheckedChanged);
            // 
            // chkClearRunHistory
            // 
            this.chkClearRunHistory.AutoSize = true;
            this.chkClearRunHistory.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClearRunHistory.Location = new System.Drawing.Point(12, 73);
            this.chkClearRunHistory.Name = "chkClearRunHistory";
            this.chkClearRunHistory.Size = new System.Drawing.Size(115, 15);
            this.chkClearRunHistory.TabIndex = 3;
            this.chkClearRunHistory.Text = "Clear Run History";
            this.chkClearRunHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClearRunHistory.UseSelectable = true;
            this.chkClearRunHistory.CheckedChanged += new System.EventHandler(this.chkClearRunHistory_CheckedChanged);
            // 
            // chkContextMenuCopyTo
            // 
            this.chkContextMenuCopyTo.AutoSize = true;
            this.chkContextMenuCopyTo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkContextMenuCopyTo.Location = new System.Drawing.Point(12, 94);
            this.chkContextMenuCopyTo.Name = "chkContextMenuCopyTo";
            this.chkContextMenuCopyTo.Size = new System.Drawing.Size(183, 15);
            this.chkContextMenuCopyTo.TabIndex = 4;
            this.chkContextMenuCopyTo.Text = "Enable Context Menu Copy To";
            this.chkContextMenuCopyTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkContextMenuCopyTo.UseSelectable = true;
            this.chkContextMenuCopyTo.CheckedChanged += new System.EventHandler(this.chkContextMenuCopyTo_CheckedChanged);
            // 
            // chkContextMenuMoveTo
            // 
            this.chkContextMenuMoveTo.AutoSize = true;
            this.chkContextMenuMoveTo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkContextMenuMoveTo.Location = new System.Drawing.Point(12, 115);
            this.chkContextMenuMoveTo.Name = "chkContextMenuMoveTo";
            this.chkContextMenuMoveTo.Size = new System.Drawing.Size(185, 15);
            this.chkContextMenuMoveTo.TabIndex = 5;
            this.chkContextMenuMoveTo.Text = "Enable Context Menu Move To";
            this.chkContextMenuMoveTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkContextMenuMoveTo.UseSelectable = true;
            this.chkContextMenuMoveTo.CheckedChanged += new System.EventHandler(this.chkContextMenuMoveTo_CheckedChanged);
            // 
            // chkShortcutArrows
            // 
            this.chkShortcutArrows.AutoSize = true;
            this.chkShortcutArrows.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShortcutArrows.Location = new System.Drawing.Point(12, 136);
            this.chkShortcutArrows.Name = "chkShortcutArrows";
            this.chkShortcutArrows.Size = new System.Drawing.Size(154, 15);
            this.chkShortcutArrows.TabIndex = 6;
            this.chkShortcutArrows.Text = "Remove Shortcut Arrows";
            this.chkShortcutArrows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShortcutArrows.UseSelectable = true;
            this.chkShortcutArrows.CheckedChanged += new System.EventHandler(this.chkShortcutArrows_CheckedChanged);
            // 
            // chkFloatingSearch
            // 
            this.chkFloatingSearch.AutoSize = true;
            this.chkFloatingSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFloatingSearch.Location = new System.Drawing.Point(12, 157);
            this.chkFloatingSearch.Name = "chkFloatingSearch";
            this.chkFloatingSearch.Size = new System.Drawing.Size(104, 15);
            this.chkFloatingSearch.TabIndex = 7;
            this.chkFloatingSearch.Text = "Floating Search";
            this.chkFloatingSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFloatingSearch.UseSelectable = true;
            this.chkFloatingSearch.CheckedChanged += new System.EventHandler(this.chkFloatingSearch_CheckedChanged);
            // 
            // chkClockSeconds
            // 
            this.chkClockSeconds.AutoSize = true;
            this.chkClockSeconds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClockSeconds.Location = new System.Drawing.Point(12, 178);
            this.chkClockSeconds.Name = "chkClockSeconds";
            this.chkClockSeconds.Size = new System.Drawing.Size(142, 15);
            this.chkClockSeconds.TabIndex = 8;
            this.chkClockSeconds.Text = "Taskbar Clock Seconds";
            this.chkClockSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClockSeconds.UseSelectable = true;
            this.chkClockSeconds.CheckedChanged += new System.EventHandler(this.chkClockSeconds_CheckedChanged);
            // 
            // chkDisableLockScreen
            // 
            this.chkDisableLockScreen.AutoSize = true;
            this.chkDisableLockScreen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDisableLockScreen.Location = new System.Drawing.Point(12, 199);
            this.chkDisableLockScreen.Name = "chkDisableLockScreen";
            this.chkDisableLockScreen.Size = new System.Drawing.Size(127, 15);
            this.chkDisableLockScreen.TabIndex = 9;
            this.chkDisableLockScreen.Text = "Disable Lock Screen";
            this.chkDisableLockScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDisableLockScreen.UseSelectable = true;
            this.chkDisableLockScreen.CheckedChanged += new System.EventHandler(this.chkDisableLockScreen_CheckedChanged);
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 224);
            this.Controls.Add(this.chkDisableLockScreen);
            this.Controls.Add(this.chkClockSeconds);
            this.Controls.Add(this.chkFloatingSearch);
            this.Controls.Add(this.chkShortcutArrows);
            this.Controls.Add(this.chkContextMenuMoveTo);
            this.Controls.Add(this.chkContextMenuCopyTo);
            this.Controls.Add(this.chkClearRunHistory);
            this.Controls.Add(this.chkHideDrives);
            this.Controls.Add(this.chkRestrictChangingDesktopWallpaper);
            this.Controls.Add(this.chkFastStartMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wizard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جادوگر رجیستری";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wizard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chkFastStartMenu;
        private MetroFramework.Controls.MetroCheckBox chkRestrictChangingDesktopWallpaper;
        private MetroFramework.Controls.MetroCheckBox chkHideDrives;
        private MetroFramework.Controls.MetroCheckBox chkClearRunHistory;
        private MetroFramework.Controls.MetroCheckBox chkContextMenuCopyTo;
        private MetroFramework.Controls.MetroCheckBox chkContextMenuMoveTo;
        private MetroFramework.Controls.MetroCheckBox chkShortcutArrows;
        private MetroFramework.Controls.MetroCheckBox chkFloatingSearch;
        private MetroFramework.Controls.MetroCheckBox chkClockSeconds;
        private MetroFramework.Controls.MetroCheckBox chkDisableLockScreen;
    }
}