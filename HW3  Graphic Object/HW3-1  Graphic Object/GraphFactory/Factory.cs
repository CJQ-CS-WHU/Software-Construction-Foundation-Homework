using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_Graphic_Object
{
    class Factory
    {
        public static Graph getGraph(string type,params double[] arr)
        {
            if (type == "Triangle"&&arr.Length==3)
                return new Triangle(arr[0],arr[1],arr[2]);
            if (type == "Rectangle"&&arr.Length==2)
                return new Rectangle(arr[0],arr[1]);
            if (type == "Square"&&arr.Length==1)
                return new Square(arr[0]);
            throw new System.Exception();
        }
    }
}
