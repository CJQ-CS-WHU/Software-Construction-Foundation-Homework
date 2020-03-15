using System;

namespace HW3_Graphic_Object
{
    //三角形
    class Triangle : Graph
    {
        private double s1, s2, s3;
        //三参数构造函数
        public Triangle(double s1, double s2, double s3)
        {
            this.s1 = s1; this.s2 = s2; this.s3 = s3;
            if (!IsLegal())
                throw new Exception();
        }
        //判断合法性
        public override bool IsLegal() =>
            (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1 && s1 > 0 && s2 > 0 && s3 > 0);

        public override double GetArea()
        {
            double p = 1.0 / 2 * (s1 + s2 + s3);
            return Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
        }
    }

}
