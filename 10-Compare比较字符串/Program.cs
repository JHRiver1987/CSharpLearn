using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Compare比较字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "I Want To Go Shopping.";
            string strB = "i want to go shopping.";
            int result = string.Compare(strA,strB);
            Console.WriteLine("不带第三个参数的比较结果：" + result);
            int result1 = string.Compare(strA,strB,true);
            Console.WriteLine("第三个参数设为true的比较结果：" + result1);
            Console.ReadKey();
        }
    }
}
