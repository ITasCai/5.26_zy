using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 9.将字符串(one、two、three、four、five)通过静态方法Concat、静态方法Join和实例方法StringBuilder.Append连接成字符串。

            string str = "one、two、three、four、five";

            GetStr(str);

            Console.ReadKey();
            #endregion
        }

        private static void GetStr(string str)
        {
            string[] st = str.Split('、');
            string s1= string.Concat("",st);
            //string s2 = string.Join("",st);
            StringBuilder sb = new StringBuilder();
            
            Console.WriteLine(s1);
          //  Console.WriteLine(s2);
           // Console.WriteLine(sb.Append(st));
        }
    }
}
