using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _13_MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("注册名称：");
            string name = Console.ReadLine();
            Console.WriteLine("注册密码：");
            string pass = Console.ReadLine();
            if(name != string.Empty && pass != string.Empty)
            {
                string data = Md5Encrypt(pass);
                Console.WriteLine("恭喜您，注册成功，请牢记用户名的密码。");
                Console.WriteLine("已经对密码采取MD5加密，加密后的结果为：{0}",data);
            }
            else
            {
                Console.WriteLine("很抱歉，注册失败！");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// MD5加密方法
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <returns>进行MD5加密后的字符串</returns>
        public static string Md5Encrypt(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(str);  //将要加密的字符串转换成字节数组
            byte[] encryptData = md5.ComputeHash(palindata);    //将字符串加密后也转换成字节数组
            string returnData = Convert.ToBase64String(encryptData);    //将加密后的字节数组转换成加密字符串
            return returnData;
        }
    }
}
