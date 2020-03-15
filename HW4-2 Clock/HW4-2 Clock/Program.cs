using System;
using System.Threading;

namespace HW4_2_Clock
{
    //定义事件处理函数格式（委托）
    public delegate void ClockHandler(object sender,int Time);
    class Clock 
    {
        //定义时钟信号事件
        public event ClockHandler Tick;
        //定义闹钟事件
        public event ClockHandler Alarm;
        //时间
        public int Time { get; set; }
        //定义运行函数
        public void run() 
        {
            Console.WriteLine("clock start to run.");
            for (Time = 1; Time <= 100; Time++)
            {
                //每一秒钟广播一个Tick事件
                Tick(this, Time);
                //每过十秒钟广播一个Alarm事件
                if (Time % 10 == 0)
                    Alarm(this, Time);
                //线程休眠
                Thread.Sleep(1);
            }
            Console.WriteLine("clock is power off.");
        }
    }

    class User
    {
        //为了能使得User能够接受到clock的信号，clock必须是User的属性
        public Clock clock;
        //在user构造函数中就设定了事件处理函数，基因啊
        public User(Clock clock)
        {
            /*
             * 其实事件本身就是一个代理，所以能容纳函数
             * 所以事件一发生，马上就能跳转到对应的事件处理函数上去执行
             * 在User类中添加了Clock的代理，则表明User的对象总是会相应Clock的某个事件，User是监听者
             */
            clock.Alarm += OnAlarm;
            clock.Tick += OnTick;
        }

        public void OnAlarm(object sneder, int Time)
        {
            Console.WriteLine(Time+" Bi~bi~bi`bi`");
        }

        public void OnTick(object sender, int Time)
        {
            Console.WriteLine(Time +" di~ ");
        }
    }
    delegate int func(int u);
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            User user1 = new User(clock);
            User user2 = new User(clock);
            clock.run();
        } 
    }
}
