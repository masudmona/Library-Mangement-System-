using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LBMS1
{
    public partial class Form3_account : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=LBMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand cmd;
        DataTable dt;
        public Form3_account()
        {
            InitializeComponent();
        }

        private void bookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2_Books().Show();
            this.Hide();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3_account().Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form0_login().Show();
            this.Hide();
        }

        private void loginInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4_info().Show();
            this.Hide();
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1_dashboard().Show();
            this.Hide();
        }

        private void membershipToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form6_membership().Show();
            this.Hide();
        }

        private void bookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7_BookIssue().Show();
            this.Hide();
        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form8_BookReturn().Show();
            this.Hide();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form9_backup().Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form10_users().Show();
            this.Hide();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form11_credits().Show();
            this.Hide();
        }

        private void studentMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Form12_std().Show();
            this.Hide();
        }

        private void teacherMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form13_teacher().Show();
            this.Hide();
        }

        private void employeeMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form14_emp().Show();
            this.Hide();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lBMSDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.lBMSDataSet.Admin);
            display_data();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO Admin(   [User id],                    Username,                    Password,                     Email)" +
                                "VALUES(        '" + textBox_id.Text + "', '" + textBox_name.Text + "', '" + textBox_pw.Text + "', '" + textBox_mail.Text + "' ) ";
                cmd = new SqlCommand(query, conString);
                conString.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    textBox_id.Clear();
                    textBox_name.Clear();
                    textBox_mail.Clear();
                    textBox_pw.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Data insert failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            display_data();
        }

        public void display_data() //update concurrently
        {
            sda = new SqlDataAdapter(@"SELECT * FROM Admin", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            adminDataGridView.DataSource = dt;
        }
    }
}
