﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 10.将字符串“-index0-index1-index2-”截头去尾。

            string str = "-index0-index1-index2-";
            //去除字符串来两端的内容
            string s= str.Trim('-');
            Console.WriteLine(s);
            Console.ReadKey();

            #endregion
        }
    }
}
