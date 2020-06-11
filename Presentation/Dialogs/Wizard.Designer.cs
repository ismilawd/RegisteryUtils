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
            this.SuspendLayout();
            // 
            // chkFastStartMenu
            // 
            this.chkFastStartMenu.AutoSize = true;
            this.chkFastStartMenu.Location = new System.Drawing.Point(683, 12);
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
            this.chkRestrictChangingDesktopWallpaper.Location = new System.Drawing.Point(569, 33);
            this.chkRestrictChangingDesktopWallpaper.Name = "chkRestrictChangingDesktopWallpaper";
            this.chkRestrictChangingDesktopWallpaper.Size = new System.Drawing.Size(219, 15);
            this.chkRestrictChangingDesktopWallpaper.TabIndex = 1;
            this.chkRestrictChangingDesktopWallpaper.Text = "Restrict Changing Desktop Wallpaper";
            this.chkRestrictChangingDesktopWallpaper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRestrictChangingDesktopWallpaper.UseSelectable = true;
            this.chkRestrictChangingDesktopWallpaper.CheckedChanged += new System.EventHandler(this.chkRestrictChangingDesktopWallpaper_CheckedChanged);
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}