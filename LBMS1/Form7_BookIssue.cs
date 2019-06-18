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
    public partial class Form7_BookIssue : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=LBMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand cmd;
        SqlCommand up, mk;
        DataTable dt;
        DataSet ds = new DataSet();
        string book, chk;

        
        public Form7_BookIssue()
        {
            InitializeComponent();
            addItem();
            //comboBox_mid.Enabled = false;
            comboBox_cat.Enabled = false;
            comboBox_book.Enabled = false;
            textBox_bid.ReadOnly = false;
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


        private void Form7_BookIssue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lBMSDataSet.Book_Issue' table. You can move, or remove it, as needed.
            this.book_IssueTableAdapter.Fill(this.lBMSDataSet.Book_Issue);
            readID();
            addItem();
            display_data();
            textBox_redate.Enabled = false;                        
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            book = comboBox_book.Text;
            chk = comboBox_mid.Text;            
            try
            {
                SqlCommand ck = new SqlCommand("select [Member ID] from Member where [Member ID] like '" + chk + "'AND chk = 0 ", conString);
                sda = new SqlDataAdapter(ck);
                sda.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("The Member id '" + chk + "' is alredy Holding a Book!");
                    ds.Clear();
                }
                else
                {
                      string query = @"INSERT INTO Book_Issue(         [Member ID],                   Category,                      Title,                      [Book ID],                     [Issued Date],                     [Return Date] )" +
                                "VALUES(                        '" + chk + "',         '" + comboBox_cat.Text + "', '" + comboBox_book.Text + "', '" + textBox_bid.Text + "',  '" + dateTimePicker_idate.Text + "',  '" + textBox_redate.Text + "'   ) ";
                cmd = new SqlCommand(query, conString);
                conString.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    textBox_redate.Text = "";
                    comboBox_mid.Text = "<select>";
                    comboBox_book.Text = "<select>";
                    comboBox_cat.Text = "<select>";
                    textBox_bid.Clear();
                    textBox_redate.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Data insert failed");
                }
                }
                

                // decreasing book quantity
                string update = (@" UPDATE Book 
                                    SET [Current Quantity] = ([Current Quantity]-1 )
                                    Where Title like '"+book+"'  AND [Current Quantity] > 0 ");
                up = new SqlCommand(update, conString);
                conString.Open();
                up.ExecuteNonQuery();
                conString.Close();


                string mark = (@"update Member
                                 Set chk = chk - 1
                                 Where [Member ID] = '" + chk + "' AND chk > 0 ");
                mk = new SqlCommand(mark, conString);
                conString.Open();
                mk.ExecuteNonQuery();
                conString.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            display_data();
        }

        public void display_data() //update concurrently
        {
            sda = new SqlDataAdapter(@"SELECT * FROM Book_Issue ORDER BY [Issued Date] ", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            book_IssueDataGridView.DataSource = dt;
        }

        public void readID()
        {
            try
            {
                string query3 = "select [Member ID] from Member ";
                if (conString.State == ConnectionState.Closed)
                {
                    conString.Open();
                }
                SqlCommand cmd0 = new SqlCommand(query3, conString);
                SqlDataReader DR0 = cmd0.ExecuteReader();
                comboBox_mid.Items.Clear();
                while (DR0.Read())
                {
                    string id = DR0["Member ID"].ToString();
                    comboBox_mid.Items.Add(id);
                }
                DR0.Close();
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


        public void addItem()
        {
            try
            {
                string query3 = "select DISTINCT (Category) from Book ";
                if (conString.State == ConnectionState.Closed)
                {
                    conString.Open();
                }
                SqlCommand cmd5 = new SqlCommand(query3, conString);
                SqlDataReader DR5 = cmd5.ExecuteReader();
                comboBox_cat.Items.Clear();
                while (DR5.Read())
                {
                    string cat = DR5["Category"].ToString();
                    comboBox_cat.Items.Add(cat);
                }
                DR5.Close();
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

        private void comboBox_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_book.Enabled = true;
            try
            {
                string query4 = "select  DISTINCT (Title) from Book where Category like '" + comboBox_cat.Text + "%' AND [Current Quantity]>0 ";
                if (conString.State == ConnectionState.Closed)
                {
                    conString.Open();
                }
                SqlCommand cmd0 = new SqlCommand(query4, conString);
                SqlDataReader DR6 = cmd0.ExecuteReader();
                comboBox_book.Items.Clear();
                while (DR6.Read())
                {
                    string book = DR6["Title"].ToString();
                    comboBox_book.Items.Add(book);
                }
                conString.Close();
                DR6.Close();
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

        private void comboBox_book_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                string query6 = "select DISTINCT [Book ID] from Book where Title like '" + comboBox_book.Text + "%'";
                if (conString.State == ConnectionState.Closed)
                {
                    conString.Open();
                }
                SqlCommand cmd0 = new SqlCommand(query6, conString);
                SqlDataReader DR7 = cmd0.ExecuteReader();

                while (DR7.Read())
                {
                    textBox_bid.Text = DR7["Book ID"].ToString();
                }
                conString.Close();
                DR7.Close();
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

        private void dateTimePicker_idate_ValueChanged(object sender, EventArgs e)
        {
            returnDate();
        }
        public void returnDate()
        {
            textBox_redate.Enabled = true;
            DateTime current = dateTimePicker_idate.Value.AddDays(7);
            textBox_redate.Text = current.ToString("dd-MMM-yyyy");
        }

        private void comboBox_mid_SelectedIndexChanged(object sender, EventArgs e)
        {
            returnDate();
            comboBox_cat.Enabled = true;
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
            catch
            {
                MessageBox.Show("Failed !!!");
            }
        }

    }
}
            //try
            //{
                //SqlCommand ck = new SqlCommand("select [Member ID] from Book_Issue where [Member ID] like '" + chk + "' ", conString);
                //sda = new SqlDataAdapter(ck);
                //sda.Fill(ds);
                //int i = ds.Tables[0].Rows.Count;
                //if (i > 0)
                //{
                //    MessageBox.Show("this id '" + chk + "' is alredy exist");
                //    ds.Clear();
                //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}