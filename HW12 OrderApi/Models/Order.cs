using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderApp
{
    public class Order : IComparable<Order>
    {

        [Key, Column(Order = 0)]
        public int OrderID { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public string CustomerID { get; set; }

        [NotMapped]
        public string CustomerName { get => (Customer != null) ? Customer.Name : ""; }

        [Key,Column(Order = 1)]
        public DateTime CreateTime { get; set; }

        public List<OrderItem> items;

        public Order() { items = new List<OrderItem>(); CreateTime = DateTime.Now; }

        public Order(int orderId, Customer customer, List<OrderItem> items)
        {
            this.OrderID = orderId;
            this.Customer = customer;
            this.CustomerID = customer.ID;
            this.CreateTime = DateTime.Now;
            this.items = (items == null) ? new List<OrderItem>() : items;
        }

        public List<OrderItem> Items
        {
            get { return items; }
        }

        public double TotalPrice
        {
            get => items.Sum(item => item.TotalPrice);
        }

        //不做修改，数据库中会自动产生结果
        public void AddItem(OrderItem orderItem)
        {
            if (Items.Contains(orderItem))
                throw new ApplicationException($"添加错误：订单项{orderItem.GoodsName} 已经存在!");
            Items.Add(orderItem);
        }

        //不做修改，数据库中会自动产生结果
        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{OrderID}, customer:{Customer},orderTime:{CreateTime},totalPrice：{TotalPrice}");
            items.ForEach(od => strBuilder.Append("\n\t" + od));
            return strBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderID == order.OrderID;
        }

        public override int GetHashCode()
        {
            var hashCode = -531220479;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);
            hashCode = hashCode * -1521134295 + CreateTime.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderID.CompareTo(other.OrderID);
        }
    }
}
