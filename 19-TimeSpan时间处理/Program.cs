using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19_TimeSpan时间处理
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime timeEnd = DateTime.Now.AddSeconds(60);     //在当前时间基础上加60秒
                ThreadPool.QueueUserWorkItem((arg)=> {
                    TimeSpan timeSpan = timeEnd - DateTime.Now;
                    while (true)
                    {
                        Thread.Sleep(1000);
                        if(timeSpan.TotalSeconds >= 0)
                        {
                            Console.WriteLine("还剩余{0}分钟{1}秒",timeSpan.Minutes,timeSpan.Seconds);
                            timeSpan = timeSpan.Add(new TimeSpan(0,0,-1));
                        }
                    }
                });
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
