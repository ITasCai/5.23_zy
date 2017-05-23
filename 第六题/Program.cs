using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 6：创建一个类：车，包含属性：轮胎个数，最高速度，载重量，载物类型，有加速方法（空方法），并创建相应的子类：自行车类，自行车类继承车类，重写加速方法，在方法中输出“要啥自行车？”，创建山地车类，不重写车类方法，拥有独立方法：比赛，该方法输出信息“骑上山地车，腰也不酸了，腿也不疼了，能参加比赛了！”

            Bicycle b = new Bicycle();
            b.speedUp();
            Console.WriteLine("-----------------------");
            MTB m = new MTB();
            m.Show();

            Console.ReadKey();

            #endregion
        }
    }
}
