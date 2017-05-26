using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二十题
{
    /// <summary>
    /// 电话本系统的登录界面
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            #region 20.使用ArraList实现电话本功能。

            while (true)
            {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------欢迎来到简易电话本系统--------------");

            Console.WriteLine("  A:添加联系人     S：查看联系人    Q:退出系统");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("输入您要进行的操作：");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            switch (ch)
            {
                case 'A':
                    //添加
                    Function.Add();
                    break;
                case 'S':
                    //查询
                    Function.Query();
                    break;
                    //退出
                case 'Q':
                    return;
                default:
                    Console.WriteLine("输出有误，请重新输入！");
                    break;
              }
            }
            #endregion
        }
    }
}
