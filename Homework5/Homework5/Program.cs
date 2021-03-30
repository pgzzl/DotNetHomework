using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Order :IComparable
    {
        public string Customer { get; set; }
        public List<OrderDetail> orderDetailsList=new List<OrderDetail>();
        public int allMoney { get; set; }
        public int ID { get; set; }
        public Order(string customer,int ID)
        {
            this.Customer = customer;
            this.ID = ID;
            this.Add();
            CalMoney();
        }
        public void CalMoney()
        {
            try
            {
                foreach (OrderDetail i in orderDetailsList)
                {
                    allMoney += i.ConcludeMoney();
                }
            }catch(Exception e)
            {
                Console.WriteLine("该订单未添加商品，总价为0");
            }
        }
        
        public override string ToString()
        {
            string sum;
            sum = "客户姓名：" + Customer + "\n订单号："+ID + "\n商品：\n";
            foreach(OrderDetail i in orderDetailsList)
            {

                sum+=i.ToString();
            }
            sum += "\n总金额：" + allMoney;
            return sum;
        }

        public int CompareTo(object obj)
        {
            return ID.CompareTo(obj);
        }
        public void Add()
        {
            int i=1;
            Console.WriteLine("往该订单添加商品（输入-1时结束添加商品）");
            while (Console.ReadLine() != "-1")
            {
                Console.WriteLine($"输入商品{i}名称：");
                string orderDetailName = Console.ReadLine();
                Console.WriteLine($"输入商品{i}数量：");
                int orderDetailNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"输入商品{i}单价");
                int orderDetailMoney = Convert.ToInt32(Console.ReadLine());
                OrderDetail orderDetail = new OrderDetail(orderDetailName, orderDetailNum, orderDetailMoney);
                this.orderDetailsList.Add(orderDetail);
                i++;
            }
        }
        public override bool Equals(object obj)
        {
            Order a = obj as Order;
            if (a != null && a.ID == this.ID)
                return true;
            else
                return false;

        }
        public override int GetHashCode()
        {
            return this.ID * 120 + 23;
        }
    }
    class OrderDetail
    {
        public string name { get; set; }
        public int number { get; set; }
        public int money { get; set; }
        public OrderDetail(string name,int num,int money)
        {
            this.name = name;
            this.number = num;
            this.money = money;
        }
        public int ConcludeMoney()
        {
            return number * money;
        }
        public override string ToString()
        {
            string sum;
            sum = name + " 数量："+number + "单价： "+money+"\n";
            return sum;
        }
        public override bool Equals(object obj)
        {
            OrderDetail a = obj as OrderDetail;
            if (a != null && a.name == this.name)
                return true;
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return this.money * 3 + this.number * 100;
        }
    }
    class OrderService 
    {
        public List<Order> orders=new List<Order>();
        public void Add()
        {
            Console.WriteLine("输入订单客户名字：");
            string orderName = Console.ReadLine();
            Console.WriteLine("输入订单单号：");
            int orderID = Convert.ToInt32(Console.ReadLine());
            Order order = new Order(orderName, orderID);
            orders.Add(order);
        }
        public void Delete()
        {
            try
            {
                Console.WriteLine("输入订单号删除该订单：");
                int numID = Convert.ToInt32(Console.ReadLine());
                foreach(Order i in orders)
                {
                    if(i.ID==numID)
                    {
                        orders.Remove(i);
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine("删除失败");
            }
        }
        public void Modify()
        {
            try
            {
                Console.WriteLine("输入要修改的订单号：");
                int numID = Convert.ToInt32(Console.ReadLine());
                foreach (Order i in orders)
                {
                    if (i.ID == numID)
                    {
                        Console.WriteLine("是否要修改客户名字(y/n)");
                        string flag=Console.ReadLine();
                        if(flag=="y")
                        {
                            Console.WriteLine("输入要修改的客户的名字：");
                            string name=Console.ReadLine();
                            i.Customer = name;
                        }
                        /*
                        Console.WriteLine("是否修改商品(y/n)");
                        flag = Console.ReadLine();
                        if (flag == "y") ;
                        {
                            
                        }*/

                        
                    }
                }

            }catch(Exception e)
            {
                Console.WriteLine("修改失败");
            }
        }
        //查询订单总金额
        public void Query()
        {
            var query1 = from s in orders
                         orderby s.allMoney descending
                         select s;
            List<Order> queryList = query1.ToList();
            foreach(var s in queryList)
            {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            int i = 0;
            while (true)
            {
                Console.WriteLine("输入1添加订单，2删除订单，3修改订单，4查询订单");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1: Console.WriteLine("添加订单"); orderService.Add(); break;
                    case 2: Console.WriteLine("删除订单"); orderService.Delete(); break;
                    case 3: Console.WriteLine("修改订单"); orderService.Modify(); break;
                    case 4: Console.WriteLine("查询订单"); orderService.Query(); break;
                    default:
                        Console.WriteLine("输入的数字无效");
                        break;
                }
            
            
            }
        }
    }
}
//增删改查
//订单号，商品名称，客户，订单金额
/*
 * （1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5） OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
*/