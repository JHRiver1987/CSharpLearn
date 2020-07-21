using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Replace替换字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "我最喜欢的一句话是：生活如酒，或芳香，或浓烈，因为诚实，它变得醇厚；生活如歌，高昂，或低沉，因为守信，它变得悦耳；生活如画，或明丽，或素雅，因为诚信，它变得美丽。";
            Console.WriteLine("原来的字符串是：\n" + words);
            string newWords = words.Replace('我','I').Replace("生活","<生活Life>");
            Console.WriteLine("\n替换后的字符串是：\n" + newWords);
            Console.ReadKey();
        }
    }
}
