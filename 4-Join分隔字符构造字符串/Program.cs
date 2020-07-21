using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Join分隔字符构造字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hobby = { "唱歌","跳舞","运动","游泳" };
            string newStr = string.Join("\n",hobby);
            Console.WriteLine(newStr);
            Console.ReadKey();

            Console.WriteLine(" ");
            string str2 = string.Join("\n",hobby,1,2);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
