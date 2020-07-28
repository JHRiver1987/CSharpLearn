using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_DateTime日期处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "    ";
            Console.WriteLine("请输入年份：");
            int nYear = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入月份：");
            int nMonth = int.Parse(Console.ReadLine());
            DateTime day1 = new DateTime(nYear,nMonth,1);

            int week1 = (int)day1.DayOfWeek;                        //获取该月第一天是星期几
            int lastDay = day1.AddMonths(1).AddDays(-1).Day;        //获取该月最后一天

            Console.WriteLine("{0}/{1}",day1.Year,day1.Month);
            Console.WriteLine("日  一  二  三  四  五  六");
            for(int i = 0; i < week1; i++)
            {
                Console.Write(s);
            }
            for(int i = 1; i <= lastDay; i++)
            {
                Console.Write("{0:00}  ",i);      //按01  02格式输出
                if((i + week1) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("按任意键退出...");
            Console.ReadKey();
        }
    }
}
