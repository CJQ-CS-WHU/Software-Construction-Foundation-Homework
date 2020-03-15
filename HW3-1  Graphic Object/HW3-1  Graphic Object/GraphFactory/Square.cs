using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_Graphic_Object
{
  //正方形：特殊的长方形
    class Square : Rectangle
    {
        //单参数构造函数
        public Square(double l) : base(l, l) { }

        //判断合法性
        public override bool IsLegal() => Length>0;

        //获取正方形面积
        public override double GetArea()=> Length * Length;
    }
}
