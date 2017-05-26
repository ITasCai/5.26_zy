using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十六题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 16.将字符串“2017-02-14”转化为日期类型。

            string date = "2017-02-14";
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine(dt);
            Console.ReadKey();


            #endregion
        }
    }
}
