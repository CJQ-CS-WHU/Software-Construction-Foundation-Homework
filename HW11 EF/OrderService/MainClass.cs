using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{

    class MainClass
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("创建测试数据... ...");
                OrderService os = new OrderService();
                OrderItem apple = new OrderItem(4, new Goods("1","apple",5),3);
                OrderItem egg= new OrderItem(2, new Goods("2", "egg", 1), 12);
                OrderItem book = new OrderItem(1, new Goods("3", "Bookssss", 20), 7);
                Order cjqOrder = new Order(1, new Customer("1", "cjq"), new List<OrderItem> { apple });
                Order cxhOrder = new Order(2, new Customer("2", "cxh"), new List<OrderItem> { egg });
                Order newOrder = new Order(1, new Customer("1", "cjq"), new List<OrderItem> { book });
                Console.WriteLine("运行测试... ...");
                Console.WriteLine("（1）添加订单");
                os.AddOrder(cjqOrder);
                os.AddOrder(cxhOrder);
                Console.WriteLine("（2）删除订单");
                os.RemoveOrder(cjqOrder.OrderID);
                Console.WriteLine("（3）更新订单");
                os.UpdateOrder(newOrder);
                Console.WriteLine("（4）查询订单");
                os.GetOrder(cjqOrder.OrderID);
                Console.WriteLine("测试完毕");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadLine();
            }

        }
    }
}
