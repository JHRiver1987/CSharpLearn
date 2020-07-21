using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_定位字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string loveWords = "If you would go up high.";
            Console.WriteLine("原话：" + loveWords);
            Console.WriteLine("是否以If开头：" + loveWords.StartsWith("If"));
            Console.WriteLine("是否以If结尾：" + loveWords.EndsWith("If")) ;
            Console.ReadKey();

            Console.WriteLine("字母o在语句中第一次出现的索引位置是：" + loveWords.IndexOf("o"));
            Console.WriteLine("字母o在语句中最后一次出现的索引位置是：" + loveWords.LastIndexOf("o"));
            Console.ReadKey();

            char[] cs = new char[] {'y','o','d' };
            Console.WriteLine("字母y/o/a在语句中第一次出现的索引位置是：" + loveWords.IndexOfAny(cs));
            Console.ReadKey();
        }
    }
}
