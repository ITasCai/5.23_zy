using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2：编写一个类Student2，代表学员，要求：（1）具有属性：姓名、年龄、性别、专业。（2）具有方法：自我介绍，负责输出该学员的姓名、年龄、性别以及专业。（3）具有两个带参构造方法：第一个构造方法中，设置学员的性别为男、专业.NET，其余属性的值由参数给定；第二个构造方法中，所有属性的都由参数给定。

            Student2 st = new Student2("张三",20);
            Console.WriteLine(st.ToString());
            Console.WriteLine("------------------------------------");
            Student2 st2 = new Student2("李四",25,"女","java开发");
            Console.WriteLine(st2.ToString());

            Console.ReadKey();

            #endregion
        }
    }
}
