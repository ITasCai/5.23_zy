using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九题
{
    /// <summary>
    /// 学生类
    /// </summary>
    class Student
    {
        private int stuNo;
        private string name;
        private string sex;


        public Student() { 
        }
        /// <summary>
        /// 学生类的一个构造方法
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="sex">性别</param>
        public Student(int stuNo,string name,string sex) {
            this.stuNo = stuNo;
            this.name = name;
            this.sex = sex;
        }

        /// <summary>
        /// 学号
        /// </summary>
        public int StuNo
        {
            get
            {
                return stuNo;
            }

            set
            {
                stuNo = value;
            }
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
        /// 重写tostring方法，便于信息的输出
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return "学号：" + stuNo + "\n姓名：" + name + "\n性别：" + sex;
        }

     

    }
}
