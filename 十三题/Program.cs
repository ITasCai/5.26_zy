using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十三题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 13．将字符串welcome to jining 转为字符数组。

            string str = "welcome to jining";
            //把字符串转换为字符数组
            char[] ch = str.ToCharArray();
            foreach (char item in ch)
            {
                Console.Write(item+" ");

            }

            Console.ReadKey();
            #endregion
        }
    }
}
