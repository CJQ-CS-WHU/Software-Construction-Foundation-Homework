using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;
/*
 为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，
 实现创建订单、删除订单、修改订单、查询订单、导出订单、导入订单等功能。

要求：
（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。
（2）可以使用两个窗口。主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
（3）注意窗口的布局，在窗口尺寸变化时，不出现错位挤压等情况。
（4）尽量通过数据绑定来实现功能。订单和订单明细各使用一个bindingsource，通过DataMember来实现主从对象绑定。

 */
namespace OrderAppWin
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
                OrderItem egg = new OrderItem(2, "eggs", 1.2, 200);
                OrderItem milk = new OrderItem(3, "milk", 50, 10);

                Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
                Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
                Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });

                OrderService os = new OrderService();
                os.AddOrder(order1);
                os.AddOrder(order2);
                os.AddOrder(order3);
                os.Export(@"./orders.xml");

                Console.WriteLine("GetAllOrders");
                List<Order> orders = os.Orders;
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                os.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));
                Console.WriteLine("GetAllOrders After sort");
                orders = os.Orders;
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
                orders = os.QueryOrdersByCustomerName("Customer2");
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                Console.WriteLine("GetOrdersByGoodsName:'apple'");
                orders = os.QueryOrdersByGoodsName("apple");
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                Console.WriteLine("Remove order(id=2) and qurey all");
                os.RemoveOrder(2);
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                Console.WriteLine("Import from ./orders.xml");
                OrderService os2 = new OrderService();
                os2.Import("./orders.xml");
                os2.Orders.ForEach(order => Console.WriteLine(order));
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new OS(os));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
           

        }
    }
}
