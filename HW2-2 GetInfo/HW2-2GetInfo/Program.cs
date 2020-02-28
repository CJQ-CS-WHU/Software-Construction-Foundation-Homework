using System;
/*
2.编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
*/
namespace HW2_2GetInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            int min;
            double ave;
            //测试数据
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //计算
            GetInf(array, out max, out min, out ave);
            //输出
            Console.WriteLine("最大值：\t" + max + "\n最小值：\t" + min + "\n平均值：\t" + ave + "\n");
            Console.ReadKey();
        }
        //综合求值
        public static void GetInf(int[] array, out int max, out int min, out double average)
        {
            max = GetMax(array);
            min = GetMin(array);
            average = GetAverage(array);
        }
        //求最大值
        public static int GetMax(int[] array)
        {
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            return array[maxIndex];
        }
        //求最小值
        public static int GetMin(int[] array)
        {
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < array[minIndex])
                    minIndex = i;
            return array[minIndex];
        }
        //求平均值
        public static double GetAverage(int[] array)
        {
            int sum = 0;
            int ave = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            ave = sum / array.Length;
            return ave;
        }
    }
}
