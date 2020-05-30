using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderApp;
namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext context;

        //构造函数把TodoContext 作为参数，Asp.net core 框架可以自动注入TodoContext对象
        public OrderController(OrderContext context)
        {
            this.context = context;
        }
        //订单号查询
        // GET: api/order/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order
            =context.Orders.SingleOrDefault(p => p.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }
        //通过客户名查询所有订单
        // GET: api/todo
        // GET: api/todo/pageQuery?customerName="陈家棋"
        [HttpGet]
        public ActionResult<List<Order>> queryOrderByCustomer(string customerName)
        {
            Customer customer = (Customer)context.Customers
                     .Where(p => p.Name == customerName);
                List<Order> query = context.Orders
                    .Where(p => p.CustomerID == customer.ID)
                    .ToList();
            return query.ToList();
        }

        // POST: api/todo
        [HttpPost]
        public ActionResult<OrderItem> PostOrder(Order order)
        {
            try
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        // PUT: api/todo/{id}
        [HttpPut("{id}")]
        public ActionResult<OrderItem> UpdateOrder(Order newOrder)
        {
             try
            {
                Order oldOrder
                    =context.Orders.SingleOrDefault(p => p.OrderID == newOrder.OrderID);
                if (oldOrder == null)
                    throw new Exception();
                else 
                {
                    oldOrder = newOrder;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            try
            {
                var p = context.Orders
                    .FirstOrDefault(x => x.OrderID == id);
                context.Orders.Remove(p);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}
