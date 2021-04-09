using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        //double th1 = 20 * Math.PI / 180;
        //double th2 = 20 * Math.PI / 180;
        //double per1 = 0.6;
        //double per2 = 0.7;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, Convert.ToDouble(textBox_per1.Text) * leng, th + Convert.ToInt32(textBox_th1.Text)*Math.PI/180);
            drawCayleyTree(n - 1, x1, y1, Convert.ToDouble(textBox_per2.Text) * leng, th - Convert.ToInt32(textBox_th2.Text) * Math.PI / 180);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            
            switch(comboBox_color.SelectedIndex)
            {
                case 0:graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);break;
                case 1:graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);break;
                case 2:graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);break;
                default:
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);break;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel_Draw.CreateGraphics();
            drawCayleyTree(Convert.ToInt32(textBox_n.Text),200,310,Convert.ToInt32(textBox_leng.Text),-Math.PI/2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_Setting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
