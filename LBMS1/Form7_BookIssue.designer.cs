namespace LBMS1
{
    partial class Form7_BookIssue
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_mid = new System.Windows.Forms.ComboBox();
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            this.comboBox_book = new System.Windows.Forms.ComboBox();
            this.textBox_redate = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_bid = new System.Windows.Forms.TextBox();
            this.dateTimePicker_idate = new System.Windows.Forms.DateTimePicker();
            this.lBMSDataSet = new LBMS1.LBMSDataSet();
            this.book_IssueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_IssueTableAdapter = new LBMS1.LBMSDataSetTableAdapters.Book_IssueTableAdapter();
            this.tableAdapterManager = new LBMS1.LBMSDataSetTableAdapters.TableAdapterManager();
            this.book_IssueDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_update = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_IssueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_IssueDataGridView)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(972, 24);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Title";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Book ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Issue Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Return Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_mid
            // 
            this.comboBox_mid.FormattingEnabled = true;
            this.comboBox_mid.Items.AddRange(new object[] {
            "<select>"});
            this.comboBox_mid.Location = new System.Drawing.Point(115, 53);
            this.comboBox_mid.Name = "comboBox_mid";
            this.comboBox_mid.Size = new System.Drawing.Size(100, 21);
            this.comboBox_mid.TabIndex = 2;
            this.comboBox_mid.Text = "<select>";
            this.comboBox_mid.SelectedIndexChanged += new System.EventHandler(this.comboBox_mid_SelectedIndexChanged);
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Items.AddRange(new object[] {
            "<select>"});
            this.comboBox_cat.Location = new System.Drawing.Point(114, 86);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(148, 21);
            this.comboBox_cat.TabIndex = 2;
            this.comboBox_cat.Text = "<select>";
            this.comboBox_cat.SelectedIndexChanged += new System.EventHandler(this.comboBox_cat_SelectedIndexChanged);
            // 
            // comboBox_book
            // 
            this.comboBox_book.FormattingEnabled = true;
            this.comboBox_book.Location = new System.Drawing.Point(114, 120);
            this.comboBox_book.Name = "comboBox_book";
            this.comboBox_book.Size = new System.Drawing.Size(148, 21);
            this.comboBox_book.TabIndex = 2;
            this.comboBox_book.Text = "<select>";
            this.comboBox_book.SelectedIndexChanged += new System.EventHandler(this.comboBox_book_SelectedIndexChanged);
            // 
            // textBox_redate
            // 
            this.textBox_redate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_redate.Location = new System.Drawing.Point(115, 228);
            this.textBox_redate.Name = "textBox_redate";
            this.textBox_redate.ReadOnly = true;
            this.textBox_redate.Size = new System.Drawing.Size(100, 20);
            this.textBox_redate.TabIndex = 3;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(76, 281);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_bid
            // 
            this.textBox_bid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_bid.Location = new System.Drawing.Point(115, 158);
            this.textBox_bid.Name = "textBox_bid";
            this.textBox_bid.ReadOnly = true;
            this.textBox_bid.Size = new System.Drawing.Size(55, 20);
            this.textBox_bid.TabIndex = 3;
            // 
            // dateTimePicker_idate
            // 
            this.dateTimePicker_idate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_idate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_idate.Location = new System.Drawing.Point(115, 194);
            this.dateTimePicker_idate.Name = "dateTimePicker_idate";
            this.dateTimePicker_idate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_idate.TabIndex = 53;
            this.dateTimePicker_idate.ValueChanged += new System.EventHandler(this.dateTimePicker_idate_ValueChanged);
            // 
            // lBMSDataSet
            // 
            this.lBMSDataSet.DataSetName = "LBMSDataSet";
            this.lBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_IssueBindingSource
            // 
            this.book_IssueBindingSource.DataMember = "Book_Issue";
            this.book_IssueBindingSource.DataSource = this.lBMSDataSet;
            // 
            // book_IssueTableAdapter
            // 
            this.book_IssueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_IssueTableAdapter = this.book_IssueTableAdapter;
            this.tableAdapterManager.Book_ReturnTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LBMS1.LBMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // book_IssueDataGridView
            // 
            this.book_IssueDataGridView.AutoGenerateColumns = false;
            this.book_IssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_IssueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.book_IssueDataGridView.DataSource = this.book_IssueBindingSource;
            this.book_IssueDataGridView.Location = new System.Drawing.Point(294, 52);
            this.book_IssueDataGridView.Name = "book_IssueDataGridView";
            this.book_IssueDataGridView.Size = new System.Drawing.Size(666, 252);
            this.book_IssueDataGridView.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BI No";
            this.dataGridViewTextBoxColumn1.HeaderText = "BI No";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn4.HeaderText = "Title";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Book ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Issued date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Issued date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Return date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Return date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(579, 393);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 55;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Form7_BookIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 490);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.book_IssueDataGridView);
            this.Controls.Add(this.dateTimePicker_idate);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_bid);
            this.Controls.Add(this.textBox_redate);
            this.Controls.Add(this.comboBox_book);
            this.Controls.Add(this.comboBox_cat);
            this.Controls.Add(this.comboBox_mid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form7_BookIssue";
            this.Text = "Form7_BookIssue";
            this.Load += new System.EventHandler(this.Form7_BookIssue_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_IssueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_IssueDataGridView)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_mid;
        private System.Windows.Forms.ComboBox comboBox_cat;
        private System.Windows.Forms.ComboBox comboBox_book;
        private System.Windows.Forms.TextBox textBox_redate;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_bid;
        private System.Windows.Forms.DateTimePicker dateTimePicker_idate;
        private LBMSDataSet lBMSDataSet;
        private System.Windows.Forms.BindingSource book_IssueBindingSource;
        private LBMSDataSetTableAdapters.Book_IssueTableAdapter book_IssueTableAdapter;
        private LBMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView book_IssueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button_update;
    }
}

