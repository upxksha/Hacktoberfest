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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDB_Connection"].ToString());

        private void fetchTheStudentData()
        {
            if (StuidTB.Text == "")
            {
                MessageBox.Show("Please Enter a Student ID ");
            }
            else
            {
                conn.Open();

                int studentID = int.Parse(StuidTB.Text);

                string query = "SELECT * FROM StudentsTbl WHERE student_id='" + studentID + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    label14.Text = dr["student_name"].ToString();
                    label3.Text = dr["gender"].ToString();
                    label12.Text = dr["student_scl"].ToString();
                    label6.Text = dr["tele_no"].ToString();
                    label11.Text = dr["stream"].ToString();
                    label9.Text = dr["grade"].ToString();
                }

                conn.Close();
            }
        }


        private void Progress_Load(object sender, EventArgs e)
        {

        }

        private void StuidTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchTheStudentData();
            showdata();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Welcome wlc = new Welcome();
            this.Close();
            wlc.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void showdata()
        {
            if (StuidTB.Text != "")
            {
                conn.Open();

                int studentID = int.Parse(StuidTB.Text);

                string query = "SELECT * FROM PapersTbl WHERE student_id='" + studentID + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    int num1 = Convert.ToInt32(dr["paper1"]);
                    int num2 = Convert.ToInt32(dr["paper2"]);
                    int num3 = Convert.ToInt32(dr["paper3"]);
                    int num4 = Convert.ToInt32(dr["paper4"]);
                    int num5 = Convert.ToInt32(dr["paper5"]);
                    int num6 = Convert.ToInt32(dr["paper6"]);
                    int num7 = Convert.ToInt32(dr["paper7"]);
                    int num8 = Convert.ToInt32(dr["paper8"]);
                    int num9 = Convert.ToInt32(dr["paper9"]);
                    int num10 = Convert.ToInt32(dr["paper10"]);
                    int num11 = Convert.ToInt32(dr["paper11"]);
                    int num12 = Convert.ToInt32(dr["paper12"]);

                    int avg = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12) / 12;

                    label35.Text = avg.ToString();




                    {

                        if (num1 >= 75 && num1 <= 100)
                        {
                            label34.Text = "A";
                        }
                        else if (num1 >= 65 && num1 < 75)
                        {
                            label34.Text = "B";
                        }
                        else if (num1 >= 45 && num1 < 65)
                        {
                            label34.Text = "C";

                        }
                        else if (num1 >= 35 && num1 < 45)
                        {
                            label34.Text = "S";
                        }
                        else if (num1 >= 0 && num1 < 35)
                        {
                            label34.Text = "F";
                        }
                    }



                    {


                        if (num2 >= 75 && num2 <= 100)
                        {
                            label33.Text = "A";
                        }
                        else if (num2 >= 65 && num2 < 75)
                        {
                            label33.Text = "B";
                        }
                        else if (num2 >= 45 && num2 < 65)
                        {
                            label33.Text = "C";

                        }
                        else if (num2 >= 35 && num2 < 45)
                        {
                            label33.Text = "S";
                        }
                        else if (num2 >= 0 && num2 < 35)
                        {
                            label33.Text = "F";
                        }


                    }

                    {


                        if (num3 >= 75 && num3 <= 100)
                        {
                            label32.Text = "A";
                        }
                        else if (num3 >= 65 && num3 < 75)
                        {
                            label32.Text = "B";
                        }
                        else if (num3 >= 45 && num3 < 65)
                        {
                            label32.Text = "C";

                        }
                        else if (num3 >= 35 && num3 < 45)
                        {
                            label32.Text = "S";
                        }
                        else if (num3 >= 0 && num3 < 35)
                        {
                            label32.Text = "F";
                        }


                    }

                    {


                        if (num4 >= 75 && num4 <= 100)
                        {
                            label31.Text = "A";
                        }
                        else if (num4 >= 65 && num4 < 75)
                        {
                            label31.Text = "B";
                        }
                        else if (num4 >= 45 && num4 < 65)
                        {
                            label31.Text = "C";

                        }
                        else if (num4 >= 35 && num4 < 45)
                        {
                            label31.Text = "S";
                        }
                        else if (num4 >= 0 && num4 < 35)
                        {
                            label31.Text = "F";
                        }


                    }

                    {


                        if (num5 >= 75 && num5 <= 100)
                        {
                            label30.Text = "A";
                        }
                        else if (num5 >= 65 && num5 < 75)
                        {
                            label30.Text = "B";
                        }
                        else if (num5 >= 45 && num5 < 65)
                        {
                            label30.Text = "C";

                        }
                        else if (num5 >= 35 && num5 < 45)
                        {
                            label30.Text = "S";
                        }
                        else if (num5 >= 0 && num5 < 35)
                        {
                            label30.Text = "F";
                        }


                    }

                    {


                        if (num6 >= 75 && num6 <= 100)
                        {
                            label25.Text = "A";
                        }
                        else if (num6 >= 65 && num6 < 75)
                        {
                            label25.Text = "B";
                        }
                        else if (num6 >= 45 && num6 < 65)
                        {
                            label25.Text = "C";

                        }
                        else if (num6 >= 35 && num6 < 45)
                        {
                            label25.Text = "S";
                        }
                        else if (num6 >= 0 && num6 < 35)
                        {
                            label25.Text = "F";
                        }


                    }
                    {


                        if (num7 >= 75 && num7 <= 100)
                        {
                            label26.Text = "A";
                        }
                        else if (num7 >= 65 && num7 < 75)
                        {
                            label26.Text = "B";
                        }
                        else if (num7 >= 45 && num7 < 65)
                        {
                            label26.Text = "C";

                        }
                        else if (num7 >= 35 && num7 < 45)
                        {
                            label26.Text = "S";
                        }
                        else if (num7 >= 0 && num7 < 35)
                        {
                            label26.Text = "F";
                        }


                    }

                    {


                        if (num8 >= 75 && num8 <= 100)
                        {
                            label27.Text = "A";
                        }
                        else if (num8 >= 65 && num8 < 75)
                        {
                            label27.Text = "B";
                        }
                        else if (num8 >= 45 && num8 < 65)
                        {
                            label27.Text = "C";

                        }
                        else if (num8 >= 35 && num8 < 45)
                        {
                            label27.Text = "S";
                        }
                        else if (num8 >= 0 && num8 < 35)
                        {
                            label27.Text = "F";
                        }


                    }
                    {


                        if (num9 >= 75 && num9 <= 100)
                        {
                            label28.Text = "A";
                        }
                        else if (num9 >= 65 && num9 < 75)
                        {
                            label28.Text = "B";
                        }
                        else if (num9 >= 45 && num9 < 65)
                        {
                            label28.Text = "C";

                        }
                        else if (num9 >= 35 && num9 < 45)
                        {
                            label28.Text = "S";
                        }
                        else if (num9 >= 0 && num9 < 35)
                        {
                            label28.Text = "F";
                        }


                    }

                    {


                        if (num10 >= 75 && num10 <= 100)
                        {
                            label29.Text = "A";
                        }
                        else if (num10 >= 65 && num10 < 75)
                        {
                            label29.Text = "B";
                        }
                        else if (num10 >= 45 && num10 < 65)
                        {
                            label29.Text = "C";

                        }
                        else if (num10 >= 35 && num10 < 45)
                        {
                            label29.Text = "S";
                        }
                        else if (num10 >= 0 && num10 < 35)
                        {
                            label29.Text = "F";
                        }


                    }

                    {


                        if (num11 >= 75 && num11 <= 100)
                        {
                            label39.Text = "A";
                        }
                        else if (num11 >= 65 && num11 < 75)
                        {
                            label39.Text = "B";
                        }
                        else if (num11 >= 45 && num11 < 65)
                        {
                            label39.Text = "C";

                        }
                        else if (num11 >= 35 && num11 < 45)
                        {
                            label39.Text = "S";
                        }
                        else if (num11 >= 0 && num11 < 35)
                        {
                            label39.Text = "F";
                        }


                    }


                    {


                        if (num12 >= 75 && num12 <= 100)
                        {
                            label40.Text = "A";
                        }
                        else if (num12 >= 65 && num12 < 75)
                        {
                            label40.Text = "B";
                        }
                        else if (num12 >= 45 && num12 < 65)
                        {
                            label40.Text = "C";

                        }
                        else if (num12 >= 35 && num12 < 45)
                        {
                            label40.Text = "S";
                        }
                        else if (num12 >= 0 && num12 < 35)
                        {
                            label40.Text = "F";
                        }


                    }


                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();


            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("__________Student Marks___________", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));

            e.Graphics.DrawString("Student Name: " + label14.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(80, 210));
            e.Graphics.DrawString("School Name : " + label12.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(80, 240));
            e.Graphics.DrawString("Telephone no: " + label16.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(80, 270));
            e.Graphics.DrawString("Stream : " + label11.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(80, 300));
            e.Graphics.DrawString("Grade: " + label9.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(80, 330));

            e.Graphics.DrawString("Paper1 : " + label34.Text + "\t\t\t Paper7 :" + label26.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Blue, new Point(80, 360));
            e.Graphics.DrawString("Paper2 : " + label33.Text + "\t\t\t Paper8 :" + label27.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Blue, new Point(80, 390));
            e.Graphics.DrawString("Paper3 : " + label32.Text + "\t\t\t Paper9 :" + label28.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Blue, new Point(80, 420));
            e.Graphics.DrawString("Paper4 : " + label31.Text + "\t \t\t Paper10 :" + label29.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Blue, new Point(80, 450));
            e.Graphics.DrawString("Paper5 : " + label30.Text + "\t\t\t Paper11 :" + label39.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Blue, new Point(80, 480));
            e.Graphics.DrawString("Paper6 : " + label25.Text + "\t\t\t Paper12 :" + label40.Text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Blue, new Point(80, 510));


            e.Graphics.DrawString("Average Mark : " + label35.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(80, 540));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {
            Welcome wlc = new Welcome();
            this.Close();
            wlc.Show();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label42_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Exit this Application ?",
                                    "Confirm Exit",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.YellowGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DodgerBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
