using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_静态成员
{
    class StaticVar
    {
        public static int num;          //定义一个静态成员变量,意味着无论有多少个类的对象被创建，只会有一个该静态成员的副本。
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}
