using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_快速排序法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 130, 28, 345, 299, 40, 30, 201 };
            int low = 0;
            int high = number.Length - 1;
            QuickSort(number,low,high);

            Console.WriteLine("使用快速排序法对数组{130,28,345,299,40,30,201}进行从低到高排序：");
            foreach(int item in number)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("排序完毕！");
            Console.ReadKey();
        }

        private static void QuickSort(int[] R,int low,int high)
        {
            int pivotLoc = 0;
            if(low<high)
            {
                pivotLoc = Partition(R,low,high);
                QuickSort(R,low,pivotLoc-1);
                QuickSort(R,pivotLoc+1,high);
            }
        }

        private static int Partition(int[] R,int low,int high)
        {
            int temp = R[low];
            while(low < high)
            {
                while(low<high&&temp<=R[high])
                {
                    high--;
                }
                R[low] = R[high];
                while(low<high&&temp>=R[low])
                {
                    low++;
                }
                R[high] = R[low];
            }
            R[low] = temp;

            return low;
        }
    }
}
