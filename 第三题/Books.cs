using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三题
{
    /// <summary>
    /// 教材类
    /// </summary>
    class Books
    {
        private string title;
        private int pageNum;
        private string type;


        /// <summary>
        /// 教材类的第一构造方法，用于对数据的初始化
        /// </summary>
        /// <param name="titlt">名称</param>
        /// <param name="pageNum">页数</param>
        public Books(string title,int pageNum) {
            this.title = title;
            this.pageNum = pageNum;
            type = "计算机";

        }

        /// <summary>
        /// 教材类的第二构造方法，用于对数据的初始化
        /// </summary>
        /// <param name="title">名称</param>
        /// <param name="pageNum">页数</param>
        /// <param name="type">类型</param>
        public Books(string title,int pageNum,string type) {
            this.title = title;
            this.pageNum = pageNum;
            this.type = type;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        /// <summary>
        /// 页数
        /// </summary>
        public int PageNum
        {
            get
            {
                return pageNum;
            }

            set
            {
                pageNum = value;
            }
        }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        /// <summary>
        /// 用于对教材信息的输出
        /// </summary>
        public void Detail() {
            Console.WriteLine("教材的名称为:{0}\n页数为：{1}\n类型为:{2}",title,pageNum,type);

        }
    }
}
