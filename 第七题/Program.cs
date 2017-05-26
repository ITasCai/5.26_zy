using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 7.使用字符串格式化函数将123.5678格式化为货币形式和浮点数类型。
            string str = "123.5678";
            double hb = Convert.ToDouble(str);
            Console.WriteLine(hb);
            Console.WriteLine(string.Format("{0:c}", hb));

            Console.ReadKey();
            #endregion
        }
    }
}
