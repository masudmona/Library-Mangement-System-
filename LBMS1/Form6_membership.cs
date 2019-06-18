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
using System.Collections;

namespace LBMS1
{
    public partial class Form6_membership : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=LBMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand cmd;
        SqlCommand up;
        DataTable dt;
        string type, id, mid;

        public Form6_membership()
        {
            InitializeComponent();
            textBox_mid.ReadOnly = true;
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


        private void Form6_membership_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lBMSDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.lBMSDataSet.Member);
            display_data();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int chceck = 1;
            try
            {
                string query = @"INSERT INTO Member( [Membership Type],           [Member ID],             Name,                       Department,                     Address,                       Contact,                            Email,                  Chk )" +
                                "VALUES(                 '" + type + "',         '" + mid + "', '" + textBox_name.Text + "', '" + comboBox_dept.Text + "', '" + textBox_address.Text + "',  '" + textBox_contact.Text + "',  '" + textBox_email.Text + "', '" + chceck + "'   ) ";
                cmd = new SqlCommand(query, conString);
                conString.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    textBox_name.Clear();                    
                    radioButton_tea.Checked = false;
                    radioButton_std.Checked = false;
                    radioButton_em.Checked = false;
                    textBox_mid.Text = String.Empty;
                    comboBox_dept.SelectedIndex = 0;
                    textBox_address.Clear();
                    textBox_contact.Clear();
                    textBox_email.Clear();

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
            sda = new SqlDataAdapter(@"SELECT * FROM Member ORDER BY [Member ID]", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            memberDataGridView.DataSource = dt;
        }

        private void radioButton_std_CheckedChanged(object sender, EventArgs e)
        {
            textBox_mid.Clear();
            type = "Student";
            id = "S00";
            takeID(type,id);
        }

        private void radioButton_tea_CheckedChanged(object sender, EventArgs e)
        {
            textBox_mid.Clear();
            type = "Taecher";
            id = "T00";
            takeID(type,id);            
        }

        private void radioButton_em_CheckedChanged(object sender, EventArgs e)
        {
            textBox_mid.Clear();
            type = "Employee";
            id = "E00";
            takeID(type,id);          
        }

        public void takeID( string t, string x)
        {
            textBox_mid.Clear();            
            conString.Open();
            cmd = new SqlCommand("select count([Membership Type]) from Member where [Membership Type] like '" + t + "' ", conString);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conString.Close();
            i++;
            textBox_mid.Text = x + i.ToString();
            mid = textBox_mid.Text;           
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {                
                scb = new SqlCommandBuilder(sda);
                int a = sda.Update(dt);
                if (a < 1)
                    MessageBox.Show("No Update is found!");
                else
                    MessageBox.Show("Update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
