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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            TextBox2.PasswordChar = '•';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)

        {        
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDB_Connection"].ToString());
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Login Where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
               
            this.Close();

            Welcome obj = new Welcome();
            obj.Show();
        }

            else
            {
                MessageBox.Show("Wrong username or password!");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Exit this Application ?",
                                      "Confirm Exit",
                                      MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.ForeColor = Color.White;

        }

        private void lallogout_Click(object sender, EventArgs e)
        {

        }
    }
}
