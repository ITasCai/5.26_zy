using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二十题
{
    /// <summary>
    /// 电话本系统的用户类
    /// </summary>
    class Customer
    {
        /// <summary>
        /// 姓名
        /// </summary>
        private string name;
        /// <summary>
        /// 电话
        /// </summary>
        private string phone;


        /// <summary>
        /// 用户类的一个有参数的构造方法，用于对数据的初始化
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="phone">年龄</param>
        public Customer(string name,string phone) {
            this.name = name;
            this.phone = phone;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        /// <summary>
        /// 重新tostring方法用于对数据的输出
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "姓名：" + name + "\t电话：" + phone;
        }
    }
}
