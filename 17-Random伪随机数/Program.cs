using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Random伪随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for(int i=0;i<10;i++)
            {
                int num = random.Next(10,99);
                Console.WriteLine("生成10-100之间的随机数：{0}",num);
            }
            Console.ReadKey();

            double d1 = random.NextDouble();        //生成[0，1.0]区间的小数
            double d2 = random.NextDouble() * 7;    //生成[0，7.0]区间的小数
            int i1 = random.Next(10);               //生成[0，10]区间的整数
            int i2 = random.Next(18) - 3;           //生成[-3，15]区间的整数
        }
    }
}
