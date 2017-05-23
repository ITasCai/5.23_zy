using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    /// <summary>
    /// 学生类2
    /// </summary>
    class Student2
    {
        private string name;
        private int age;
        private string sex;
        private string major;

        /// <summary>
        /// 学生类2的第一个构造方法，用于数据的初始化
        /// </summary>
        /// <param name="sex">性别</param>
        /// <param name="major">年龄</param>
        public Student2(string name,int age) {
            this.name = name;
            this.age = age;
            sex = "男";
            major = ".NET";

        }

        /// <summary>
        /// 学生类2的第二个构造方法，用于数据的初始化
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        /// <param name="sex">性别</param>
        /// <param name="major">专业</param>
        public Student2(string name, int age, string sex, string major)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.major = major;

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
        /// 年龄
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        /// <summary>
        /// 专业
        /// </summary>
        public string Major
        {
            get
            {
                return major;
            }

            set
            {
                major = value;
            }
        }

       /// <summary>
       /// 重写tostring()方法，用于对信息的输出
       /// </summary>
       /// <returns></returns>
        public override string ToString()
        {
            return "姓名：" + name + "\n年龄:" + age + "\n性别:" + sex + "\n专业：" + major;
        }
    }
}
