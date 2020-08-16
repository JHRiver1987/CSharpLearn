using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_接口
{
    class Implementer : IMyInterface1, IMyInterface2
    {
        public void Method1()
        {
            Console.WriteLine("调用了Method-1。");
        }

        public void Method2()
        {
            Console.WriteLine("调用了Method-2。");
        }
    }
}
