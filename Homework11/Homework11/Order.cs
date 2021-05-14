using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Order : IComparable<Order>
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Order()
        { }


        public void AddOrderDetails(OrderDetail orderdetail)
        {
            if (this.OrderDetails.Contains(orderdetail))
            {
                throw new ApplicationException("商品已存在");
            }
            OrderDetails.Add(orderdetail);
        }
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && this.OrderID == order.OrderID;
        }
        public override int GetHashCode()
        {
            return 342423 + this.OrderID.GetHashCode();
        }
        public void RemoveOrderDetails(int num)
        {
            OrderDetails.RemoveAt(num);
        }
        public override string ToString()
        {
            String str = $"订单号：{this.OrderID},客户名字：{this.Customer}";
            OrderDetails.ForEach(orderdetail => str += "\n" + orderdetail);
            return str;
        }
        public int CompareTo(Order otherorder)
        {
            if (otherorder == null) return 1;
            return OrderID - otherorder.OrderID;
        }

    }
}
