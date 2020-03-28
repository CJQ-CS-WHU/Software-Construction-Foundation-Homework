using HW5_OrderList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OrderServiceUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        OrderServer orderServer;

        

        [TestMethod]
        public void TestMethod1()
        {

            Console.WriteLine("asd");
            orderServer = new OrderServer();
            OrderItem orderItem1 = new OrderItem("《如何爱上上网课》", 1, 9999);
            OrderItem orderItem2 = new OrderItem("《0基础入门C#》", 1, 99999);
            OrderItem orderItem3 = new OrderItem("《我要回武汉》", 1, 10);
            Order order1 = new Order("cjq", orderItem1, orderItem2, orderItem3);
            orderServer.AddOrder(order1);
            orderServer.Export();
        }
        /*
        [TestInitialize]
        static public void TestInitialize()
        {
            
        }

        [ClassInitializeAttribute]
        static public void ClassInitial(TestContext testContext) 
        {
           
        }

        [ClassCleanup]
        static public void ClassClearup() 
        { 
        
        }

        [TestCleanup]
        static public void TestCleanup() 
        {
        
        }
        */
    }
}
