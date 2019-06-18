namespace LBMS1
{
    partial class Form3_account
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
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.lBMSDataSet = new LBMS1.LBMSDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new LBMS1.LBMSDataSetTableAdapters.AdminTableAdapter();
            this.tableAdapterManager = new LBMS1.LBMSDataSetTableAdapters.TableAdapterManager();
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
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
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(77, 178);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(100, 20);
            this.textBox_mail.TabIndex = 11;
            this.textBox_mail.TextChanged += new System.EventHandler(this.textBox_mail_TextChanged);
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(79, 134);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(100, 20);
            this.textBox_pw.TabIndex = 12;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(85, 70);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 13;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(85, 107);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 14;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(85, 220);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 15;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // lBMSDataSet
            // 
            this.lBMSDataSet.DataSetName = "LBMSDataSet";
            this.lBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.lBMSDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = this.adminTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_IssueTableAdapter = null;
            this.tableAdapterManager.Book_ReturnTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LBMS1.LBMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.AutoGenerateColumns = false;
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.adminDataGridView.DataSource = this.adminBindingSource;
            this.adminDataGridView.Location = new System.Drawing.Point(230, 70);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.Size = new System.Drawing.Size(508, 206);
            this.adminDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "User id";
            this.dataGridViewTextBoxColumn1.HeaderText = "User id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form3_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 490);
            this.Controls.Add(this.adminDataGridView);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form3_account";
            this.Text = "Form3_account";
            this.Load += new System.EventHandler(this.Form3_account_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_save;
        private LBMSDataSet lBMSDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private LBMSDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private LBMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

