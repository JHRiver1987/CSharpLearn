using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _14_RSA加密
{
    class Program
    {

        public static CspParameters cspParameters;

        static void Main(string[] args)
        {
            Console.WriteLine("注册名称：");
            string name = Console.ReadLine();
            Console.WriteLine("注册密码：");
            string pass = Console.ReadLine();
            if(name != string.Empty && pass != string.Empty)
            {
                string data = RsaEncrypt(pass);
                Console.WriteLine("恭喜您，注册成功，请牢记用户名和密码。");
                Console.WriteLine("密码加密结果：{0}",data);
                Console.WriteLine("密码解密结果：{0}",RsaDesEncrypt(data));
            }
            else
            {
                Console.WriteLine("很抱歉，注册失败！");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 对字符串的RSA加密
        /// </summary>
        /// <param name="str">预加密字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string RsaEncrypt(string str)
        {
            cspParameters = new CspParameters();
            cspParameters.KeyContainerName = "Olive";       //密钥容器的名字，保持加密解密一致才能解密成功。
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspParameters))
            {
                byte[] plaindata = Encoding.Default.GetBytes(str);  //将要加密的字符串转换成字节数组
                byte[] encryptdata = rsa.Encrypt(plaindata,false);  //将加密后的数据转换为新的加密字节数组
                string data = Convert.ToBase64String(encryptdata);  //将加密后的字节数组转换成字符串
                return data;
            }
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="str">预解密字符串</param>
        /// <returns>解密后的字符串</returns>
        public static string RsaDesEncrypt(string str)
        {
            cspParameters = new CspParameters();
            cspParameters.KeyContainerName = "Olive";
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspParameters))
            {
                byte[] encryptdata = Convert.FromBase64String(str);
                byte[] decryptdata = rsa.Decrypt(encryptdata, false);
                string data = Encoding.Default.GetString(decryptdata);
                return data;
            }
        }
    }
}
