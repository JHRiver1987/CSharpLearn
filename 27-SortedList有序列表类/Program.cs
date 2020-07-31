using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_SortedList有序列表类
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortList = new SortedList();
            sortList.Add(1, "小张");
            sortList.Add(2, "小李");
            sortList.Add(3, "小刘");
            Console.WriteLine("请输入挂号编号：");
            int id = int.Parse(Console.ReadLine());
            bool flag = sortList.ContainsKey(id);
            if (flag)
            {
                string name = sortList[id].ToString();
                Console.WriteLine("您查找的患者姓名为：{0}", name);
            }
            else
            {
                Console.WriteLine("您查找的挂号编号不存在！");
            }
            Console.WriteLine("所有的挂号信息如下：");
            foreach (DictionaryEntry d in sortList)
            {
                int key = (int)d.Key;
                string value = d.Value.ToString();
                Console.WriteLine("挂号编号：{0}，姓名：{1}", key, value);
            }

            Console.ReadKey();
        }
    }
}
