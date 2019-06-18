namespace LBMS1
{
    partial class Form6_membership
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
            this.lBMSDataSet = new LBMS1.LBMSDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new LBMS1.LBMSDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new LBMS1.LBMSDataSetTableAdapters.TableAdapterManager();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_dept = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_mid = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_tea = new System.Windows.Forms.RadioButton();
            this.radioButton_em = new System.Windows.Forms.RadioButton();
            this.radioButton_std = new System.Windows.Forms.RadioButton();
            this.button_update = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(1057, 24);
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
            // lBMSDataSet
            // 
            this.lBMSDataSet.DataSetName = "LBMSDataSet";
            this.lBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.lBMSDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_IssueTableAdapter = null;
            this.tableAdapterManager.Book_ReturnTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.UpdateOrder = LBMS1.LBMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.memberDataGridView.DataSource = this.memberBindingSource;
            this.memberDataGridView.Location = new System.Drawing.Point(347, 50);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.Size = new System.Drawing.Size(698, 345);
            this.memberDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Membership Type";
            this.dataGridViewTextBoxColumn1.HeaderText = "Membership Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Member ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Member ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn4.HeaderText = "Department";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Chk";
            this.dataGridViewTextBoxColumn8.HeaderText = "Chk";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Department";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(115, 137);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(153, 20);
            this.textBox_name.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Member Name";
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(115, 250);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(153, 20);
            this.textBox_contact.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Member ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_dept
            // 
            this.comboBox_dept.AllowDrop = true;
            this.comboBox_dept.FormattingEnabled = true;
            this.comboBox_dept.Items.AddRange(new object[] {
            "<select>",
            "CSE",
            "ECE",
            "BBA",
            "Admin",
            "Librarian",
            "Others"});
            this.comboBox_dept.Location = new System.Drawing.Point(115, 173);
            this.comboBox_dept.Name = "comboBox_dept";
            this.comboBox_dept.Size = new System.Drawing.Size(153, 21);
            this.comboBox_dept.TabIndex = 24;
            this.comboBox_dept.Text = "<select>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Address";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(115, 291);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(153, 20);
            this.textBox_email.TabIndex = 26;
            // 
            // textBox_mid
            // 
            this.textBox_mid.ForeColor = System.Drawing.Color.Navy;
            this.textBox_mid.HideSelection = false;
            this.textBox_mid.Location = new System.Drawing.Point(118, 98);
            this.textBox_mid.Name = "textBox_mid";
            this.textBox_mid.Size = new System.Drawing.Size(84, 20);
            this.textBox_mid.TabIndex = 26;
            this.textBox_mid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(115, 211);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(153, 20);
            this.textBox_address.TabIndex = 26;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(127, 349);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 27;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_tea);
            this.groupBox1.Controls.Add(this.radioButton_em);
            this.groupBox1.Controls.Add(this.radioButton_std);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.textBox_address);
            this.groupBox1.Controls.Add(this.textBox_mid);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_dept);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_contact);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 391);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Membership";
            // 
            // radioButton_tea
            // 
            this.radioButton_tea.AutoSize = true;
            this.radioButton_tea.Location = new System.Drawing.Point(118, 49);
            this.radioButton_tea.Name = "radioButton_tea";
            this.radioButton_tea.Size = new System.Drawing.Size(65, 17);
            this.radioButton_tea.TabIndex = 29;
            this.radioButton_tea.TabStop = true;
            this.radioButton_tea.Text = "Teacher";
            this.radioButton_tea.UseVisualStyleBackColor = true;
            this.radioButton_tea.CheckedChanged += new System.EventHandler(this.radioButton_tea_CheckedChanged);
            // 
            // radioButton_em
            // 
            this.radioButton_em.AutoSize = true;
            this.radioButton_em.Location = new System.Drawing.Point(223, 49);
            this.radioButton_em.Name = "radioButton_em";
            this.radioButton_em.Size = new System.Drawing.Size(71, 17);
            this.radioButton_em.TabIndex = 29;
            this.radioButton_em.TabStop = true;
            this.radioButton_em.Text = "Employee";
            this.radioButton_em.UseVisualStyleBackColor = true;
            this.radioButton_em.CheckedChanged += new System.EventHandler(this.radioButton_em_CheckedChanged);
            // 
            // radioButton_std
            // 
            this.radioButton_std.AutoSize = true;
            this.radioButton_std.Location = new System.Drawing.Point(20, 49);
            this.radioButton_std.Name = "radioButton_std";
            this.radioButton_std.Size = new System.Drawing.Size(62, 17);
            this.radioButton_std.TabIndex = 28;
            this.radioButton_std.TabStop = true;
            this.radioButton_std.Text = "Student";
            this.radioButton_std.UseVisualStyleBackColor = true;
            this.radioButton_std.CheckedChanged += new System.EventHandler(this.radioButton_std_CheckedChanged);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(588, 436);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 30;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Form6_membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 490);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form6_membership";
            this.Text = "Form6_membership";
            this.Load += new System.EventHandler(this.Form6_membership_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private LBMSDataSet lBMSDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private LBMSDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private LBMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_dept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_mid;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_std;
        private System.Windows.Forms.RadioButton radioButton_tea;
        private System.Windows.Forms.RadioButton radioButton_em;
        private System.Windows.Forms.Button button_update;
    }
}

