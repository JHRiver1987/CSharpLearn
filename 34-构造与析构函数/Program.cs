using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_构造与析构函数
{
    class Line
    {
        private double length;   // 线条的长度
        public Line()  // 构造函数
        {
            Console.WriteLine("调用构造函数");
        }
        ~Line() //析构函数
        {
            Console.WriteLine("调用析构函数");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
