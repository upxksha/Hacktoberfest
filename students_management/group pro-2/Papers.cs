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
using System.Configuration;

namespace group_pro_2
{
    public partial class Papers : Form
    {
        public Papers()
        {
            InitializeComponent();
        }




        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDB_Connection"].ToString());

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void showTheDatabase()
        {
            conn.Open();

            string query = "SELECT * FROM PapersTbl";

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGV2.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (StuidTB.Text == "")
                {
                    MessageBox.Show("Please insert your student ID!");
                }
                else if (paper1TB.Text == "" || paper2TB.Text == "" || paper3TB.Text == "" || paper4TB.Text == "" || paper5TB.Text == "" || paper6TB.Text == "" || paper7TB.Text == "" || paper8TB.Text == "" || paper9TB.Text == "" || paper10TB.Text == "" || paper11TB.Text == "" || paper12TB.Text == "")
                {
                    MessageBox.Show("Please check and insert your markes again!");
                }

                else
                {
                    conn.Open();
                    int studentID = int.Parse(StuidTB.Text);

                    int paper1 = int.Parse(paper1TB.Text);
                    int paper2 = int.Parse(paper2TB.Text);
                    int paper3 = int.Parse(paper3TB.Text);
                    int paper4 = int.Parse(paper4TB.Text);
                    int paper5 = int.Parse(paper5TB.Text);
                    int paper6 = int.Parse(paper6TB.Text);
                    int paper7 = int.Parse(paper7TB.Text);
                    int paper8 = int.Parse(paper8TB.Text);
                    int paper9 = int.Parse(paper9TB.Text);
                    int paper10 = int.Parse(paper10TB.Text);
                    int paper11 = int.Parse(paper11TB.Text);
                    int paper12 = int.Parse(paper12TB.Text);


                    if (paper1 > 100 || paper2 > 100 || paper3 > 100 || paper4 > 100 || paper5 > 100 || paper6 > 100 || paper7 > 100 || paper8 > 100 || paper9 > 100 || paper10 > 100 || paper11 > 100 || paper12 > 100)
                    {
                        MessageBox.Show("Paper Marks are given out of 100!");
                    }

                    else
                    {

                        string query = "INSERT INTO PapersTbl VALUES ('" + studentID + "','" + paper1 + "','" + paper2 + "','" + paper3 + "','" + paper4 + "','" + paper5 + "','" + paper6 + "','" + paper7 + "','" + paper8 + "','" + paper9 + "','" + paper10 + "','" + paper11 + "','" + paper12 + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Marks inserted successfully!");
                       

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generated! Details: " + ex.Message);
            }
            finally
            {
                conn.Close();

                showTheDatabase();
            }



        }


        private void Papers_Load(object sender, EventArgs e)
        {
            showTheDatabase();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome wel = new Welcome();
            wel.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (StuidTB.Text == "")
                {
                    MessageBox.Show("Please fill your student ID!");
                }
                else
                {
                    conn.Open();

                    int studentID = int.Parse(StuidTB.Text);

                    int marks1 = int.Parse(paper1TB.Text);
                    int marks2 = int.Parse(paper2TB.Text);
                    int marks3 = int.Parse(paper3TB.Text);
                    int marks4 = int.Parse(paper4TB.Text);
                    int marks5 = int.Parse(paper5TB.Text);
                    int marks6 = int.Parse(paper6TB.Text);
                    int marks7 = int.Parse(paper7TB.Text);
                    int marks8 = int.Parse(paper8TB.Text);
                    int marks9 = int.Parse(paper9TB.Text);
                    int marks10 = int.Parse(paper10TB.Text);
                    int marks11 = int.Parse(paper11TB.Text);
                    int marks12 = int.Parse(paper12TB.Text);



                    if (marks1 > 100 || marks2 > 100 || marks3 > 100 || marks4 > 100 || marks5 > 100 || marks6 > 100 || marks7 > 100 || marks8 > 100 || marks9 > 100 || marks10 > 100 || marks11 > 100 || marks12 > 100)
                    {
                        MessageBox.Show("Paper Marks are given out of 100!");
                    }

                    else
                    {
                        string query = "UPDATE PapersTbl SET Paper1='" + marks1 + "', Paper2='" + marks2 + "', Paper3='" + marks3 + "',Paper4='" + marks4 + "', Paper5='" + marks5 + "', Paper6='" + marks6 + "', Paper7='" + marks7 + "',Paper8='" + marks8 + "', Paper9='" + marks9 + "', Paper10='" + marks10 + "' , Paper11='" + marks11 + "', Paper12='" + marks12 + "'WHERE student_id='" + studentID + "' ";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Marks updated successfully!");

                        conn.Close();
                        showTheDatabase();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generated! Details: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (StuidTB.Text == "")
                {
                    MessageBox.Show("Select your student ID to delete!");
                }
                else
                {
                    conn.Open();

                    int studentID = int.Parse(StuidTB.Text);

                    string query = "DELETE FROM PapersTbl WHERE student_id='" + studentID + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Marks deleted successfully!");

                    conn.Close();
                    showTheDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generated! Details: " + ex.Message);
            }
        }
            private void StuidTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StuidTB.Text = dataGV2.Rows[e.RowIndex].Cells[0].Value.ToString();
            paper1TB.Text = dataGV2.Rows[e.RowIndex].Cells[1].Value.ToString();
            paper2TB.Text = dataGV2.Rows[e.RowIndex].Cells[2].Value.ToString();
            paper3TB.Text = dataGV2.Rows[e.RowIndex].Cells[3].Value.ToString();
            paper4TB.Text = dataGV2.Rows[e.RowIndex].Cells[4].Value.ToString();
            paper5TB.Text = dataGV2.Rows[e.RowIndex].Cells[5].Value.ToString();
            paper6TB.Text = dataGV2.Rows[e.RowIndex].Cells[6].Value.ToString();
            paper7TB.Text = dataGV2.Rows[e.RowIndex].Cells[7].Value.ToString();
            paper8TB.Text = dataGV2.Rows[e.RowIndex].Cells[8].Value.ToString();
            paper9TB.Text = dataGV2.Rows[e.RowIndex].Cells[9].Value.ToString();
            paper10TB.Text = dataGV2.Rows[e.RowIndex].Cells[10].Value.ToString();
            paper11TB.Text = dataGV2.Rows[e.RowIndex].Cells[11].Value.ToString();
            paper12TB.Text = dataGV2.Rows[e.RowIndex].Cells[12].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StuidTB.Clear();
            paper1TB.Clear();
            paper2TB.Clear();
            paper3TB.Clear();
            paper4TB.Clear();
            paper5TB.Clear();
            paper6TB.Clear();
            paper7TB.Clear();
            paper8TB.Clear();
            paper9TB.Clear();
            paper10TB.Clear();
            paper11TB.Clear();
            paper12TB.Clear();

        }

        private void label15_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Exit this Application ?",
                                    "Confirm Exit",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Welcome wlc = new Welcome();
            this.Close();
            wlc.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.YellowGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gray;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }
    }
    
}
