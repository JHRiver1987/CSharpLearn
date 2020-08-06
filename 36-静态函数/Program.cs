using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_静态函数
{
    class StaticVar
    {
        public static int num;          //因为getNum()被定义为静态函数，它要访问num成员，所以num必须是静态的。
        public void count()
        {
            num++;
        }
        public static int getNum()      //定义了一个静态函数，这样的函数只能访问静态变量。静态函数在对象被创建之前就已经存在。
        {
            return num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("变量 num： {0}", StaticVar.getNum());
            Console.ReadKey();
        }
    }
}
