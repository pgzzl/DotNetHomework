using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox_num1.Text);
            int b = Convert.ToInt32(textBox_num2.Text);
            int s = 0;
            switch (textBox_operation.Text)
            {
                case "+": s = a + b; break;
                case "-": s = a - b; break;
                case "*": s = a * b; break;
                case "/": s = a / b; break;
            }
            textBox_result.Text = "" + s;
        }
    }
}
