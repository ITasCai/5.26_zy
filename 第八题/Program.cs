using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 8.使用Random模拟福利彩票从1-36中36选7，每一个数都不能重复，要求使用方法，返回数组，并输出。

            Console.WriteLine("请输入一个最小值：");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入一个最大值：");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你要获取元素的个数：");
            int count = Convert.ToInt32(Console.ReadLine());

            GetShow(min, max, count);
            Console.ReadKey();


            #endregion
        }

        /// <summary>
        /// 一个随机数的方法
        /// </summary>
        /// <param name="min">最小数</param>
        /// <param name="max">最大数</param>
        /// <param name="count">多少个</param>
        private static void GetShow(int min, int max, int count)
        {
            //用于存放产生的随机数
            List<int> list = new List<int>();

            //产生随机数的方法
            Random random = new Random();
         
            //给集合定义一个空间
            for (int i = 0; i < count; i++)
            {
                //随机数的范围
                int temp = random.Next(min, max);
                //如果集合中没有相同的元素，进行添加
                if (!list.Contains(temp))
                {
                    //添加随机数
                    list.Add(temp);
                }

            }

            //遍历集合中的内容
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+ " ");
            }

        }
    }
}
