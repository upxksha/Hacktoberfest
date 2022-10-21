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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDB_Connection"].ToString());
        private void button1_Click(object sender, EventArgs e)
        {
            if (StuidTB.Text == "" || StunameTB.Text == "" || StusclTB.Text == "" || StuteleTB.Text == "") 
            { 

            MessageBox.Show("Missing Details"); }

            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into StudentsTbl values(" + StuidTB.Text + ", '" + StunameTB.Text + "','" + StusclTB.Text + "'," + StuteleTB.Text + ",'" + StugenCB.SelectedItem.ToString() + "', '" + StugradCB.SelectedItem.ToString() + "','" + StujoinDT.Value.Date + "','" + StustreCB.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student details Successfully Recorded");
                    Con.Close();
                    pop();
                    
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void pop()
        {
            Con.Open();
            string query = "select * from StudentsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGV1.DataSource = ds.Tables[0];

            Con.Close();

        }
        private void Students_Load(object sender, EventArgs e)
        {
            pop();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Exit this Application ?",
                                    "Confirm Exit",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void StugenCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(StuidTB.Text=="")
            {
                MessageBox.Show("Enter The Sudent ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from StudentsTbl where student_id=" + StuidTB.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Students data is Deteted Sucessfully");
                    
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                    pop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StuidTB.Text == "" || StunameTB.Text == "" || StusclTB.Text == "" || StuteleTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update StudentsTbl set student_name= '" + StunameTB.Text + "',student_scl='" + StusclTB.Text + "',tele_no= " + StuteleTB.Text + ",gender= '" + StugenCB.SelectedItem.ToString() + "',grade= '" + StugradCB.SelectedItem.ToString() + "',joined_date='" + StujoinDT.Value.Date + "',stream='" + StustreCB.SelectedItem.ToString() + "'where student_id="+ StuidTB.Text +";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Student Details  are updated");
            
                    Con.Close();
                    pop();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome wel = new Welcome();
            wel.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void StugenCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void StujoinDT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            StuidTB.Clear();
            StunameTB.Clear();
            StusclTB.Clear();
            StuteleTB.Clear();
            StugenCB.SelectedIndex = -1;
            StustreCB.SelectedIndex = -1;
            StugradCB.SelectedIndex = -1;
            StujoinDT.Value = DateTime.Now;
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Welcome wlc = new Welcome();
            this.Close();
            wlc.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGV1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            StuidTB.Text = dataGV1.Rows[e.RowIndex].Cells[0].Value.ToString();
            StunameTB.Text = dataGV1.Rows[e.RowIndex].Cells[1].Value.ToString();
            StusclTB.Text = dataGV1.Rows[e.RowIndex].Cells[2].Value.ToString();
            StuteleTB.Text = dataGV1.Rows[e.RowIndex].Cells[3].Value.ToString();
            StugenCB.Text = dataGV1.Rows[e.RowIndex].Cells[4].Value.ToString();
            StugradCB.Text = dataGV1.Rows[e.RowIndex].Cells[5].Value.ToString();
          StujoinDT.Text = dataGV1.Rows[e.RowIndex].Cells[6].Value.ToString();
            StustreCB.Text = dataGV1.Rows[e.RowIndex].Cells[7].Value.ToString();
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Welcome wlc = new Welcome();
            this.Close();
            wlc.Show();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
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

        private void btnclear_MouseEnter(object sender, EventArgs e)
        {
            btnclear.BackColor = Color.Gray;
        }

        private void btnclear_MouseLeave(object sender, EventArgs e)
        {
            btnclear.BackColor = Color.White;
        }
    }
}
