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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
                 

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lbltopic_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
