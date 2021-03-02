using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器窗体应用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            int s = 0;
            switch (operation.Text)
            {
                case "+": s = a + b; break;
                case "-": s = a - b; break;
                case "*": s = a * b; break;
                case "/": s = a / b; break;
            }
            result.Text = "" + s;
        }
    }
}
