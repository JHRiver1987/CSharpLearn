using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("一袋大米多少钱？");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("请输入购买数量：");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("购买商品总价格为：" + (price*number));
            Console.ReadKey();
        }
    }
}
