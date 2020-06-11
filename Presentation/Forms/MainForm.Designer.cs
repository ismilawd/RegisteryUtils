namespace Presentation.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.مدیریتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ابزارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAboutDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLog = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.treeViewRegistery = new System.Windows.Forms.TreeView();
            this.treeContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.treeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.treeDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.keysImageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridValues = new MetroFramework.Controls.MetroGrid();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValueKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gridAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.gridDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gridEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.treeContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValues)).BeginInit();
            this.gridContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.White;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتToolStripMenuItem,
            this.ابزارToolStripMenuItem,
            this.راهنماToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(20, 60);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(964, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // مدیریتToolStripMenuItem
            // 
            this.مدیریتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolStripSeparator1,
            this.toolBackup,
            this.toolRestore,
            this.toolStripSeparator2,
            this.toolExit});
            this.مدیریتToolStripMenuItem.Name = "مدیریتToolStripMenuItem";
            this.مدیریتToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.مدیریتToolStripMenuItem.Text = "مدیریت";
            // 
            // toolAdd
            // 
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(148, 22);
            this.toolAdd.Text = "ایجاد";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolBackup
            // 
            this.toolBackup.Name = "toolBackup";
            this.toolBackup.Size = new System.Drawing.Size(148, 22);
            this.toolBackup.Text = "پشتیبان گیری";
            this.toolBackup.Visible = false;
            this.toolBackup.Click += new System.EventHandler(this.toolBackup_Click);
            // 
            // toolRestore
            // 
            this.toolRestore.Name = "toolRestore";
            this.toolRestore.Size = new System.Drawing.Size(148, 22);
            this.toolRestore.Text = "بازیابی پشتیبان";
            this.toolRestore.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(148, 22);
            this.toolExit.Text = "خروج";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // ابزارToolStripMenuItem
            // 
            this.ابزارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWizard});
            this.ابزارToolStripMenuItem.Name = "ابزارToolStripMenuItem";
            this.ابزارToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.ابزارToolStripMenuItem.Text = "ابزار";
            // 
            // toolWizard
            // 
            this.toolWizard.Name = "toolWizard";
            this.toolWizard.Size = new System.Drawing.Size(153, 22);
            this.toolWizard.Text = "جادوگر رجیستری";
            this.toolWizard.Click += new System.EventHandler(this.toolWizard_Click);
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHelp,
            this.toolAboutDeveloper,
            this.toolAbout});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // toolHelp
            // 
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(171, 22);
            this.toolHelp.Text = "راهنمای نرم افزار";
            this.toolHelp.Click += new System.EventHandler(this.toolHelp_Click);
            // 
            // toolAboutDeveloper
            // 
            this.toolAboutDeveloper.Name = "toolAboutDeveloper";
            this.toolAboutDeveloper.Size = new System.Drawing.Size(171, 22);
            this.toolAboutDeveloper.Text = "درباره توسعه دهنده";
            this.toolAboutDeveloper.Click += new System.EventHandler(this.toolAboutDeveloper_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(171, 22);
            this.toolAbout.Text = "درباره نرم افزار";
            this.toolAbout.Visible = false;
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtLog, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeViewRegistery, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridValues, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 556);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtLog
            // 
            // 
            // 
            // 
            this.txtLog.CustomButton.Image = null;
            this.txtLog.CustomButton.Location = new System.Drawing.Point(690, 2);
            this.txtLog.CustomButton.Name = "";
            this.txtLog.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLog.CustomButton.TabIndex = 1;
            this.txtLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLog.CustomButton.UseSelectable = true;
            this.txtLog.CustomButton.Visible = false;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Enabled = false;
            this.txtLog.Icon = global::Presentation.Properties.Resources.search;
            this.txtLog.Lines = new string[0];
            this.txtLog.Location = new System.Drawing.Point(3, 533);
            this.txtLog.MaxLength = 32767;
            this.txtLog.Name = "txtLog";
            this.txtLog.PasswordChar = '\0';
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLog.SelectedText = "";
            this.txtLog.SelectionLength = 0;
            this.txtLog.SelectionStart = 0;
            this.txtLog.ShortcutsEnabled = true;
            this.txtLog.Size = new System.Drawing.Size(708, 20);
            this.txtLog.TabIndex = 5;
            this.txtLog.UseSelectable = true;
            this.txtLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(690, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Icon = global::Presentation.Properties.Resources.search;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(3, 3);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(708, 20);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // treeViewRegistery
            // 
            this.treeViewRegistery.ContextMenuStrip = this.treeContextMenu;
            this.treeViewRegistery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewRegistery.ImageIndex = 0;
            this.treeViewRegistery.ImageList = this.keysImageList;
            this.treeViewRegistery.Location = new System.Drawing.Point(717, 29);
            this.treeViewRegistery.Name = "treeViewRegistery";
            this.treeViewRegistery.RightToLeftLayout = true;
            this.treeViewRegistery.SelectedImageIndex = 1;
            this.treeViewRegistery.Size = new System.Drawing.Size(244, 498);
            this.treeViewRegistery.TabIndex = 0;
            this.treeViewRegistery.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRegistery_AfterExpand);
            this.treeViewRegistery.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRegistery_AfterSelect);
            // 
            // treeContextMenu
            // 
            this.treeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeAdd,
            this.treeDelete});
            this.treeContextMenu.Name = "gridContextMenu";
            this.treeContextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeContextMenu.Size = new System.Drawing.Size(181, 70);
            this.treeContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.treeContextMenu_Opening);
            // 
            // treeAdd
            // 
            this.treeAdd.Name = "treeAdd";
            this.treeAdd.Size = new System.Drawing.Size(180, 22);
            this.treeAdd.Text = "افزودن";
            this.treeAdd.Click += new System.EventHandler(this.treeAdd_Click);
            // 
            // treeDelete
            // 
            this.treeDelete.Name = "treeDelete";
            this.treeDelete.Size = new System.Drawing.Size(180, 22);
            this.treeDelete.Text = "حذف";
            this.treeDelete.Click += new System.EventHandler(this.treeDelete_Click);
            // 
            // keysImageList
            // 
            this.keysImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("keysImageList.ImageStream")));
            this.keysImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.keysImageList.Images.SetKeyName(0, "f_close.ico");
            this.keysImageList.Images.SetKeyName(1, "f_open.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(717, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "آخرین پیغام :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(717, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "آدرس:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridValues
            // 
            this.gridValues.AllowUserToAddRows = false;
            this.gridValues.AllowUserToDeleteRows = false;
            this.gridValues.AllowUserToResizeRows = false;
            this.gridValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridValues.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridValues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridValues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnValueKind,
            this.ColumnValue});
            this.gridValues.ContextMenuStrip = this.gridContextMenu;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridValues.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridValues.EnableHeadersVisualStyles = false;
            this.gridValues.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridValues.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridValues.Location = new System.Drawing.Point(3, 29);
            this.gridValues.Name = "gridValues";
            this.gridValues.ReadOnly = true;
            this.gridValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridValues.Size = new System.Drawing.Size(708, 498);
            this.gridValues.TabIndex = 7;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "نام";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnValueKind
            // 
            this.ColumnValueKind.HeaderText = "نوع داده";
            this.ColumnValueKind.Name = "ColumnValueKind";
            this.ColumnValueKind.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.HeaderText = "مقدار";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            // 
            // gridContextMenu
            // 
            this.gridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridAdd,
            this.gridDelete,
            this.gridEdit});
            this.gridContextMenu.Name = "gridContextMenu";
            this.gridContextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridContextMenu.Size = new System.Drawing.Size(111, 70);
            this.gridContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.gridContextMenu_Opening);
            // 
            // gridAdd
            // 
            this.gridAdd.Name = "gridAdd";
            this.gridAdd.Size = new System.Drawing.Size(110, 22);
            this.gridAdd.Text = "افزودن";
            this.gridAdd.Click += new System.EventHandler(this.gridAdd_Click);
            // 
            // gridDelete
            // 
            this.gridDelete.Name = "gridDelete";
            this.gridDelete.Size = new System.Drawing.Size(110, 22);
            this.gridDelete.Text = "حذف";
            this.gridDelete.Click += new System.EventHandler(this.gridDelete_Click);
            // 
            // gridEdit
            // 
            this.gridEdit.Name = "gridEdit";
            this.gridEdit.Size = new System.Drawing.Size(110, 22);
            this.gridEdit.Text = "ویرایش";
            this.gridEdit.Click += new System.EventHandler(this.gridEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت پیشرفته";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.treeContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridValues)).EndInit();
            this.gridContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem مدیریتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ابزارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolBackup;
        private System.Windows.Forms.ToolStripMenuItem toolRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.ToolStripMenuItem toolWizard;
        private System.Windows.Forms.ToolStripMenuItem toolHelp;
        private System.Windows.Forms.ToolStripMenuItem toolAboutDeveloper;
        private System.Windows.Forms.ToolStripMenuItem toolAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeViewRegistery;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtLog;
        private System.Windows.Forms.ImageList keysImageList;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid gridValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValueKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private MetroFramework.Controls.MetroContextMenu gridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem gridAdd;
        private System.Windows.Forms.ToolStripMenuItem gridDelete;
        private System.Windows.Forms.ToolStripMenuItem gridEdit;
        private MetroFramework.Controls.MetroContextMenu treeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem treeAdd;
        private System.Windows.Forms.ToolStripMenuItem treeDelete;
    }
}