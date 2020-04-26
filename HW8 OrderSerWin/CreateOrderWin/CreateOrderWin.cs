using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace CreateOrderWin
{
    public partial class CreateOrderWin : Form
    {
        OrderService Os { get; set; }
        Order AnOrder { get; set; }
        OrderItem OrderItem { get; set; }
        public CreateOrderWin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CreateOrderWin_Load(object sender, EventArgs e)
        {
            AnOrder = new Order();
            OrderItem = new OrderItem();
            textBox1.DataBindings.Add("Text",AnOrder,"OrderId");
            textBox2.DataBindings.Add("Text",AnOrder,"Customer");
            textBox3.DataBindings.Add("Text",OrderItem,"GoodsName");
            textBox4.DataBindings.Add("Text",OrderItem,"Price");
            textBox5.DataBindings.Add("Text",OrderItem,"Quantity");
            label6.Text = "订单号" + textBox1.Text 
                + "\n顾客" + textBox2.Text 
                + "\n商品名" + textBox3.Text 
                + "\n价格" + textBox4.Text 
                + "\n数量" + textBox5.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "订单号" + textBox1.Text
            + "\n顾客" + textBox2.Text
            + "\n商品名" + textBox3.Text
            + "\n价格" + textBox4.Text
            + "\n数量" + textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem();
            ClearItemBox();
        }

        private void AddItem() 
        {
            if (OrderItem.GoodsName != ""
                && OrderItem.Quantity.GetType() == typeof(int)
                && OrderItem.Quantity >= 1
                && OrderItem.Price > 0)
                AnOrder.AddItem(OrderItem);
            label6.Text = OrderItem.ToString();
            return;
        }

        private void ClearItemBox()
           => textBox3.Text = textBox4.Text = textBox5.Text = "";

        private void button2_Click(object sender, EventArgs e)
        {
            Os.AddOrder(AnOrder);
        }
    }
}
