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
namespace OrderAppWin
{
    public partial class OS : Form
    {
        public OrderService orderService;
        //查询类型标记
        public int QueryType { get; set; }
        //查询关键词
        public string KeyWord { get; set; }
        //查询返回值
        public Order queryRes { get; set; }
        //查询返回列表
        public List<Order> queryResultList { get; set; }

        public OS(OrderService os)
        {
            InitializeComponent();
            orderService = os;
        }

        private void OS_Load(object sender, EventArgs e)
        {
            textBox1.DataBindings.Add("Text", this, "KeyWord");
            comboBox1.DataBindings.Add("SelectedIndex", this,"QueryType");
            orderBindingSource.DataSource = orderService.Orders;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query();
            ShowOrder();
        }

        private void Query() 
        {
            //先清空上次查询结果
            queryRes = null;
            queryResultList = null;
            //根据类型查询，结果绑定到表上
            switch (QueryType)
            {
                case 0:
                    queryRes = orderService.GetOrder(Convert.ToUInt32(KeyWord));
                    break;
                case 1:
                    queryResultList = orderService.QueryOrdersByGoodsName(KeyWord);
                    break;
                case 2:
                    queryResultList= orderService.QueryOrdersByCustomerName(KeyWord);
                    break;
                default:
                    break;
            }
        }

        private void ShowOrder() 
        {
            switch (QueryType)
            {
                case 0:
                    orderBindingSource.DataSource = queryRes;
                    break;
                case 1:
                case 2:
                    orderBindingSource.DataSource = queryResultList;
                    break;
                default:
                    orderBindingSource.DataSource = orderService.Orders;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateOrderWin createOrderWin = new CreateOrderWin();
            createOrderWin.Show();
            orderService.AddOrder(createOrderWin.AnOrder);
            Console.WriteLine(createOrderWin.AnOrder);
        }

        private void button4_Click(object sender, EventArgs e) {
            if (queryRes != null)
            {
                AlterOrderWin aow = new AlterOrderWin(queryRes.OrderId);
                aow.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //删除查询结果
            if (queryRes != null) 
            {
                orderService.RemoveOrder(queryRes.OrderId);
            }
            if(queryResultList!=null)
            {
                foreach (Order i in queryResultList)
                    orderService.RemoveOrder(i.OrderId);
            }
            Query();
            ShowOrder();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
