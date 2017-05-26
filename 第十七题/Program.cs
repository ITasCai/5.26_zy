using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十七题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 17．已知 一个整数123，和一个字符串“123”，比较并输出结果。

            int num = 123;
            string str = "123";
            
            Console.WriteLine(str.Equals(num));

            Console.ReadKey();

            #endregion
        }
    }
}
