using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// C# 不支持多重继承。但是可以使用接口来实现多重继承。
/// </summary>
namespace _39_多重继承
{
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
        protected int width;
        protected int height;
    }

    // 基类 PaintCost
    public interface PaintCost
    {
        int getCost(int area);

    }
    // 派生类
    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();
            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
            Console.WriteLine("油漆总成本： ${0}", Rect.getCost(area));
            Console.ReadKey();
        }
    }
}
