using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Stack堆栈
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            //向栈中存放元素
            stack.Push("1 号盘子");
            stack.Push("2 号盘子");
            stack.Push("3 号盘子");
            stack.Push("4 号盘子");
            stack.Push("5 号盘子");
            Console.WriteLine("取出盘子：");
            //判断栈中是否有元素
            while (stack.Count != 0)
            {
                //取出栈中的元素
                Console.WriteLine(stack.Pop());
            }

            Console.ReadKey();
        }
    }
}
