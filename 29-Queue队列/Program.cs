using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Queue队列
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            //向队列中加入3为购票人
            queue.Enqueue("小张1");
            queue.Enqueue("小李2");
            queue.Enqueue("小刘3");
            Console.WriteLine("购票开始：");
            //当队列中没有人时购票结束
            while (queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue() + "已购票！");
            }
            Console.WriteLine("购票结束！");

            Console.ReadKey();
        }
    }
}
