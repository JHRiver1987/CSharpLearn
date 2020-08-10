using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Implementer implementer = new Implementer();
            implementer.Method1();
            implementer.Method2();
            Console.ReadKey();
        }
    }
}
