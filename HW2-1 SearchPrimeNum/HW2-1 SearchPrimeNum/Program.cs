using System;
using System.Collections.Generic;

namespace HW2_1_SearchPrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = ReadInt();
            List<int> list = GetPrimeNum(num);
            Output(list);
            Console.ReadKey();
        }

        //读取数据
        public static int ReadInt()
        {
            int num = 0;
            Console.WriteLine("请输入一个整数：");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out num);
                return num;
            }
        }

        //计算
        public static List<int> GetPrimeNum(int num)
        {
            //排除异常
            if (num == 0 || num == 1)
            {
                Console.WriteLine("没有质因子.");
                return null;
            }
            //计算
            List<int> list = new List<int>();
            for (int dev = 2; num != 1; dev++)
            {
                if (num % dev == 0)
                    list.Add(dev);
                while (num % dev == 0)
                    num /= dev;
            }
            return list;
        }

        //输出
        static void Output(List<int> list)
        {
            Console.Write("[");
            foreach (int item in list)
                Console.Write(" {0}", item);
            Console.Write("]");
        }
    }
}
