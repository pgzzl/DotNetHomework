using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //商品：商品名，单价
    public class Goods
    {
        private string name;
        private int price;
        public Goods(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name { get => name; }
        public int Price { get => price; }
        public override string ToString()
        {
            return $"{Name},价格{price}";
        }
    }
    //客户类：名字
    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return $"客户名:{Name}";
        }
    }
    //订单类:订单号，客户,商品表
    public class Order : IComparable<Order>
    {
        public Customer Customer { get; set; }
        public int ID { get; set; }
        public List<Orderdetail> orderdetails { get; } = new List<Orderdetail>();
        public int TotalPrice { get => orderdetails.Sum(d => d.Amount); }
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
    //订单明细类:具体商品,商品数量，,总价
    public class Orderdetail
    {
        public Goods Goods { get; set; }
        public int Number { get; set; }
        public int Amount { get => Number * Goods.Price; }
        public Orderdetail(Goods goods, int num)
        {
            Goods = goods;
            Number = num;
        }
        public override bool Equals(object obj)
        {
            var s = obj as Orderdetail;
            return s != null && EqualityComparer<Goods>.Default.Equals(Goods, s.Goods);
        }
        public override int GetHashCode()
        {
            return 3443982 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
        }


        public override string ToString()
        {
            return $"商品：{Goods}数量 {Number}";
        }
    }
    //订单服务类：添加，删除，修改，查询（按订单号，商品名称，客户，订单金额）
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer customer1 = new Customer("zzl");
                Customer customer2 = new Customer("ygm");

                Goods apple = new Goods("苹果", 12);
                Goods banana = new Goods("香蕉", 10);
                Goods cat = new Goods("猫", 20);

                Order order1 = new Order(1, customer1);
                order1.AddOrderDetails(new Orderdetail(apple, 2));
                order1.AddOrderDetails(new Orderdetail(banana, 3));

                Order order2 = new Order(2, customer2);
                order2.AddOrderDetails(new Orderdetail(cat, 2));

                Order order3 = new Order(3, customer1);
                order3.AddOrderDetails(new Orderdetail(cat, 1));

                OrderService orderService = new OrderService();
                orderService.AddOrder(order1);
                orderService.AddOrder(order2);
                orderService.AddOrder(order3);

                Console.WriteLine("查询所有");
                orderService.QueryAll().ForEach(o => Console.WriteLine(o));
                Console.WriteLine("按订单号查询");
                orderService.QueryByID(2).ForEach(o => Console.WriteLine(o));
                Console.WriteLine("按名字查");
                orderService.QueryByName("zzl").ForEach(o => Console.WriteLine(o));

                Console.WriteLine("按总价排序");
                orderService.Sort((o1, o2) => o2.TotalPrice.CompareTo(o1.TotalPrice));
                orderService.QueryAll().ForEach(o => Console.WriteLine(o));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
/*
 * 写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。

提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。

要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5） OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
*/