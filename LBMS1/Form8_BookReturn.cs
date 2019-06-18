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
    public partial class Form8_BookReturn : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=LBMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand cmd, mk;
        SqlCommand up;
        DataTable dt;
        int days, fine;
        string mark, bookID, chk, del, isd;

        public Form8_BookReturn()
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



        private void Form8_BookReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lBMSDataSet.Book_Return' table. You can move, or remove it, as needed.
            this.book_ReturnTableAdapter.Fill(this.lBMSDataSet.Book_Return);
            display_data();
            Member();
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            bookID = textBox_bid.Text;
            chk = comboBox_mid.Text;
            isd = dateTimePicker_idate.Text;
       
            try
            {
                string query = @"INSERT INTO Book_return(         [Member ID],            [Book ID],            [Issued Date],            [Return Date],                       Delay,                Fine )" +
                                "VALUES(                         '" + chk + "',        '" + bookID + "',        '" + isd + "',  '" + dateTimePicker_rdate.Text + "',      '" + days + "',       '" + fine + "'   ) ";
                cmd = new SqlCommand(query, conString);
                conString.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    comboBox_mid.Text = "<select>";                 
                    textBox_bid.Clear();
                    textBox_fine.Clear();
                    textBox_delay.Clear();
                }
                else
                {
                    MessageBox.Show("Data insert failed");
                }
                // increasing book quantity
                string update = (@" UPDATE Book 
                                    SET [Current Quantity] = ([Current Quantity] + 1 )
                                    Where [Book ID] like '" + bookID + "'  AND [Current Quantity] < [Actual Quantity] ");
                up = new SqlCommand(update, conString);
                conString.Open();
                up.ExecuteNonQuery();
                conString.Close();

                //  member marking
                string mark = (@"update Member
                                 Set chk = chk + 1
                                 Where [Member ID] = '" + chk + "' AND chk < 1 ");
                mk = new SqlCommand(mark, conString);
                conString.Open();
                mk.ExecuteNonQuery();
                conString.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Member();
            display_data();
        }


        public void display_data() //update concurrently
        {
            sda = new SqlDataAdapter(@"SELECT * FROM Book_Return", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            book_ReturnDataGridView.DataSource = dt;
        }
        
        public void Member()
            {
                try
                {
                    string query1 = "select DISTINCT ([Member ID]) from Member Where chk = 0 ";
                    if (conString.State == ConnectionState.Closed)
                    {
                        conString.Open();
                    }
                    SqlCommand cmd1 = new SqlCommand(query1, conString);
                    SqlDataReader DR1 = cmd1.ExecuteReader();
                    comboBox_mid.Items.Clear();
                    while (DR1.Read())
                    {
                        string id = DR1["Member ID"].ToString();
                        comboBox_mid.Items.Add(id);
                    }
                    DR1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conString.State == ConnectionState.Open)
                    {
                        conString.Close();
                    }
                }
            }

        private void comboBox_mid_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                string query1 = "select [Book ID], [Issued date], [Return date] from Book_Issue Where [Member ID]  like '" + comboBox_mid.Text + "'";
                if (conString.State == ConnectionState.Closed)
                {
                    conString.Open();
                }
                SqlCommand cmd2 = new SqlCommand(query1, conString);
                SqlDataReader DR2 = cmd2.ExecuteReader();                
                while (DR2.Read())
                {
                    string bid = DR2["Book ID"].ToString(); //
                    textBox_bid.Text = bid;                 // with var assigne

                    dateTimePicker_idate.Value = (DateTime)DR2["Issued date"];                                        
                }

                DateTime rd = dateTimePicker_rdate.Value.Date;
                DateTime id = dateTimePicker_idate.Value.Date;
                TimeSpan ts = rd - id;
                days = ts.Days;
                if (days <= 7)
                {
                    fine = days * 0;
                    days = 0;
                    textBox_delay.Text = days.ToString();
                    textBox_fine.Text = fine.ToString();
                }                    
                else
                {
                    days = days - 7;
                    fine = days * 7;
                    textBox_delay.Text = days.ToString();
                    textBox_fine.Text = fine.ToString();                  
                }
                
                

                DR2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conString.State == ConnectionState.Open)
                {
                    conString.Close();
                }
            }
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
