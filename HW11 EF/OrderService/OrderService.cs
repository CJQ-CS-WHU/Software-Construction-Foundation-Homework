using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{

    /**
     * The service class to manage orders
     * */
    public class OrderService
    {
        //the order list
        public List<Order> orders;

        public OrderService()
        {
            orders = new List<Order>();
        }

        public List<Order> Orders
        {
            get => orders;
        }

        //数据库查询
        public Order GetOrder(int id)
        {
            /*
             return orders.Where(o => o.OrderID == id).FirstOrDefault();
             */
            using (var context = new OrderContext())
            {
                return context.Orders
                    .SingleOrDefault(p => p.OrderID == id);
            }
        }

        //查询有无，如无添加
        public void AddOrder(Order order)
        {
            /*
            if (orders.Contains(order))
                throw new ApplicationException($"添加错误: 订单{order.OrderID} 已经存在了!");
            orders.Add(order);
            */
            if (GetOrder(order.OrderID) != null)
                Console.WriteLine($"添加错误: \n\t订单 {order.OrderID} \n\t已存在");
            using (var context = new OrderContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
                Console.WriteLine($"添加成功\n\t订单{order.OrderID}\n\t已添加到数据库中");
            }
        }

        //查询有无，如有删除
        public void RemoveOrder(int orderId)
        {
            /*
            Order order = GetOrder(orderId);
            if (order != null)
            {
                orders.Remove(order);
            }
            */
            using (var context = new OrderContext())
            {
                var p = context.Orders
                    .FirstOrDefault(x => x.OrderID == orderId);
                if (p == null)
                    Console.WriteLine($"删除错误: \n\t订单{orderId} \n\t不存在");
                else
                {
                    try
                    {
                        context.Orders.Remove(p);
                        context.SaveChanges();
                        Console.WriteLine($"删除成功\n\t订单{orderId}\n\t已删除");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"删除失败\n\t订单{orderId}\n\t仍存在");
                    }
                }
            }
        }

        //查询所有商品名相同的项
        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            /*
            using (var context = new OrderContext())
            {
                var result=from p in context.Orders 
                           join q in  context.OrderItems
                           on 1 equals 1
                           select new 
                           {
                                
                           }
            }
            */
            return new List<Order>();
        }

        //先在客户表中查询一次，存下id，再用id在orders表中查询一次
        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using (var context = new OrderContext()) 
            {
                Customer customer = (Customer)context.Customers
                     .Where(p => p.Name == customerName);
                List<Order> result = context.Orders
                    .Where(p => p.CustomerID == customer.ID)
                    .ToList();
                return result;
            }
        }

        //先查询是否存在，如果存在则修改
        public void UpdateOrder(Order newOrder)
        {
            using (var context = new OrderContext()) 
            {
                Order oldOrder = GetOrder(newOrder.OrderID);
                if (oldOrder == null)
                    Console.WriteLine($"更新失败\n\t订单{newOrder}不存在");
                else 
                {
                    oldOrder = newOrder;
                    context.SaveChanges();
                }
            }
        }

        //调用order'by
        public void Sort()
        {
            orders.Sort();
        }

        public void Sort(Func<Order, Order, int> func)
        {
            Orders.Sort((o1, o2) => func(o1, o2));
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }

        public object QueryByTotalAmount(float amout)
        {
            return orders
               .Where(order => order.TotalPrice >= amout)
               .OrderByDescending(o => o.TotalPrice)
               .ToList();
        }
    }
}
