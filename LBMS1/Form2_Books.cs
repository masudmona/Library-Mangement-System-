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
    public partial class Form2_Books : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=LBMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand cmd;
        DataTable dt;
        public Form2_Books()
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

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO Book(          Title,                      Author,                        Publisher,                       ISBN,                         Category,                    [Actual Quantity],             [Current Quantity],                 [Shelf no],                          [Date Added])" +
                                "VALUES(        '" + textBox_title.Text + "', '" + textBox_author.Text + "', '" + textBox_publisher.Text + "', '" + textBox_isbn.Text + "','" + textBox_category.Text + "', " + textBox_available.Text + ",  '"+ textBox_available.Text +"' ,  '" + textBox_shelf.Text + "',    '" + dateTimePicker_date.Text + "'  ) ";
                cmd = new SqlCommand(query, conString);
                conString.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    textBox_title.Clear();
                    textBox_author.Clear();
                    textBox_publisher.Clear();
                    textBox_isbn.Clear();
                    textBox_category.Clear();
                    textBox_available.Clear();
                    textBox_quantity.Clear();
                    textBox_shelf.Clear();
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
            sda = new SqlDataAdapter(@"SELECT * FROM Book", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            bookDataGridView.DataSource = dt;
            //textBox_search.Clear();
            //comboBox_search.SelectedIndex = -1;
        }

        private void textBox_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lBMSDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.lBMSDataSet.Book);
            //TODO: This line of code loads data into the 'lBMSDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.lBMSDataSet.Book);
            display_data();
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
