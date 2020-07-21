using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Equlas比较字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "HELLO C#";
            string strB = "hello c#";
            string strC = "Hi C#";
            Console.WriteLine("{0}和{1}比较的结果为：{2}" , strA,strB,strA.Equals(strB));
            Console.WriteLine("{0}和{1}比较的结果为：{2}" , strA, strC, string.Equals(strA,strC));
            Console.ReadKey();
        }
    }
}
