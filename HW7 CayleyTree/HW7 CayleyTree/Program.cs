﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 将课本中例5-31的Cayley树绘图代码进行修改。添加一组控件用以调节树的绘制参数。
 参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、左分支长度比（per2）、
 右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）。
*/
namespace HW7_CayleyTree
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CayTree());
        }
    }
}
