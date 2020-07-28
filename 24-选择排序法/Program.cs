using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_选择排序法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 130, 28, 345, 299, 40, 30, 201 };

            Console.WriteLine("使用选择排序法对数组{130,28,345,299,40,30,201}进行从低到高排序：");
            SelectSort(number);
            Console.WriteLine("排序完毕！");
            Console.ReadKey();
        }

        private static void SelectSort(int[] args)
        {
            int temp = 0;
            for(int i=0;i<args.Length-1;i++)
            {
                int minVal = args[i];       //假设i下标就是最小的数
                int minIndex = i;           //记录认为最小的数的下标
                for(int j=i+1;j<args.Length;j++)    //只找出这一趟最小的数值，并记录它的下标
                {
                    if(minVal>args[j])
                    {
                        minVal = args[j];
                        minIndex = j;
                    }
                }
                temp = args[i];             //把第一个原来认为是最小的那个数临时保存一下
                args[i] = args[minIndex];   //把最终找到的最小值赋给这一趟比较的第一个位置
                args[minIndex] = temp;      //把原来保存好的临时数值放回该数组的空地方，保证数组的完整性
            }
            foreach(int item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}
