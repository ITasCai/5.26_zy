using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3. 输入一个字符串，输出每个单词，重新用下划线连接输出


            Console.WriteLine("输入一个字符串：");
            string str = Console.ReadLine();

            GetShow(str);

            Console.ReadKey();
            #endregion
        }

        /// <summary>
        /// 用于对字符串分割，拼接
        /// </summary>
        /// <param name="str"></param>
        private static void GetShow(string str)
        {
            //把字符串用‘ ’分割，存储到字符串数组中
          string[] newStr =str.Split(' ');
            //把字符串数组中的内容用下划线拼接起来
           string s= string.Join("_",newStr);
            Console.Write(s);
           
        }
    }
}
