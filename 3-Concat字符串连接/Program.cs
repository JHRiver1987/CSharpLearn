using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Concat字符串连接
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "西游记\n","红楼梦\n","水浒传\n","三国演义\n"};
            Console.WriteLine(string.Concat(s));
            string str = String.Concat("C#编程","Java编程","JavaScript编程","PHP编程");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
