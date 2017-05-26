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
         
            //吧字符串进行分割
            string[] st = str.Split('、');
            //使用string的静态方法Concat把分割的字符串拼接起来
            string s1 = string.Concat(st);
            //使用string的静态方法Join把分割的字符串拼接起来
            string s2 = string.Join("",st);

            //创建StringBuilder实例
            StringBuilder sb = new StringBuilder();

            //遍历数组中的内容
            for (int i = 0; i < st.Length; i++)
            {
                //把内容添加到sb中
                sb.Append(st[i]);
            }

            Console.WriteLine(s1);
           Console.WriteLine(s2);
           Console.WriteLine(sb.ToString());
        }
    }
}
