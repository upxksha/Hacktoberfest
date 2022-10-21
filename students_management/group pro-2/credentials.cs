using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace group_pro_2
{
    public partial class credentials : Form
    {
        public credentials()
        {
            InitializeComponent();
            TBnewPword.PasswordChar = '•';
            TBconfirmPword.PasswordChar = '•';
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void credentials_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Welcome objwelcome = new Welcome();
            this.Close();
            objwelcome.Show();
        }

        private void lblcurrentuname_Click(object sender, EventArgs e)
        {

        }

        private void saveUname_Click(object sender, EventArgs e)
        {
            if (TBcurrentUname.Text == "" || TBnewUname.Text == "" || TBconfirmUname.Text == "")
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                int username_flag = 0;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDB_Connection"].ToString());
                try
                {
                    con.Open();
                    SqlDataAdapter uname = new SqlDataAdapter("Select Count (*) From Login Where username='" + TBcurrentUname.Text + "'", con);
                    DataTable dt = new DataTable();
                    uname.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        username_flag = 1;
                    }

                    else
                    {
                        MessageBox.Show("Current Username is Incorrect");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Databse Connection Error" + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
                
                if(username_flag == 1)
                {
                    if(TBnewUname.Text==TBconfirmUname.Text)
                    {
                        string updateuname = "UPDATE Login SET username = '" + TBnewUname.Text + "' ";
                        SqlCommand cmd = new SqlCommand(updateuname,con);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Username Changed Successfully");
                            TBnewUname.Text = "";
                            TBcurrentUname.Text = "";
                            TBconfirmUname.Text = "";
                        }
                        catch(SqlException se)
                        {
                            MessageBox.Show("Database related Error "+se);
                        }
                        finally
                        { 
                            con.Close();
                        }



                    }
                    else
                    {
                        MessageBox.Show("Enterd Usernames are not Mstching !!!");
                    }

                    

                }

            }
            
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Welcome objwelcome = new Welcome();
            this.Close();
            objwelcome.Show();
        }

        private void btnClearUname_Click(object sender, EventArgs e)
        {
            TBnewUname.Clear();
            TBcurrentUname.Clear();
            TBconfirmUname.Clear();
        }

        private void btnClearPword_Click(object sender, EventArgs e)
        {
            TBnewPword.Clear();
            TBcurrentPword.Clear();
            TBconfirmPword.Clear();

        }

        private void savePword_Click(object sender, EventArgs e)
        {
            if (TBcurrentPword.Text == "" || TBnewPword.Text == "" || TBconfirmPword.Text == "")
            {
                MessageBox.Show("Missing Information !!!");

            }
            else
            {
                int password_flag = 0;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDB_Connection"].ToString());
                try
                {
                    con.Open();
                    SqlDataAdapter pword = new SqlDataAdapter("Select Count (*) From Login Where password='" + TBcurrentPword.Text + "'", con);
                    DataTable dt = new DataTable();
                    pword.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        password_flag = 1;
                    }

                    else
                    {
                        MessageBox.Show("Current Password is Incorrect");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Databse Connection Error" + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                if (password_flag == 1)
                {
                    if (TBnewPword.Text == TBconfirmPword.Text)
                    {
                        string updatepword = "UPDATE Login SET password = '" + TBnewPword.Text + "' ";
                        SqlCommand cmd = new SqlCommand(updatepword, con);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password Changed Successfully");
                            TBnewPword.Text = "";
                            TBcurrentPword.Text = "";
                            TBconfirmPword.Text = "";
                        }
                        catch (SqlException se)
                        {
                            MessageBox.Show("Database related Error " + se);
                        }
                        finally
                        {
                            con.Close();
                        }



                    }
                    else
                    {
                        MessageBox.Show("Enterd Passwords are not Mstching !!!");
                    }



                }

            }
        }
    }
}
