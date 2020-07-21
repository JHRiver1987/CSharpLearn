using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15_Regex正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for(int i=0;i<10;i++)
            {
                double m = random.Next() / 100.0;
                Console.WriteLine(m + "\t大写\t" + ConvertToChineseMoney(m));
                Console.ReadKey();
            }
        }

        /// <summary>
        /// 小写数字转人民币大写
        /// </summary>
        /// <param name="money">小写数字</param>
        /// <returns>人民币大写</returns>
        public static string ConvertToChineseMoney(double money)
        {
            if (money < 0)
                throw new ArgumentOutOfRangeException("参数 money 不能为负值！");
            string s = money.ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");
            s = Regex.Replace(s,@"((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z')[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))","${b}${z}");
            return Regex.Replace(s,".",
                delegate(Match m) {
                    return "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[m.Value[0] - '-'].ToString();
                });
        }
    }
}
