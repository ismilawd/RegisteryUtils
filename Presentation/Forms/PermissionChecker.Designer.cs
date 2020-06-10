namespace Presentation.Forms
{
    partial class PermissionChecker
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
            this.lblPermissionStatus = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblPermissionStatus
            // 
            this.lblPermissionStatus.AutoSize = true;
            this.lblPermissionStatus.Location = new System.Drawing.Point(23, 90);
            this.lblPermissionStatus.Name = "lblPermissionStatus";
            this.lblPermissionStatus.Size = new System.Drawing.Size(146, 19);
            this.lblPermissionStatus.TabIndex = 0;
            this.lblPermissionStatus.Text = "درحال بررسی دسترسی شما";
            this.lblPermissionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PermissionChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 159);
            this.ControlBox = false;
            this.Controls.Add(this.lblPermissionStatus);
            this.Movable = false;
            this.Name = "PermissionChecker";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بررسی سطح دسترسی";
            this.Shown += new System.EventHandler(this.PermissionChecker_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPermissionStatus;
    }
}