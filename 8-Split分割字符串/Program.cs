using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Split分割字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string colors = "Blue,Yellow,Orange,White,Green";
            string[] arr1 = colors.Split(',');
            string[] arr2 = colors.Split(new char[] { ','},3);
            Console.WriteLine("所有颜色为：");
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();


            Console.WriteLine("前三个颜色为：");
            for(int j=0;j<arr2.Length;j++)
            {
                Console.WriteLine(arr2[j]);
            }
            Console.ReadKey();
        }
    }
}
