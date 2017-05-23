using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九题
{
    /// <summary>
    /// 成绩类
    /// </summary>
    class Score:Student
    {
        private double score1;
        private double score2;


        /// <summary>
        /// 成绩类的构造方法
        /// </summary>
        /// <param name="score1">第一门成绩</param>
        /// <param name="score2">第二门成绩</param>
        /// <param name="stuNo">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="sex">性别</param>
        public Score(double score1, double score2) 
        {
            this.Score1 = score1;
            this.Score2 = score2;
        }

        /// <summary>
        /// 第一门成绩
        /// </summary>
        public double Score1
        {
            get
            {
                return score1;
            }

            set
            {
                score1 = value;
            }
        }
        /// <summary>
        /// 第二门成绩
        /// </summary>
        public double Score2
        {
            get
            {
                return score2;
            }

            set
            {
                score2 = value;
            }
        }
        /// <summary>
        /// 计算成绩的总分
        /// </summary>
        /// <param name="num1">第一门成绩</param>
        /// <param name="num2">第二门成绩</param>
        /// <returns>返回总分</returns>
        public double Sum(double num1,double num2) {
            double sum = num1 + num2;
            return sum; 
        }

        /// <summary>
        /// 计算平均分
        /// </summary>
        /// <param name="num1">第一门成绩</param>
        /// <param name="num2">第二门成绩</param>
        /// <returns></returns>
        public double Avg(double num1, double num2) {
            double avg = Sum(num1,num2)/2;
            return avg;
        }
    }
}
