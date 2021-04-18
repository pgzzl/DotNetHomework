using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework8
{
    
        //订单服务类：添加，删除，修改，查询（按订单号，商品名称，客户，订单金额）
        public class OrderService
        {
            public List<Order> orders = new List<Order>();
            XmlSerializer xmlSerializaer = new XmlSerializer(typeof(List<Order>));
        //添加订单
        public void AddOrder(Order order)
            {
                if (orders.Contains(order))
                {
                    throw new ApplicationException($"订单{order.ID}已存在");
                }
                orders.Add(order);
            }
            //删除订单(按订单号删除订单)
            public void RemoveOrder(int id)
        {
            
                orders.RemoveAll(order => order.ID == id);
   
            }
            //修改订单（按订单号）
            public void Modify(Order order)
            {
                RemoveOrder(order.ID);
                orders.Add(order);
            }
            //查询订单(返回所有信息)
            public List<Order> QueryAll()
            {
                return orders;
            }
            //按订单号查询
            public List<Order> QueryByID(int id)
            {
                var query = orders.Where(o => o.ID == id);
                return query.ToList();
            }
            public List<Order> QueryByName(string name)
            {
                var query = orders.Where(o => o.Customer.Name == name);
                return query.ToList();
            }
            public void Sort(Comparison<Order> comparison)
            {
                orders.Sort(comparison);
            }
        //将订单序列序列化为xml文件

        public void Export()
        {
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializaer.Serialize(fs, orders);
            }
        }
        //将xml文件中载入订单
        public void Import()
        {
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                List<Order> orders1 = (List<Order>)xmlSerializaer.Deserialize(fs);
                orders = orders.Union(orders1).ToList<Order>();
            }
        }
    }
}
