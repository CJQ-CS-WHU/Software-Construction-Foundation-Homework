using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW5_OrderList;
namespace OrderServiceUnitTest
{
    [TestClass]
    class OrderItemUnitTest
    {
        OrderItem book, talk;
        [TestInitialize]
        public void Init() 
        {
            book = new OrderItem("《加油，湖北》", 1, 1);
            talk = new OrderItem("静下心来，不要浮躁", 1, 10);
        }

        [TestMethod]
        public void CreateNullOrderItem() 
        {
            OrderItem nullItem = new OrderItem();
            Assert.IsNotNull(nullItem);
        }

        [TestMethod]
        public void ToStringTest() 
        {
            Assert.IsNotNull(book.ToString());
        }

        [TestMethod]
        public void EqualsTest() 
        {
            OrderItem book1 = new OrderItem("《加油，湖北》", 1, 3);
            Assert.IsTrue(book1.Equals(book)&&!book1.Equals(talk));
        }
    }
}
