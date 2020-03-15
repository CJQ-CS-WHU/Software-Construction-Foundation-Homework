using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        //定义遍历函数，遍历操作为act
        public void Foreach(Action<T> act)
        {
            Node<T> node = head;
            while (node != null)
            {
                act(node.Data);
                node = node.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 定义整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)intlist.Add(x);
            //定义输出委托：输出一个值
            Action<int> printf = item => Console.WriteLine(item);
            //定义求和委托：将item加到sum中
            int sum = 0;
            Action<int> getSum = item => sum += item;
            //定义求最大值委托：取max和item中的较大值
            int max = intlist.Head.Data;
            Action<int> getMax = item => { if (item > max) max = item; };

            //遍历求和
            intlist.Foreach(getSum);
            //遍历求最大
            intlist.Foreach(getMax);

            //输出结果
            intlist.Foreach(printf);
            Console.WriteLine(sum);
            Console.WriteLine(max);
        }
    }
}