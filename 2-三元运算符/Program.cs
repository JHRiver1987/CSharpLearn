using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请随便输入一个整数：");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = (number >= 10 ? "您输入的数字大于等于10" : "您输入的数字小于10");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
