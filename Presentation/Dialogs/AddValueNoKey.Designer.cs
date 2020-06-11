namespace Presentation.Dialogs
{
    partial class AddValueNoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddValueNoKey));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtValue = new MetroFramework.Controls.MetroTextBox();
            this.cmbValueKind = new MetroFramework.Controls.MetroComboBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.lblBinaryWarning = new MetroFramework.Controls.MetroLabel();
            this.lblWarnMulti = new MetroFramework.Controls.MetroLabel();
            this.txtKeyName = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام مقدار:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نوع داده:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "مقدار:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(67, 41);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(312, 23);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.CustomButton.Image = null;
            this.txtValue.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.txtValue.CustomButton.Name = "";
            this.txtValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValue.CustomButton.TabIndex = 1;
            this.txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValue.CustomButton.UseSelectable = true;
            this.txtValue.CustomButton.Visible = false;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(67, 110);
            this.txtValue.MaxLength = 32767;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(312, 23);
            this.txtValue.TabIndex = 4;
            this.txtValue.UseSelectable = true;
            this.txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbValueKind
            // 
            this.cmbValueKind.FormattingEnabled = true;
            this.cmbValueKind.ItemHeight = 23;
            this.cmbValueKind.Items.AddRange(new object[] {
            "DWord",
            "ExpandString",
            "String",
            "Binary",
            "MultiString",
            "QWord"});
            this.cmbValueKind.Location = new System.Drawing.Point(67, 72);
            this.cmbValueKind.Name = "cmbValueKind";
            this.cmbValueKind.Size = new System.Drawing.Size(312, 29);
            this.cmbValueKind.TabIndex = 5;
            this.cmbValueKind.UseSelectable = true;
            this.cmbValueKind.SelectedIndexChanged += new System.EventHandler(this.cmbValueKind_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ذخیره";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBinaryWarning
            // 
            this.lblBinaryWarning.AutoSize = true;
            this.lblBinaryWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblBinaryWarning.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBinaryWarning.ForeColor = System.Drawing.Color.Red;
            this.lblBinaryWarning.Location = new System.Drawing.Point(67, 136);
            this.lblBinaryWarning.Name = "lblBinaryWarning";
            this.lblBinaryWarning.Size = new System.Drawing.Size(293, 15);
            this.lblBinaryWarning.TabIndex = 7;
            this.lblBinaryWarning.Text = "کد اسکی هر کاراکتر به عنوان مقدار بایت در نظر گرفته خواهد شد.";
            this.lblBinaryWarning.UseCustomForeColor = true;
            this.lblBinaryWarning.Visible = false;
            // 
            // lblWarnMulti
            // 
            this.lblWarnMulti.AutoSize = true;
            this.lblWarnMulti.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnMulti.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblWarnMulti.ForeColor = System.Drawing.Color.Red;
            this.lblWarnMulti.Location = new System.Drawing.Point(67, 136);
            this.lblWarnMulti.Name = "lblWarnMulti";
            this.lblWarnMulti.Size = new System.Drawing.Size(194, 15);
            this.lblWarnMulti.TabIndex = 8;
            this.lblWarnMulti.Text = "مقادیر را با کاراکتر \';\' از یک دیگر جدا نمایید.";
            this.lblWarnMulti.UseCustomForeColor = true;
            this.lblWarnMulti.Visible = false;
            // 
            // txtKeyName
            // 
            // 
            // 
            // 
            this.txtKeyName.CustomButton.Image = null;
            this.txtKeyName.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.txtKeyName.CustomButton.Name = "";
            this.txtKeyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKeyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeyName.CustomButton.TabIndex = 1;
            this.txtKeyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKeyName.CustomButton.UseSelectable = true;
            this.txtKeyName.CustomButton.Visible = false;
            this.txtKeyName.Lines = new string[0];
            this.txtKeyName.Location = new System.Drawing.Point(67, 12);
            this.txtKeyName.MaxLength = 32767;
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.PasswordChar = '\0';
            this.txtKeyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeyName.SelectedText = "";
            this.txtKeyName.SelectionLength = 0;
            this.txtKeyName.SelectionStart = 0;
            this.txtKeyName.ShortcutsEnabled = true;
            this.txtKeyName.Size = new System.Drawing.Size(312, 23);
            this.txtKeyName.TabIndex = 10;
            this.txtKeyName.UseSelectable = true;
            this.txtKeyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKeyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "نام کلید:";
            // 
            // AddValueNoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 192);
            this.Controls.Add(this.txtKeyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWarnMulti);
            this.Controls.Add(this.lblBinaryWarning);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbValueKind);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddValueNoKey";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن مقدار";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtValue;
        private MetroFramework.Controls.MetroComboBox cmbValueKind;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel lblBinaryWarning;
        private MetroFramework.Controls.MetroLabel lblWarnMulti;
        private MetroFramework.Controls.MetroTextBox txtKeyName;
        private System.Windows.Forms.Label label4;
    }
}