using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_继承
{
    //基类
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;    //protected，派生类可访问
        protected int height;
    }

    // 派生类
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}
