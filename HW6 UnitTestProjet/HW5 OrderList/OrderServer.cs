using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

/*
 添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能
*/

namespace HW5_OrderList
{
    public class OrderServer
    {
        public List<Order> orderList;

        public enum orderby 
        {
            ID,
            Total
        }

        public OrderServer() 
        {
            orderList = new List<Order>();
        }

        public void AddOrder(Order o) 
        {
            if (orderList.Contains(o))
                return;
            else
                orderList.Add(o);
        }

        public bool DeleteOrder(Order o) 
        {
            bool flag = true;
            if (!(flag = orderList.Remove(o)))
                Console.WriteLine("order: " + o + " is not exist.");
            return true;
        }

        public bool AlterOrder(Order wrong,Order right) 
        {
            bool flag = true;
            if (flag = orderList.Remove(wrong))
                orderList.Add(right);
            else
                Console.WriteLine("order: " + wrong + " is not exist.");
            return true;
        }

        public bool Export()
        {
            bool flag=false;
            using (System.IO.FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                xmlSerializer.Serialize(fs,this.orderList);
                flag = true;
            }
            Console.WriteLine("Order list Serialized as XML:\n");
            Console.WriteLine(File.ReadAllText("s.xml"));
            return flag;
        }

        //（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
        public List<Order> FindOrder(String goodsName,String costumer)
        {
            if (goodsName == null && costumer == null)
                return this.orderList;

            if (costumer != null&&goodsName==null)
            {
                var query = from i in orderList
                            where i.Costumer == costumer
                            orderby i.GetTotal()
                            select i;
                return query.ToList();
            }
            if (costumer == null && goodsName != null) 
            {
                var query = orderList.Where(order => 
                order.GetOrderItemList().Contains(new OrderItem(goodsName, 0, 0)))
                    .OrderBy(order => order.GetTotal()); 
                return query.ToList();
            }
            if (costumer != null && goodsName != null) 
            {
                var query = orderList.Where(order => order.Costumer == costumer)
                     .Where(order => order.GetOrderItemList().Contains(new OrderItem(goodsName, 0, 0)))
                     .OrderBy(order=>order.GetTotal());
                return query.ToList();
            }
            return null;
        }

        public Order GetOrder(int id) 
        {
            var r = from i in orderList
                    where i.ID == id
                    orderby i.GetTotal()
                    select i;
            Order o = r as Order;
            return o;
        }
        
        public void Sort(orderby o) 
        {
            switch (o) 
            {
                case orderby.ID:
                    orderList = orderList.OrderBy(order=>order.ID).ToList();
                    break;
                case orderby.Total:
                    orderList = orderList.OrderBy(order => order.GetTotal()).ToList();
                    break;
                default:
                    orderList = orderList.OrderBy(order => order.ID).ToList();
                    break;
            }
        }
    }
}
