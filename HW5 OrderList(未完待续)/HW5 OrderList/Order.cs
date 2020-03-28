using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace HW5_OrderList
{
    //订单号、商品名称、客户
    public class Order
    {
        //流水号
        static public int Sequence = 0;

        //订单号
        public String ID { get; set; }

        //客户名称
        public String Costumer { get; set; }

        //订单明细
        public HashSet<OrderItem> OrderItemList { get; set; }

        //获取订单明细
        public HashSet<OrderItem> GetOrderItemList()
        {
            return OrderItemList;
        }

        public Order() 
        {
            ID = (Sequence++).ToString();
            this.Costumer = "default";
            this.OrderItemList = new HashSet<OrderItem>();
        }
        //创建订单：谁？购买了什么？
        public Order(String costumer = "non-member", params OrderItem[] newItem)
        {
            ID = (Sequence++).ToString();
            this.Costumer = costumer;
            this.OrderItemList = new HashSet<OrderItem>();
            AddOderItem(newItem);
        }
        //增
        public void AddOderItem(params OrderItem[] newItem)
        {
            foreach (OrderItem i in newItem)
            {
                foreach (OrderItem j in OrderItemList)
                {
                    if (i.Equals(j))
                    {
                        j.Quantity += i.Quantity;
                        j.Total = j.Quantity * j.UnitPrice;
                        break;
                    }
                }
                OrderItemList.Add(i);
            }
        }
        //删
        public void DeleteOrderItem(params OrderItem[] item)
        {
            foreach (OrderItem i in item)
                if (!OrderItemList.Remove(i))
                    new Exception();
        }
        //改
        public void AlertOrderItem(OrderItem wrong, OrderItem right)
        {
            if (OrderItemList.Remove(wrong))
            {
                OrderItemList.Add(right);
            }
            else
                new Exception();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(ID + "\t\t" + Costumer);
            foreach (OrderItem i in OrderItemList)
            {
                s.Append("\n");
                s.Append(i.ToString());
            }
            return s.ToString();
        }

        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o != null && o.ID == this.ID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
