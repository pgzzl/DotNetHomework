using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class FormDetail : Form
    {
        public Order order;
        public FormDetail(Order order):this()
        {
            this.order = order;
        }
        public FormDetail()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddOrderDetail_Click(object sender, EventArgs e)
        {
            int appleNum= (int)numericUpDownApple.Value;
            int phoneNum = (int)numericUpDownPhone.Value;
            int watermelonNum = (int)numericUpDownWatermelon.Value;
            int bananaNum = (int)numericUpDownBanana.Value;
            int penNum = (int)numericUpDownPen.Value;
            int padNum = (int)numericUpDownPad.Value;

            if(appleNum>0)
                order.AddOrderDetails(new Orderdetail(Form1.apple, appleNum));
            if (phoneNum > 0)
                order.AddOrderDetails(new Orderdetail(Form1.phone, phoneNum));
            if (watermelonNum > 0)
                order.AddOrderDetails(new Orderdetail(Form1.watermelon, watermelonNum));
            if (bananaNum > 0)
                order.AddOrderDetails(new Orderdetail(Form1.banana, bananaNum));
            if (penNum > 0)
                order.AddOrderDetails(new Orderdetail(Form1.pen, penNum));
            if (padNum > 0)
                order.AddOrderDetails(new Orderdetail(Form1.pad, padNum));
            this.Close();
        }
    }
}
