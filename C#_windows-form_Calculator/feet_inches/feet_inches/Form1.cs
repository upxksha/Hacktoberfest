using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feet_inches
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1_box.Text);
            int num2 = int.Parse(num2_box.Text);
            int sub = num1 - num2;
            output.Text = Convert.ToString(sub);

        }

        
       
        private void Addition_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1_box.Text);
            int num2 = int.Parse(num2_box.Text);
            int add= num1 + num2;
            output.Text = Convert.ToString(add);
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1_box.Text);
            int num2 = int.Parse(num2_box.Text);
            int mul = num1 * num2;
            output.Text = Convert.ToString(mul);

        }

        private void Division_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1_box.Text);
            int num2 = int.Parse(num2_box.Text);
            int div = num1 / num2;
            output.Text = Convert.ToString(div);

        }
    }
}
