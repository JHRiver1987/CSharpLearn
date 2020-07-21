using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Trim去空格
{
    class Program
    {
        static void Main(string[] args)
        {
            string loveHobby = "  唱歌 | 跳舞 | 爬山  ";
            Console.WriteLine("原字符串：" + loveHobby);
            Console.WriteLine("原字符串长度：" + loveHobby.Length);
            Console.WriteLine("去除空格后：" + loveHobby.Trim());
            Console.WriteLine("去除空格后字符串长度：" + loveHobby.Trim().Length);
            Console.ReadKey();

            Console.WriteLine("去除首部空格后：" + loveHobby.TrimStart());
            Console.WriteLine("长度为：" + loveHobby.TrimStart().Length);
            Console.WriteLine("去除尾部空格后：" + loveHobby.TrimEnd());
            Console.WriteLine("长度为：" + loveHobby.TrimEnd().Length);
            Console.ReadKey();
        }
    }
}
