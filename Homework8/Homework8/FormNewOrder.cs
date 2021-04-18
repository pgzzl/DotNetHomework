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
    public partial class FormNewOrder : Form
    {
        public OrderService orderService;
        public Order Order { get; set; } = new Order();
        public FormNewOrder(OrderService orderService) : this()
        {
            this.orderService = orderService;
        }
        public FormNewOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormDetail(Order).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxNewCustomerID.Text);
            string customerName = textBoxNewCustomer.Text;
            Customer customer = new Customer(customerName);
            Order.Customer = customer;
            Order.ID = id;
            orderService.AddOrder(Order);
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
