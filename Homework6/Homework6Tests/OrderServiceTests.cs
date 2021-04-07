using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest1()
        {
            //arrange
            Order expected=new Order(1, new Customer("zzl"));
            OrderService test = new OrderService();
            //act
            test.AddOrder(expected);
            //assert
            Assert.AreEqual(expected,test.orders.Find(o=>o.ID==1));
        }
        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrderTest2()
        {
            Order expected = new Order(1, new Customer("zzl"));
            OrderService test = new OrderService();

            test.AddOrder(expected);
            test.AddOrder(expected);
        }
        [TestMethod()]
        public void RemoveOrderTest()
        {
            //arrange
            Order order1 = new Order(1, new Customer("zzl"));
            OrderService test = new OrderService();
            test.orders.Add(order1);
            Order expected = null;
            //act
            test.RemoveOrder(1);
            //assert
            Assert.AreEqual(expected, test.orders.Find(o => o.ID == order1.ID));

        }

        [TestMethod()]
        public void ModifyTest()
        {
            Order expected = new Order(1, new Customer("zzl"));
            OrderService test = new OrderService();
            test.orders.Add(expected);

            expected.Customer.Name = "zzl";
            test.Modify(expected);

            Assert.AreEqual(expected, test.orders.Find(o => o.ID == 1));

        }

        [TestMethod()]
        public void QueryAllTest()
        {
            //arrange
            List<Order> expected = new List<Order>();
            OrderService test = new OrderService();

            test.orders = expected;

            Assert.AreEqual(expected, test.QueryAll());
        }

        [TestMethod()]
        public void QueryByIDTest()
        {
            OrderService test = new OrderService();
            Order order1 = new Order(1, new Customer("zzl"));
            Order order2 = new Order(2, new Customer("pg"));
            test.orders.Add(order1);
            test.orders.Add(order2);

            Assert.AreEqual(test.orders.Find(o=>o.ID==1), test.QueryByID(1).Find(o=>o.ID==1));
        }

        [TestMethod()]
        public void QueryByNameTest()
        {
            OrderService test = new OrderService();
            Order order1 = new Order(1, new Customer("zzl"));
            Order order2 = new Order(2, new Customer("pg"));
            test.orders.Add(order1);
            test.orders.Add(order2);

            CollectionAssert.AreEqual(test.orders.FindAll(o => o.Customer.Name == "pg"), test.QueryByName("pg"));
        }

        [TestMethod()]
        public void SortTest()
        {
            OrderService test = new OrderService();
            Order order1 = new Order(1, new Customer("zzl"));
            Order order2 = new Order(2, new Customer("pg"));
            Order order3 = new Order(3, new Customer("zp"));
            List<Order> expected = new List<Order>();
            expected.Add(order1);
            expected.Add(order2);
            expected.Add(order3);

            test.orders.Add(order2);
            test.orders.Add(order1);
            test.orders.Add(order3);
            test.Sort((o1, o2) => o1.ID - o2.ID ) ;

            CollectionAssert.AreEqual(expected, test.orders);
        }
        
        [TestMethod()]
        public void ExportTest()
        {
            OrderService test = new OrderService();
            test.Export();

            Assert.IsTrue(File.Exists("s.xml"));
        }


        [TestMethod()]
        public void ImportTest()
        {
            OrderService test = new OrderService();
            List<Order> expexted=new List<Order>();

            if (File.Exists("s.xml"))
            {
                test.Import();
            }
            CollectionAssert.AreEqual(expexted, test.orders);
        }
    }
}