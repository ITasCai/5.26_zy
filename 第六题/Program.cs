﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 6. 产生0-9之间的随机数作为中奖号，从控制台输入你猜测的中奖号，3次内若有一次猜对，打印输出“恭喜您，中奖啦”，退出游戏，若3次内都没猜对打印”谢谢参与”，也退出游戏。


            while (true)
            {
                Console.WriteLine("请输入一个数（0--9）：");
                int num = Convert.ToInt32(Console.ReadLine());
                GetRandom(num);
            }
               
           

            #endregion
        }

        /// <summary>
        /// 用于对随机数的判断
        /// </summary>
        /// <param name="num"></param>
        private static void GetRandom(int num)
        {
            int i = 0;
            Random r = new Random();
            int sj = r.Next(0, 9);
            for ( i = 0; i < 3; i++)
            {
             
                if (sj == num)
                {
                    Console.WriteLine("恭喜您，中奖啦");
                    Environment.Exit(0);

                } 
                   
            }   
            Console.WriteLine("谢谢参与");
            if (i >= 3)
            {
                return;
            }
        }
    }
}
