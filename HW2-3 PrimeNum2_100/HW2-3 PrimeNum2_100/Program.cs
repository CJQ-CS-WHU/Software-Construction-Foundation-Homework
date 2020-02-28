using System;
using System.Collections.Generic;

namespace HW2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个2-100之间的数组
            List<int> list = new List<int>();
            for (int i = 2; i <= 100; i++)
                list.Add(i);
            //移除合数
            for (int i = 2; i <= 100 / 2; i++)
                for (int j = 2 * i; j <= 100; j += i)
                    list.Remove(j);
            //输出
            Console.Write("[");
            foreach (int item in list)
            {
                Console.Write("{0},", item);
            }
            Console.Write("\b]");
            Console.ReadKey();
        }
    }
}
