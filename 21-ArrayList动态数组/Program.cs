using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ArrayList动态数组
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add('我');
            myList.Add("集合");
            myList.Add(50.5);

            myList.Insert(0, "小明");

            string[] str = { "张三", "李四", "王五", "赵六" };
            // AddRange() 可用于一次添加多个元素,可以直接添加数组!
            myList.AddRange(str);

            Console.WriteLine("删除前共有{0}个元素", myList.Count);
            foreach (object obj in myList)
            {
                Console.Write(obj + "\t");
            }


            //RemoveRange(索引,删除的个数)、Remove(值)、RemoveAt(索引值)
            myList.RemoveRange(4, 3);
            Console.WriteLine("\n删除后共有{0}个元素", myList.Count);
            foreach (object obj in myList)
            {
                Console.Write(obj + "\t");
            }


            //Clear() 清空所有元素
            myList.Clear();
            Console.WriteLine("\n清空后共有{0}个元素", myList.Count);
            foreach (object obj in myList)
            {
                Console.Write(obj + "\t");
            }


            Console.ReadKey();
        }
    }
}
