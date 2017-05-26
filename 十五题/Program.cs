using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十五题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 15.已知圆的半径为3.5求圆的面积和周长。并保留两位小数。

            double r = 3.5;

            //圆的面积
            GetArea(r);
            //圆的周长
            GetPerimeter(r);


            Console.ReadKey();

            #endregion
        }

        /// <summary>
        /// 求圆的周长
        /// </summary>
        /// <param name="r">半径</param>
        private static void GetPerimeter(double r)
        {
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("圆的周长为：{0:f2}",perimeter);
        }

        /// <summary>
        /// 求圆的面积
        /// </summary>
        /// <param name="r">半径</param>
        private static void GetArea(double r)
        {
            double area = Math.PI * (r*r);
            Console.WriteLine("圆的面积为:{0:f2}",area);
        }
    }
}
