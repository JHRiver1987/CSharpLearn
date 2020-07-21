using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ToUpper转换大小写
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldStr = "我最喜欢的英语名言：Living without an aim is like sailing without a compass";
            string lowerStr = oldStr.ToLower();
            string upperStr = oldStr.ToUpper();
            Console.WriteLine("原字符串：" + oldStr);
            Console.WriteLine("转换小写：" + lowerStr);
            Console.WriteLine("转换大写：" + upperStr);
            Console.ReadKey();
        }
    }
}
