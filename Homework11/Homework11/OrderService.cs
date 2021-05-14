using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework11
{
    public class OrderService
    {
        //添加订单
        public void AddOrder(Order order)
        {
            //orders.Add(order);
            using(var db=new OrderContext())
            {
                var order1 = new Order{ OrderID = order.OrderID, Customer = order.Customer,OrderDetails=order.OrderDetails };
                db.Orders.Add(order1);
                db.SaveChanges();
            }
        }
        //删除订单(按订单号删除订单)
        public void RemoveOrder(int OrderId)
        {
            using(var context=new OrderContext())
            {
                var order1 = context.Orders.FirstOrDefault(o => o.OrderID == OrderId);
                if (order1 != null)
                {
                    context.Orders.Remove(order1);
                    context.SaveChanges();
                }
            }
            //orders.RemoveAll(order => order.OrderID == id);

        }
        //修改订单（按订单号）
        public void Modify(Order order)
        {
            //RemoveOrder(order.OrderID);
            using(var context=new OrderContext())
            {
                var order1 = new Order() {OrderID=order.OrderID };
                context.Entry(order1).State = System.Data.Entity.EntityState.Modified;
                order1.Customer = order.Customer;
                order1.OrderDetails = order.OrderDetails;
                context.SaveChanges();

            }
        }
        //查询订单(返回所有信息)
        public  List<Order>  QueryAll()
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders;
                //Console.WriteLine(query);
                return query.ToList();
            }
            
        }
        //按订单号查询
        public List<Order> QueryByID(int id)
        {
            using(var context=new OrderContext())
            {
                var order1 = context.Orders.Where(o => o.OrderID == id);
                return order1.ToList();
            }
        }
        public List<Order> QueryByName(string name)
        {
            using (var context = new OrderContext())
            {
                var query =context.Orders.Where(o => o.Customer.CustomerID == name);
                return query.ToList();
            }
        }
      
 
    }
}
