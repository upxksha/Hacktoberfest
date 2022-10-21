using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_pro_2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students fl = new Students();
            fl.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Papers pr = new Papers();
            pr.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
            MessageBox.Show("Sucessfully Logged Out");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            credentials objcrd = new credentials();
            this.Hide();
            objcrd.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Papers pr = new Papers();
            this.Hide();
            pr.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Progress gre = new Progress();
            this.Hide();
            gre.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Progress gre = new Progress();
            this.Hide();
            gre.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Login objlogin = new Login();
            this.Close();
            objlogin.Show();
            MessageBox.Show("LOGOUT Successfully !!!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login objlogin = new Login();
            this.Close();
            objlogin.Show();
            MessageBox.Show("LOGOUT Successfully !!!");
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Exit this Application ?",
                                     "Confirm Exit",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lbldashboard_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pnlPapers_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pnlPapers_MouseEnter(object sender, EventArgs e)
        {
            pnlDetails.BackColor = Color.GreenYellow;
        }

        private void pnlPapers_MouseLeave(object sender, EventArgs e)
        {
            pnlDetails.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblpapers_MouseEnter(object sender, EventArgs e)
        {
            pnlDetails.BackColor = Color.GreenYellow;
        }
        private void lblpapers_MouseLeave(object sender, EventArgs e)
        {
            pnlDetails.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblpapers_Click(object sender, EventArgs e)
        {
            Students objstudents = new Students();
            this.Hide();
            objstudents.Show();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pnlDetails.BackColor = Color.GreenYellow;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pnlDetails.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void pnlPapers_MouseEnter_1(object sender, EventArgs e)
        {
            pnlPapers.BackColor = Color.GreenYellow;
        }
        private void pnlPapers_MouseLeave_1(object sender, EventArgs e)
        {
            pnlPapers.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void picpapers_Click(object sender, EventArgs e)
        {
            Papers objPapers = new Papers();
            this.Hide();
            objPapers.Show();
        }

        private void picpapers_MouseEnter(object sender, EventArgs e)
        {
            pnlPapers.BackColor = Color.GreenYellow;
        }

        private void picpapers_MouseLeave(object sender, EventArgs e)
        {
            pnlPapers.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblpapers_MouseEnter_1(object sender, EventArgs e)
        {
            pnlPapers.BackColor = Color.GreenYellow;
        }
        private void lblpapers_MouseLeave_1(object sender, EventArgs e)
        {
            pnlPapers.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void pnlPapers_MouseLeave_2(object sender, EventArgs e)
        {
            pnlPapers.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblpapers_MouseLeave_2(object sender, EventArgs e)
        {
            pnlPapers.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void pnlProgress_MouseEnter(object sender, EventArgs e)
        {
            pnlProgress.BackColor=Color.YellowGreen; 
        }

        private void pnlProgress_MouseLeave(object sender, EventArgs e)
        {
            pnlProgress.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void picprogress_MouseEnter(object sender, EventArgs e)
        {
            pnlProgress.BackColor = Color.YellowGreen;
        }
        private void picprogress_MouseLeave(object sender, EventArgs e)
        {
            pnlProgress.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblprogress_MouseEnter(object sender, EventArgs e)
        {
            pnlProgress.BackColor = Color.YellowGreen;
        }

        private void pnlcredentials_MouseEnter(object sender, EventArgs e)
        {
            pnlcredentials.BackColor = Color.YellowGreen;
        }

        private void pnlcredentials_MouseLeave(object sender, EventArgs e)
        {
            pnlcredentials.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void piccredentials_MouseEnter(object sender, EventArgs e)
        {
            pnlcredentials.BackColor = Color.YellowGreen;
        }

        private void lblcredentials_MouseEnter(object sender, EventArgs e)
        {
            pnlcredentials.BackColor = Color.YellowGreen;
        }

        private void picdetails_Click(object sender, EventArgs e)
        {
            Students objstudents = new Students();
            this.Hide();
            objstudents.Show();
        }

        private void pnlDetails_MouseClick(object sender, MouseEventArgs e)
        {
            Students objstudents = new Students();
            this.Hide();
            objstudents.Show();
        }

        private void lblpapers_Click_1(object sender, EventArgs e)
        {
            Papers objPapers = new Papers();
            this.Hide();
            objPapers.Show();
        }

        private void pnlPapers_MouseClick(object sender, MouseEventArgs e)
        {
            Papers objPapers = new Papers();
            this.Hide();
            objPapers.Show();
        }

        private void picprogress_Click(object sender, EventArgs e)
        {
            Progress objprogress = new Progress();
            this.Hide();
            objprogress.Show();
        }

        private void lblprogress_Click(object sender, EventArgs e)
        {
            Progress objprogress = new Progress();
            this.Hide();
            objprogress.Show();
        }

        private void pnlProgress_MouseClick(object sender, MouseEventArgs e)
        {
            Progress objprogress = new Progress();
            this.Hide();
            objprogress.Show();
        }

        private void piccredentials_Click(object sender, EventArgs e)
        {
            credentials objcred = new credentials();
            this.Hide();
            objcred.Show();
        }

        private void lblcredentials_Click(object sender, EventArgs e)
        {
            credentials objcred = new credentials();
            this.Hide();
            objcred.Show();
        }

        private void pnlcredentials_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlcredentials_MouseClick(object sender, MouseEventArgs e)
        {
            credentials objcred = new credentials();
            this.Hide();
            objcred.Show();
        }

        private void piclogout_Click(object sender, EventArgs e)
        {
            
            var confirmlogout = MessageBox.Show("Are you sure to Logout ?",
                                     "Confirm Logout",
                                     MessageBoxButtons.YesNo);
            if (confirmlogout == DialogResult.Yes)
            {
                Login objlogin = new Login();
                this.Close();
                objlogin.Show();
                MessageBox.Show("You've been logged out");
            }
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
            var confirmlogout = MessageBox.Show("Are you sure to Logout ?",
                                     "Confirm Logout",
                                     MessageBoxButtons.YesNo);
            if (confirmlogout == DialogResult.Yes)
            {
                Login objlogin = new Login();
                this.Close();
                objlogin.Show();
                MessageBox.Show("You've been logged out");

            }
        }

        private void pnllogout_MouseClick(object sender, MouseEventArgs e)
        {
            var confirmlogout = MessageBox.Show("Are you sure to Logout ?",
                                     "Confirm Logout",
                                     MessageBoxButtons.YesNo);
            if (confirmlogout == DialogResult.Yes)
            {
                Login objlogin = new Login();
                this.Close();
                objlogin.Show();
                MessageBox.Show("You've been logged out");
            }
        }

        private void pnllogout_MouseEnter(object sender, EventArgs e)
        {
            pnllogout.BackColor = Color.FromArgb(184, 15, 10);
        }

        private void piclogout_MouseEnter(object sender, EventArgs e)
        {
            pnllogout.BackColor = Color.FromArgb(184, 15, 10);
        }

        private void lbllogout_MouseEnter(object sender, EventArgs e)
        {
            pnllogout.BackColor = Color.FromArgb(184, 15, 10);
        }

        private void pnllogout_MouseLeave(object sender, EventArgs e)
        {
            pnllogout.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void pnllogout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
