using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_Graphic_Object
{

    class Rectangle : Graph
    {
        private double width;
        private double Width
        {
            get => width;
            set
            {
                if (value > 0)
                    width = value;
                else
                    throw new Exception();
            }
        }

        private double length;
        public double Length
        {
            get => length;
            set
            {
                if (value > 0)
                    length = value;
                else
                    throw new Exception();
            }
        }

        //双参数构造方法
        public Rectangle(double le, double se)
        {
            if (le > 0 && se > 0)
            {
                this.Length = le;
                this.Width = se;
            }
            else
                throw new Exception();
        }

        //判断合法性
        public override bool IsLegal() => Length > 0 && Width > 0;

        //获取面积
        public override double GetArea() => Length * Width;
    }
}
