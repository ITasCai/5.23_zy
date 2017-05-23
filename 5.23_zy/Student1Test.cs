using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._23_zy
{
    class Student1Test
    {
        static void Main(string[] args)
        {

            #region 1：编写一个类student1，代表学员，要求：（1）具有属性：姓名、年龄，其中年龄不能小于16岁，否则输出错误信息。（2）具有方法：自我介绍，负责输出该学员的姓名、年龄。  编写测试类Student1Test进行测试，看是否符合需求。

            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            int age = Convert.ToInt32(Console.ReadLine());

            Student1 st = new Student1();
            st.Name = name;
            st.Age = age;
            st.Show();
            Console.ReadLine();
                    




            #endregion
        }
    }
}
