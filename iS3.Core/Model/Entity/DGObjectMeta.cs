using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iS3.Core.Model
{
    /// <summary>
    /// 对象组定义
    /// </summary>
    [Table("Project_DGObjectMeta")]
    public class DGObjectMeta : iS3AreaHandle
    {
       
        /// <summary>
        /// 所属工程领域
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// 对象类型
        /// </summary>
        public string ObjType { get; set; }
        /// <summary>
        /// 属性名
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// 用于显示的属性中文名
        /// </summary>
        public string ChsName { get; set; }
        /// <summary>
        /// 用于显示的属性英文名
        /// </summary>
        public string EnName { get; set; }
        /// <summary>
        /// 属性是否显示
        /// </summary>
        public bool State { get; set; }
        public DGObjectMeta(string domain, string objType, string propertyName, string chsName, string enName, bool state)
        {
            Domain = domain;
            ObjType = objType;
            PropertyName = propertyName;
            ChsName = chsName;
            EnName = enName;
            State = state;
        }
    }
}
