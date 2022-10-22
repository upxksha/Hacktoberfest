using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class Form1 : Form
    {
        private int counter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = counter.ToString();
            counter++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
