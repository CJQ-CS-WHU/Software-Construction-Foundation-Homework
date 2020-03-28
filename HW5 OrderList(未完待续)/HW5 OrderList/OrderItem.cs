using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_OrderList
{
    public class OrderItem
    {
        //商品名
        public string Name { get; set; }
        //单价
        public float UnitPrice { get; set; }
        //数量
        public int Quantity { get; set; }
        //总金额
        public float Total { get; set; }

        public OrderItem() 
        {
            this.Name = "default";
            this.Quantity = 0;
            this.UnitPrice = 0;
        }

        public OrderItem(string name, int quantity, float unitPrice) 
        {
            this.Name = name;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return this.Name + "\t" + this.UnitPrice + "\t" 
                + this.Quantity + "\t" + this.Total;
        }

        public override bool Equals(object obj)
        {
            OrderItem o = obj as OrderItem;
            return o != null && this.Name == o.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
