namespace LBMS1
{
    partial class Form8_BookReturn
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_mid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_bid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_rdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_delay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_fine = new System.Windows.Forms.TextBox();
            this.lBMSDataSet = new LBMS1.LBMSDataSet();
            this.book_ReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_ReturnTableAdapter = new LBMS1.LBMSDataSetTableAdapters.Book_ReturnTableAdapter();
            this.tableAdapterManager = new LBMS1.LBMSDataSetTableAdapters.TableAdapterManager();
            this.book_ReturnDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_update = new System.Windows.Forms.Button();
            this.dateTimePicker_idate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_ReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_ReturnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AllowDrop = true;
            this.menuStrip.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.membershipToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.loginInfoToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // loginInfoToolStripMenuItem
            // 
            this.loginInfoToolStripMenuItem.Name = "loginInfoToolStripMenuItem";
            this.loginInfoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loginInfoToolStripMenuItem.Text = "Login Info";
            this.loginInfoToolStripMenuItem.Click += new System.EventHandler(this.loginInfoToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerToolStripMenuItem,
            this.bookEntryToolStripMenuItem,
            this.membershipToolStripMenuItem1,
            this.bookIssueToolStripMenuItem,
            this.bookReturnToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // bookEntryToolStripMenuItem
            // 
            this.bookEntryToolStripMenuItem.Name = "bookEntryToolStripMenuItem";
            this.bookEntryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bookEntryToolStripMenuItem.Text = "Book Entry";
            this.bookEntryToolStripMenuItem.Click += new System.EventHandler(this.bookEntryToolStripMenuItem_Click);
            // 
            // membershipToolStripMenuItem1
            // 
            this.membershipToolStripMenuItem1.Name = "membershipToolStripMenuItem1";
            this.membershipToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.membershipToolStripMenuItem1.Text = "Membership";
            this.membershipToolStripMenuItem1.Click += new System.EventHandler(this.membershipToolStripMenuItem1_Click);
            // 
            // bookIssueToolStripMenuItem
            // 
            this.bookIssueToolStripMenuItem.Name = "bookIssueToolStripMenuItem";
            this.bookIssueToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bookIssueToolStripMenuItem.Text = "Book Issue";
            this.bookIssueToolStripMenuItem.Click += new System.EventHandler(this.bookIssueToolStripMenuItem_Click);
            // 
            // bookReturnToolStripMenuItem
            // 
            this.bookReturnToolStripMenuItem.Name = "bookReturnToolStripMenuItem";
            this.bookReturnToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bookReturnToolStripMenuItem.Text = "Book Return";
            this.bookReturnToolStripMenuItem.Click += new System.EventHandler(this.bookReturnToolStripMenuItem_Click);
            // 
            // membershipToolStripMenuItem
            // 
            this.membershipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentMembershipToolStripMenuItem,
            this.teacherMembershipToolStripMenuItem,
            this.employeeMembershipToolStripMenuItem});
            this.membershipToolStripMenuItem.Name = "membershipToolStripMenuItem";
            this.membershipToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.membershipToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.membershipToolStripMenuItem.Text = "Membership";
            // 
            // studentMembershipToolStripMenuItem
            // 
            this.studentMembershipToolStripMenuItem.Name = "studentMembershipToolStripMenuItem";
            this.studentMembershipToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.studentMembershipToolStripMenuItem.Text = "Student Membership";
            this.studentMembershipToolStripMenuItem.Click += new System.EventHandler(this.studentMembershipToolStripMenuItem_Click);
            // 
            // teacherMembershipToolStripMenuItem
            // 
            this.teacherMembershipToolStripMenuItem.Name = "teacherMembershipToolStripMenuItem";
            this.teacherMembershipToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.teacherMembershipToolStripMenuItem.Text = "Teacher Membership";
            this.teacherMembershipToolStripMenuItem.Click += new System.EventHandler(this.teacherMembershipToolStripMenuItem_Click);
            // 
            // employeeMembershipToolStripMenuItem
            // 
            this.employeeMembershipToolStripMenuItem.Name = "employeeMembershipToolStripMenuItem";
            this.employeeMembershipToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.employeeMembershipToolStripMenuItem.Text = "Employee Membership";
            this.employeeMembershipToolStripMenuItem.Click += new System.EventHandler(this.employeeMembershipToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // comboBox_mid
            // 
            this.comboBox_mid.FormattingEnabled = true;
            this.comboBox_mid.Items.AddRange(new object[] {
            "<select>"});
            this.comboBox_mid.Location = new System.Drawing.Point(101, 88);
            this.comboBox_mid.Name = "comboBox_mid";
            this.comboBox_mid.Size = new System.Drawing.Size(148, 21);
            this.comboBox_mid.TabIndex = 7;
            this.comboBox_mid.Text = "<select>";
            this.comboBox_mid.SelectedIndexChanged += new System.EventHandler(this.comboBox_mid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Member ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(43, 334);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 59;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_bid
            // 
            this.textBox_bid.Location = new System.Drawing.Point(101, 128);
            this.textBox_bid.Name = "textBox_bid";
            this.textBox_bid.Size = new System.Drawing.Size(147, 20);
            this.textBox_bid.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Return Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Issue Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Book ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_rdate
            // 
            this.dateTimePicker_rdate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_rdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_rdate.Location = new System.Drawing.Point(100, 201);
            this.dateTimePicker_rdate.Name = "dateTimePicker_rdate";
            this.dateTimePicker_rdate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_rdate.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Delay Days";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_delay
            // 
            this.textBox_delay.Location = new System.Drawing.Point(101, 244);
            this.textBox_delay.Name = "textBox_delay";
            this.textBox_delay.Size = new System.Drawing.Size(100, 20);
            this.textBox_delay.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Late Fine";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_fine
            // 
            this.textBox_fine.Location = new System.Drawing.Point(101, 279);
            this.textBox_fine.Name = "textBox_fine";
            this.textBox_fine.Size = new System.Drawing.Size(100, 20);
            this.textBox_fine.TabIndex = 58;
            // 
            // lBMSDataSet
            // 
            this.lBMSDataSet.DataSetName = "LBMSDataSet";
            this.lBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_ReturnBindingSource
            // 
            this.book_ReturnBindingSource.DataMember = "Book_Return";
            this.book_ReturnBindingSource.DataSource = this.lBMSDataSet;
            // 
            // book_ReturnTableAdapter
            // 
            this.book_ReturnTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_IssueTableAdapter = null;
            this.tableAdapterManager.Book_ReturnTableAdapter = this.book_ReturnTableAdapter;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LBMS1.LBMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // book_ReturnDataGridView
            // 
            this.book_ReturnDataGridView.AutoGenerateColumns = false;
            this.book_ReturnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_ReturnDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.book_ReturnDataGridView.DataSource = this.book_ReturnBindingSource;
            this.book_ReturnDataGridView.Location = new System.Drawing.Point(286, 88);
            this.book_ReturnDataGridView.Name = "book_ReturnDataGridView";
            this.book_ReturnDataGridView.Size = new System.Drawing.Size(703, 300);
            this.book_ReturnDataGridView.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BR no";
            this.dataGridViewTextBoxColumn1.HeaderText = "BR no";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Member ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Member ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Book ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Issued date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Issued date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Return date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Return date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Delay";
            this.dataGridViewTextBoxColumn6.HeaderText = "Delay";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fine";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fine";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(554, 432);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 62;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // dateTimePicker_idate
            // 
            this.dateTimePicker_idate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_idate.Enabled = false;
            this.dateTimePicker_idate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_idate.Location = new System.Drawing.Point(101, 164);
            this.dateTimePicker_idate.Name = "dateTimePicker_idate";
            this.dateTimePicker_idate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_idate.TabIndex = 60;
            // 
            // Form8_BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 490);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.book_ReturnDataGridView);
            this.Controls.Add(this.dateTimePicker_idate);
            this.Controls.Add(this.dateTimePicker_rdate);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_bid);
            this.Controls.Add(this.textBox_fine);
            this.Controls.Add(this.textBox_delay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_mid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form8_BookReturn";
            this.Text = "Form8_BookReturn";
            this.Load += new System.EventHandler(this.Form8_BookReturn_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_ReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_ReturnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem membershipToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ComboBox comboBox_mid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_bid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_rdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_delay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_fine;
        private LBMSDataSet lBMSDataSet;
        private System.Windows.Forms.BindingSource book_ReturnBindingSource;
        private LBMSDataSetTableAdapters.Book_ReturnTableAdapter book_ReturnTableAdapter;
        private LBMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView book_ReturnDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DateTimePicker dateTimePicker_idate;
    }
}

