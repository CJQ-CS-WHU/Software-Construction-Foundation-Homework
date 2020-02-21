using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量定义
            double result = 0;
            double num1 = 1;
            double num2 = 1;
            Char c=' ';
            //变量输入
            try
            {
                Console.WriteLine("Please input first number:");
                num1= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input second number:");
                num2= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input +-*/");
                c = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input format is error.");
            }
            catch (OverflowException) {
                Console.WriteLine("Number is overflow.");
            }
            //计算
            try
            {
                switch (c)
                {
                    case '+': result = num1 + num2; break;
                    case '*': result = num1 * num2; break;
                    case '-': result = num1 - num2; break;
                    case '/':
                        {
                            if (num2 == 0)
                                Console.WriteLine("Divisor is zero.");
                            else
                                result = num1 / num2;
                        }
                        break;
                    default: Console.WriteLine("Error."); break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error.");
            }
            //结果输出
            Console.WriteLine("Reasule is " + result);
            Console.ReadKey();
        }
    }
}
