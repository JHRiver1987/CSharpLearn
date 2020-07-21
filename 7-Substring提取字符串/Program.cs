using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Substring提取字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            String day = "0123 4567 89AB";
            Console.WriteLine("Substring提取字符串(0)结果：" + day.Substring(0));
            Console.WriteLine("Substring提取字符串(2)结果：" + day.Substring(2));
            Console.WriteLine("Substring提取字符串(10)结果：" + day.Substring(10));
            Console.WriteLine("Substring提取字符串(1,6)结果：" + day.Substring(1,6));
            Console.WriteLine("Substring提取字符串(0,7)结果：" + day.Substring(0,7));
            Console.ReadKey();
        }
    }
}
