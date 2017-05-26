using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 4. 使用格式化字符串输出姓名、出生年月、血型、星座、最喜欢的食物

            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的出生年月：");
            string birth = Console.ReadLine();
            Console.WriteLine("请输入你的血型：");
            string bloodType = Console.ReadLine();
            Console.WriteLine("请输入你的星座：");
            string constellation = Console.ReadLine();
            Console.WriteLine("请输入你喜欢吃的食物：");
            string food = Console.ReadLine();

            Console.WriteLine(string.Format("姓名：{0}\n出生年月：{1}\n血型：{2}\n星座：{3}\n喜欢吃的食物：{4}",name,birth,bloodType,constellation,food));

            Console.ReadKey();

            #endregion
        }
    }
}
