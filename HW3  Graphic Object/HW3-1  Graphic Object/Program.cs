using System;
using System.Collections.Generic;
using System.Text;

/*
1. 编写面向对象程序实现长方形、正方形、三角形等形状的类。
每个形状类都能计算面积、判断形状是否合法。 
请尝试合理使用接口/抽象类、属性来实现。

2. 随机创建10个形状对象，计算这些对象的面积之和。 
尝试使用简单工厂设计模式来创建对象。
*/

namespace HW3_Graphic_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建对象数组
            List<Graph> graphList=new List<Graph>();
            for (int i = 0; i < 10; i++)
                graphList.Add(randomGraph());
            //计算面积
            double areaSum = 0;
            graphList.ForEach(item => { areaSum += item.GetArea(); });
            //输出结果
            Console.WriteLine(areaSum);
        }

        static Graph randomGraph() 
        {
            Random rd = new Random();
            try
            {
                switch ((int)rd.Next(1, 3))
                {
                    case 1: return Factory.getGraph("Rectangle", rd.NextDouble(), rd.NextDouble());
                    case 2: return Factory.getGraph("Square", rd.NextDouble());
                    case 3: return Factory.getGraph("Triangle", rd.NextDouble(), rd.NextDouble(), rd.NextDouble());
                    default: return null;
                }
                return null;
            }
            catch (Exception e) 
            {
                Console.WriteLine("随机产生的边长无法满足条件");
                return null;
            }
        }
    }
}
