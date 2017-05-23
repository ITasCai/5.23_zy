using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 9:创建学生类，学生类中学号、姓名、性别，在学生类中有显示学生信息的方法。有一个学生类的派生类（名字自定），它有两个字段，分别代表两门成绩。Score1和Score2，其中包含两个方法，计算总成绩和平均成绩，最后输出并打印学生信息和总成绩及平均成绩。


            Console.WriteLine("输入你的学号：");
            int stuNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入你的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("输入你的性别：");
            string sex = Console.ReadLine();
            Console.WriteLine("输入你的第一门成绩：");
            double score1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入你的第二门成绩：");
            double score2 = Convert.ToDouble(Console.ReadLine());

            Student student = new Student(stuNo,name,sex);
             Score s = new Score(score1,score2);
            Console.WriteLine(student);
            double sum=s.Sum(score1,score2);
            double avg= s.Avg(score1, score2);
            Console.WriteLine("总分:{0},\n平均分{1}",sum,avg);

            Console.ReadKey();
            #endregion
        }
    }
}
