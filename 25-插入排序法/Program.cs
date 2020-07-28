using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_插入排序法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 30,12,56,212,45,787,21,65 };
            InsertSort(number);

            Console.WriteLine("使用插入排序法对数组{130,28,345,299,40,30,201}进行从低到高排序：");
            foreach(int item in number)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("排序完毕！");
            Console.ReadKey();
        }

        private static void InsertSort(int[] args)
        {
            for(int i=1;i<args.Length;i++)
            {
                int insertVal = args[i];        //首先记住这个预备要插入的数
                int insertIndex = i - 1;        //找到它前一个数的下标

                //如果这个条件满足，说明还没有找到适当的位置
                while (insertIndex >= 0&&insertVal<args[insertIndex])
                {
                    args[insertIndex + 1] = args[insertIndex];
                    insertIndex--;
                }

                //插入
                args[insertIndex + 1] = insertVal;
            }
        }
    }
}
