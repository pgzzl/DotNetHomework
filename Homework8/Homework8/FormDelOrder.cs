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
    public partial class FormDelOrder : Form
    {
        public List<Order> orderService { get; set; }
        public FormDelOrder(OrderService service):this()
        {
            orderService = service.orders;

        }
        public FormDelOrder()
        {
            InitializeComponent();
           
        }

        private void buttonDelByID_Click(object sender, EventArgs e)
        {
           orderService.RemoveAll(s => s.ID == int.Parse(textBoxDelByID.Text));
          // Form1.Service.orders = orderService;
            this.Close();
        }

        private void FormDelOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDelByID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
