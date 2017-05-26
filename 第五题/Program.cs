using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5.输出当前系统时间格式为现在是{0}年{1}月{2}日{3}时{4}分{5}秒，并且使用if else判断输出早上好(<12)、下午好（>=12）、晚上好(>=18)。

            //获取系统的当前时间
            DateTime da = DateTime.Now;
            Console.WriteLine("系统的当前时间为：" + da.ToString("yyyy年MM月dd日  HH时mm分ss秒"));


    
            //获取当前吃的小时
            int newHour= da.Hour;

            //判断时间用于输出不同的内容
            if (newHour<12)
            {
                Console.WriteLine("早上好");
            }
            else if (newHour>=12)
            {
                Console.WriteLine("中午好");
            }
            else if (newHour>=18)
            {
                Console.WriteLine("晚上好");
            }
            Console.ReadKey();

            #endregion
        }
    }
}
