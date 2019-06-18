namespace LBMS1
{
    partial class Form2_Books
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
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_shelf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_available = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lBMSDataSet = new LBMS1.LBMSDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LBMS1.LBMSDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new LBMS1.LBMSDataSetTableAdapters.TableAdapterManager();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_update = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(959, 24);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(699, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Date Added";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_date.Location = new System.Drawing.Point(795, 389);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_date.TabIndex = 52;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(795, 433);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 51;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(713, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Shelf no";
            // 
            // textBox_shelf
            // 
            this.textBox_shelf.Location = new System.Drawing.Point(795, 349);
            this.textBox_shelf.Name = "textBox_shelf";
            this.textBox_shelf.Size = new System.Drawing.Size(100, 20);
            this.textBox_shelf.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Available";
            // 
            // textBox_available
            // 
            this.textBox_available.Location = new System.Drawing.Point(799, 314);
            this.textBox_available.Name = "textBox_available";
            this.textBox_available.Size = new System.Drawing.Size(100, 20);
            this.textBox_available.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Category";
            // 
            // textBox_category
            // 
            this.textBox_category.Location = new System.Drawing.Point(795, 244);
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.Size = new System.Drawing.Size(100, 20);
            this.textBox_category.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "ISBN";
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Location = new System.Drawing.Point(795, 186);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(100, 20);
            this.textBox_isbn.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Publisher";
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(795, 134);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(100, 20);
            this.textBox_publisher.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Author";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(795, 82);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(100, 20);
            this.textBox_author.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Title";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(795, 39);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(100, 20);
            this.textBox_title.TabIndex = 42;
            this.textBox_title.TextChanged += new System.EventHandler(this.textBox_title_TextChanged);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(799, 279);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(100, 20);
            this.textBox_quantity.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Quantity";
            // 
            // lBMSDataSet
            // 
            this.lBMSDataSet.DataSetName = "LBMSDataSet";
            this.lBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.lBMSDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_IssueTableAdapter = null;
            this.tableAdapterManager.Book_ReturnTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LBMS1.LBMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.bookDataGridView.DataSource = this.bookBindingSource;
            this.bookDataGridView.Location = new System.Drawing.Point(12, 64);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.Size = new System.Drawing.Size(670, 345);
            this.bookDataGridView.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn4.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn5.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn6.HeaderText = "Category";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Actual Quantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Actual Quantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Current Quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "Current Quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Shelf no";
            this.dataGridViewTextBoxColumn10.HeaderText = "Shelf no";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Date Added";
            this.dataGridViewTextBoxColumn11.HeaderText = "Date Added";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(360, 433);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 55;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Form2_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 490);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_shelf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_available);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_isbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_publisher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form2_Books";
            this.Text = "Form2_Books";
            this.Load += new System.EventHandler(this.Form2_Books_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_shelf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_available;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label9;
        private LBMSDataSet lBMSDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LBMSDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LBMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button_update;
    }
}

