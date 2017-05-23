using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._23_zy
{
    /// <summary>
    /// 学生类1
    /// </summary>
    class Student1
    {
        private string name;
        private int age;


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
                if (value < 16){
                    Console.WriteLine("信息错误！");
                }
                else
                {
                    age = value;
                }
               
            }
        }
        /// <summary>
        /// 用于信息的输出
        /// </summary>
        public void Show() {
            Console.WriteLine("大家好，我叫{0},今年{1}岁了！",name,age);
        }
    }
}
