using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十二题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 12.将“Hello world”转化为大写，然后将world替换为china。

            string str1 = "Hello world";
            //把字符串转换为大写
            string str2=str1.ToUpper();
            //替换字符串中的内容
            string str3 = str2.Replace("WORLD","china");
            Console.WriteLine(str3);

            Console.ReadKey();
            #endregion
        }
    }
}
