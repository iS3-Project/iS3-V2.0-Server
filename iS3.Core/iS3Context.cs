using iS3.Core.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core
{
    /// <summary>
    /// ORM 数据库操作实例
    /// </summary>
    public class iS3Context:DbContext
    {
        public static Dictionary<string, DataSourceInfo> dataSourceDict;
        //数据表单统一前缀
        public virtual string TablePrefix { get;}
        //数据库操作实例所需的工程ID，对应数据库名
        private string prj;

        public string Project { get { return prj; } }

        //构造函数，根据工程名，获取定义在web.config的连接字段
        //public iS3Context(string project) : base(ConnectionString(project).Result)
        //{
        //    prj = project;
        //}
        public iS3Context(string project) : base(project)
        {
            prj = project;
        }
        public iS3Context() : base("myContext")
        {
        }
        //public iS3Context(string project) : base("myContext")
        //{
        //    prj = project;
        //}
        //返回统一的数据库操作实例
        public iS3Context GetContext()
        {
            return this;
        }
       
    }
}
