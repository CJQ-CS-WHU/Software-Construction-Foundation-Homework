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
        public List<Order> orderList = new List<Order>();

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

        public void Export()
        {
            using (System.IO.FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                xmlSerializer.Serialize(fs,this.orderList);
            }
            Console.WriteLine("Order list Serialized as XML:\n");
            Console.WriteLine(File.ReadAllText("s.xml"));
        }

        //（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
        public List<Order> FindOrder(String goodsName,String costumer)
        {
            if (goodsName == null && costumer == null)
                return null;
            if (costumer != null&&goodsName==null)
            {
                var order = from i in orderList
                            where i.Costumer == costumer
                            select i;
                List<Order> r = order.ToList();
                return r;
            }
            if (costumer == null && goodsName != null) 
            {
                return this.orderList;
            }
            if (costumer != null && goodsName != null) 
            {
                return this.orderList;
            }
            return this.orderList;
        }
        //查询订单（按照订单号、商品名称、客户等字段进行查询）
        public Order GetOrder(String id) 
        {
            var r= from i in orderList
                    where i.ID == id
                    select i;
            Order o = r as Order;
            return o;
        }
        //（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
        public void Sort() { }
        //（5）OrderService提供排序方法对保存的订单进行排序。
            //默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
    }
}
