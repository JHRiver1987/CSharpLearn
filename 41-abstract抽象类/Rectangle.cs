using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_abstract抽象类
{
    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }

        public override int area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * length);
        }
    }
}
