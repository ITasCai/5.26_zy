using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十九题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 19.使用ArraList添加元素Monday、Wednesday、Thursday 、Friday  、Saturday、Sunday，并将Tuesday插入到ArrayList中，对。分别使用for和foreach循环遍历输出元素。
            //创建 ArrayList集合
            ArrayList list = new ArrayList();
            //添加
            list.Add("Monday");
            list.Add("Wednesday");
            list.Add("Thursday");
            list.Add("Friday");
            list.Add("Saturday");
            list.Add("Sunday");
           // 插入
            list.Insert(3,"Tuesday");

            //遍历集合中的内容
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
            //遍历集合中的内容
            foreach (string item in list)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();

            #endregion
        }
    }
}
