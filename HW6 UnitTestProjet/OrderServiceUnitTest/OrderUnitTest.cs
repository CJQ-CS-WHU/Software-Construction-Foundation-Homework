using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW5_OrderList;

namespace OrderServiceUnitTest
{
    [TestClass]
    class OrderUnitTest
    {
        Order order1, order2;
        OrderItem item1 = new OrderItem("提高效率 迫在眉睫",1,2);
        OrderItem item2 = new OrderItem("不要和别人多废话，专心做事", 2, 10);
        [TestInitialize]
        public void Init() 
        {
            order1 = new Order("陈家棋", new OrderItem("不要看手机", 1, 1));
            order2 = new Order("渣渣辉");
            order1.AddOderItem(item1);
        }
        [TestMethod]
        public void CreateOrderTest() 
        {
            
            Assert.IsNotNull(order1);
        }

        [TestMethod]
        public void CreateNullOrderTest() 
        {
            Order order2 = new Order();
            Assert.IsNotNull(order2);
        }

        [TestMethod]
        public void AddOrderItemTest() 
        {
            order1.AddOderItem(new OrderItem("dont think so much!", 1, 1));
            Assert.IsTrue(order1.OrderItemList.Contains(new OrderItem("dont think so much!", 1, 1)));
        }

        [TestMethod]
        public void DeleteOrderItemTest() 
        {
            order1.AddOderItem(new OrderItem("dont think so much!", 1, 1));
            order1.DeleteOrderItem(new OrderItem("dont think so much!", 1, 1));
            Assert.IsFalse(order1.OrderItemList.Contains(new OrderItem("dont think so much!", 1, 1)));
        }

        [TestMethod]
        public void AlertOrderItemTest() 
        {
            order1.AlertOrderItem(item1, item2);
            Assert.IsTrue(order1.GetOrderItemList().Contains(item2) 
                && !order1.GetOrderItemList().Contains(item1));
        }


        [TestMethod]
        public void EqualsTest() 
        {
            Assert.IsFalse(order1.Equals(order2));
        }
    }
}
