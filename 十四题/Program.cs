using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十四题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 14.将9879.2675，保留两位小数，并实现四舍五入。

            double num = 9879.2675;

            //小数点后保留两位小数
            string str1 = String.Format("{0:f2}", num);

            Console.WriteLine(str1);

            Console.ReadLine();
            #endregion
        }
    }
}
