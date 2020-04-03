using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_CayleyTree
{
    public partial class CayTree : Form
    {
        //图像
        private Graphics graphics;
        //绘图线程
        Thread drawThread;
        //深度
        int n = 10;
        //主长度
        int leng = 100;
        //左分分支长度比
        double per1 = 0.6;
        //右分支长度比
        double per2 = 0.7;
        //左分支角度
        double th1 = 30 * Math.PI / 180;
        //右分支角度
        double th2 = 20 * Math.PI / 180;
        //颜色
        Pen p= Pens.Blue;
        //窗体初始化
        public CayTree()
        {
            InitializeComponent();
        }
        //画图按钮
        private void btnDraw_Click(object sender, EventArgs e)
        {

            ThreadStart drawThreadStarter = new ThreadStart(DrawCaylayThread);
            if (drawThread!=null)
                drawThread.Abort();
            drawThread = new Thread(drawThreadStarter);
            drawThread.Start();
        }
        //画图线程
        public void DrawCaylayThread() 
        {
            if (graphics != null)
                graphics.Clear(Color.White);
            graphics = CreateGraphics();
            drawCayTree(n, 400, 500, leng, -Math.PI / 2, p);
        }
        //画图函数
        void drawCayTree(int n, double x0, double y0, double leng, double th, Pen p)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1, p);
            drawCayTree(n - 1, x1, y1, per1 * leng, th + th1, p);
            drawCayTree(n - 1, x1, y1, per2 * leng, th - th2, p);
        }
        //画线函数
        void drawLine(double x0, double y0, double x1, double y1, Pen p)
           => graphics.DrawLine(p, (int)x0, (int)y0, (int)x1, (int)y1);
        //修改参数
        private void trbN_Scroll(object sender, EventArgs e) => n = trbN.Value;
        private void trbLeng_Scroll(object sender, EventArgs e) => leng = trbLeng.Value;
        private void trbPer1_Scroll(object sender, EventArgs e)=> per1 = trbPer1.Value/10;
        private void trbPer2_Scroll(object sender, EventArgs e) => per2 = trbPer2.Value/10;
        private void trbth1_Scroll(object sender, EventArgs e) => th1 = trbth1.Value/100;
        private void trackBar5_Scroll(object sender, EventArgs e) => th2 = trbPer2.Value/100;
        //修改颜色
        private void cbxPen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cbxPen.SelectedIndex);
            switch (cbxPen.SelectedIndex) 
            {
                case 0:p = Pens.Red;break;
                case 1:p = Pens.Yellow;break;
                case 2:p = Pens.Blue;break;
                case 3:p = Pens.Green;break;
                default:break;
            }
        }
    }
}
