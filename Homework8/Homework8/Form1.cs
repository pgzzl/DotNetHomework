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
    public partial class Form1 : Form
    {
        public static OrderService Service = new OrderService();
        FormDelOrder myDelOrder = new FormDelOrder(Service);
        FormNewOrder formNewOrder = new FormNewOrder(Service);
        public static Goods apple = new Goods("apple", 8);
        public static Goods phone = new Goods("phone", 1000);
        public static Goods watermelon = new Goods("watermelon", 12);
        public static Goods banana = new Goods("banana", 6);
        public static Goods pen = new Goods("pen", 16);
        public static Goods pad = new Goods("pad", 800);
        public Form1()
        {
            InitializeComponent();
            
            Order order1 = new Order(1, new Customer("张子龙"));
            Order order2 = new Order(2, new Customer("六非凡"));
           // order1.TotalPrice = 15;
           // order2.TotalPrice = 20;
            Service.AddOrder(order1);
            Service.AddOrder(order2);
            
           // CurrentOrders = Service.orders;
           // CurrentOrders.Add(order1);
            //CurrentOrders.Add(order1);
            //CurrentOrders.Add(order2);
            //CurrentOrders.Add(order2);

        }

       /* public  void freshDelID() {
           bindingSourceOrder.DataSource =Service.orders ;
        }*/

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 创建订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSourceOrder.DataSource = null;
            formNewOrder.ShowDialog();
            bindingSourceOrder.DataSource = Service.orders;
        }

        private void 删除订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSourceOrder.DataSource = null;
            myDelOrder.ShowDialog();
            bindingSourceOrder.DataSource = Service.orders;
          //  freshDelID();
        }

        private void buttonQueryAll_Click(object sender, EventArgs e)
        {
            bindingSourceOrder.DataSource = Service.orders;
        }

        private void textBoxQueryByID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonQueryByID_Click(object sender, EventArgs e)
        {
            bindingSourceOrder.DataSource = Service.orders.Where(s => s.ID == Convert.ToInt32(textBoxQueryByID.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSourceOrder.DataSource = Service.orders.Where(s => Convert.ToString(s.Customer) == textBoxQueryByCustomerName.Text);
        }

   

        private void 导出订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service.Export();
            MessageBox.Show("订单已导出s.xml");
        }

        private void 修改订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用删除和新建来修改订单");
        }

        private void 导入订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service.Import();
            MessageBox.Show("s.xml订单已导入");
        }
    }
}
