using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二十题
{
    /// <summary>
    /// 电话本系统的功能类
    /// </summary>
    class Function
    {

        /// <summary>
        /// 定义一个集合，用于存放用户的基本信息
        /// </summary>
       public static ArrayList list = new ArrayList();

        /// <summary>
        /// 电话本系统的添加方法
        /// </summary>
        public static void Add() {

            Console.WriteLine("请输入用户的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入用户的电话号码：");
            string phone = Console.ReadLine();
            Customer c = new Customer(name,phone);
            list.Add(c);
            Console.WriteLine("添加成功！");


        }

        /// <summary>
        /// 电话本系统的查询方法
        /// </summary>
        public static void  Query() {

            foreach (Customer item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
