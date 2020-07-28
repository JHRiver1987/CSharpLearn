using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_冒泡排序法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] {130,28,345,299,40,30,201 };
            Console.WriteLine("对数组{130,28,345,299,40,30,201}进行从低到高排序：");
            BubbleSort(number);
            Console.WriteLine("排序完毕！");
            Console.ReadKey();
        }

        private static void BubbleSort(int[] arg)
        {
            for(int i=1;i<arg.Length;i++)           //外层循环，每次把参与排序的最大数排在最后
            {
                int temp = 0;   //临时变量
                for(int j=0;j<arg.Length-i;j++)       //内层循环，负责对比相邻的两个数，并把最大的排在后面
                {
                    if(arg[j] > arg[j+1])           //如果前一个数大于后一个数，则交换两个数
                    {
                        temp = arg[j + 1];
                        arg[j + 1] = arg[j];
                        arg[j] = temp;
                    }
                }
            }
            for(int k=0;k<arg.Length;k++)           //用一个循环访问数组里的元素并打印
            {
                Console.WriteLine(arg[k]);
            }
        }
    }
}
