using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW5_OrderList;

namespace OrderServiceUnitTest
{
    [TestClass]
    class OrderServerUnitTest
    {
        OrderItem goodBook, badBook, MateBookX_2020;
        Order cjqOrder, cxhOrder;
        OrderServer orderServer;

        [TestInitialize]
        public void Init() 
        {
            orderServer = new OrderServer();
            badBook = new OrderItem("《如何统治非洲大地》", 10, 99.8);
            goodBook = new OrderItem("《如何不停学习》", 1, 233);
            MateBookX_2020 = new OrderItem("MateBook 991系列 9i 771 独立显卡 32G内存 ", 199999, 1);
            cjqOrder = new Order("陈家棋", badBook, goodBook);
            cxhOrder = new Order("陈心慧", MateBookX_2020);
            orderServer.AddOrder(cjqOrder);
        }

        [TestMethod]
        public void CreateOrderServerTest() 
        {
            Assert.IsNotNull(orderServer);
        }

        [TestMethod]
        public void AddOrderTest() 
        {

            Assert.IsNotNull(orderServer.orderList.ToArray());
        }   

        [TestMethod]
        public void DeleteOrderTest() 
        {
            orderServer.DeleteOrder(cjqOrder);
            Assert.IsNull(orderServer.orderList.ToArray());
        }

        [TestMethod]
        public void AlterOrderTest() 
        {
            orderServer.AlterOrder(cjqOrder, cxhOrder);
            Assert.IsTrue(orderServer.orderList.Contains(cxhOrder)
                &&!orderServer.orderList.Contains(cjqOrder));
        }

        [TestMethod]
        public void ExportTest() 
        {
            Assert.IsTrue(orderServer.Export());
        }

        [TestMethod]
        public void FindOrderTest() 
        {
            List<Order> query1=orderServer.FindOrder(null, null);
            List<Order> query2 = orderServer.FindOrder("陈家棋", null);
            List<Order> query3 = orderServer.FindOrder(null, "《如何统治非洲大地》");
            List<Order> query4 = orderServer.FindOrder("陈家棋", "《如何不停学习》");
            Assert.AreEqual(query1, cjqOrder);
            Assert.AreEqual(query2, cjqOrder);
            Assert.AreEqual(query3, cjqOrder);
            Assert.AreEqual(query4, cjqOrder);
        }

        [TestMethod]
        public void GetOrderTest() 
        {
            Assert.AreEqual(orderServer.GetOrder(cjqOrder.ID),cjqOrder);
        }

        [TestMethod]
        public void SortTest() 
        {
            orderServer.AddOrder(cxhOrder);
            orderServer.Sort(OrderServer.orderby.ID);
            List<Order> rightOrder = new List<Order>();
            rightOrder.Add(cjqOrder);
            rightOrder.Add(cxhOrder);
            Assert.AreEqual(orderServer.orderList, rightOrder);
        }
    }
}
