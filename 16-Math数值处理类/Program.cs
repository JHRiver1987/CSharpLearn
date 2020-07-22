using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Math数值处理类
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10和20相比，比较大的是{0},比较小的是{1}",Math.Max(10,20),Math.Min(10,20));
            Console.ReadKey();
            Console.WriteLine("-50的绝对值是{0}",Math.Abs(-50));
            Console.ReadKey();

            double price1 = 12.4, price2 = 13.6, price3 = 15.0;
            Console.WriteLine("{0}的最小整数值：{1}",price1,Math.Ceiling(price1));
            Console.WriteLine("{0}的最小整数值：{1}", price2, Math.Ceiling(price2));
            Console.WriteLine("{0}的最小整数值：{1}", price3, Math.Ceiling(price3));
            Console.ReadLine();

            Console.WriteLine("{0}的最大整数值：{1}", price1, Math.Floor(price1));
            Console.WriteLine("{0}的最大整数值：{1}", price2, Math.Floor(price2));
            Console.WriteLine("{0}的最大整数值：{1}", price3, Math.Floor(price3));
            Console.ReadLine();

            Console.WriteLine("{0}的最接近的整数值：{1}", price1, Math.Round(price1));
            Console.WriteLine("{0}的最接近的整数值：{1}", price2, Math.Round(price2));
            Console.WriteLine("{0}的最接近的整数值：{1}", price3, Math.Round(price3));
            Console.ReadLine();

            Console.ReadKey();

            Console.WriteLine("90度的正弦值：" + Math.Sin(Math.PI / 2));
            Console.WriteLine("30度的余弦值：" + Math.Cos(Math.PI / 6));
            Console.WriteLine("45度的正切值：" + Math.Tan(Math.PI / 4));
            Console.ReadKey();

            Console.WriteLine("123456789与123456789的乘积是：{0}", Math.BigMul(123456789,123456789));
            Console.WriteLine("4的3次方：{0}", Math.Pow(4,3));
            Console.WriteLine("16的平方根：{0}", Math.Sqrt(16));
            Console.WriteLine("14.6的整数部分：{0}", Math.Truncate(14.6));
            Console.ReadKey();
        }
    }
}
