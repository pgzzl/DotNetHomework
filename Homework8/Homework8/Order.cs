using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    //订单类:订单号，客户,商品表
    public class Order :IComparable<Order>
    {
        public Customer Customer { get; set; }
        public int ID { get; set; }
        public List<Orderdetail> orderdetails { get; set; } = new List<Orderdetail>();
        public int TotalPrice { get => orderdetails.Sum(d => d.Amount);  }
        public Order()
        {

        }
        public Order(int id, Customer customer)
        {
            this.ID = id;
            this.Customer = customer;
        }
        public void AddOrderDetails(Orderdetail orderdetail)
        {
            if (this.orderdetails.Contains(orderdetail))
            {
                throw new ApplicationException("商品已存在");
            }
            orderdetails.Add(orderdetail);
        }
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && this.ID == order.ID;
        }
        public override int GetHashCode()
        {
            return 342423 + this.ID.GetHashCode();
        }
        public void RemoveOrderDetails(int num)
        {
            orderdetails.RemoveAt(num);
        }
        public override string ToString()
        {
            String str = $"订单号：{this.ID},客户名字：{this.Customer}";
            orderdetails.ForEach(orderdetail => str += "\n" + orderdetail);
            return str;
        }
        public int CompareTo(Order otherorder)
        {
            if (otherorder == null) return 1;
            return ID - otherorder.ID;
        }
    }
}
