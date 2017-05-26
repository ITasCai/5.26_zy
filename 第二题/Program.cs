using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2.将“x.y.txt”文件名的扩展名改为.dat。

            string strName = "x.y.txt";
            //把两个字符串进行交换
            string newName = strName.Replace("txt", "dat");
            Console.WriteLine(newName);
            Console.ReadKey();


      

            #endregion
        }
    }
}
