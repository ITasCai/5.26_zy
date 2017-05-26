using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._26_zy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.提取邮箱的用户名（如:zhangsan@163.com）

            Console.WriteLine("输入一个邮箱:");
            string eMail = Console.ReadLine();

            GetSubstring(eMail);

           
            #endregion
        }

        /// <summary>
        /// 用于对字符串的截取
        /// </summary>
        /// <param name="eMail">输入的字符串</param>
        private static void GetSubstring(string eMail)
        {
            //存储字符@的索引
            int index = 0;
            //把字符串转换为字符数组
            char[] ch = eMail.ToCharArray();
            //遍历字符数组
            for (int i = 0; i < ch.Length; i++)
            {
                //如果字符中的某个字符为@，获得@的索引位置
                if (ch[i] == '@')
                {
                    index = i;
                }
            }
            //截取从开始到@位置的字符串
            string username = eMail.Substring(0, index);
            Console.WriteLine(username);
            Console.ReadKey();
        }
    }
}
