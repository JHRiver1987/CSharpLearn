using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Hashtable类
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "计算机基础");
            hashtable.Add(2, "C#高级编程");
            hashtable.Add(3, "数据库应用");

            Console.WriteLine("请输入图书编号：");

            int id = int.Parse(Console.ReadLine());
            bool flag = hashtable.ContainsKey(id);
            if (flag)
            {
                Console.WriteLine("您查找的图书名称为：{0}", hashtable[id].ToString());
            }
            else
            {
                Console.WriteLine("您查找的图书编号不存在！");
            }
            Console.WriteLine("所有的图书信息如下：");
            foreach (DictionaryEntry d in hashtable)
            {
                int key = (int)d.Key;
                string value = d.Value.ToString();
                Console.WriteLine("图书编号：{0}，图书名称：{1}", key, value);
            }

            Console.ReadKey();
        }
    }
}
