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
    [Table("Project_ObjectsDefinition")]
    public class ObjectsDefinition : iS3AreaHandle
    {
        /// <summary>
        /// 中文名称
        /// </summary>
        public string Name_Chs { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        public string Name_En { get; set; }
        /// <summary>
        /// 代号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 对象组类型（重要）
        /// </summary>
        public new string Type { get; set; }
        /// <summary>
        /// 对象组对应的Domain(重要）
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// 对象组对应的GIS图层（重要）
        /// </summary>
        public string GISLayerName { get; set; }
        /// <summary>
        /// 对象组对应的三维图层
        /// </summary>
        public string Layer3DName { get; set; }
        /// <summary>
        /// 对应的数据库id
        /// </summary>
        public Nullable<int> DBID { get; set; }
        /// <summary>
        /// 数据库表查询
        /// </summary>
        public string TableNameSQL { get; set; }
        /// <summary>
        /// 排序条件
        /// </summary>
        public string OrderSQL { get; set; }
        /// <summary>
        /// 查询条件
        /// </summary>
        public string ConditionSQL { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 对象组的筛选条件
        /// </summary>
        [NotMapped]
        public string Filter { get; set; }
        /// <summary>
        /// 对象组名称
        /// </summary>
        [NotMapped]
        public new string Name { get { return Name_En; } set { Name_En = value; } }
        [NotMapped]
        public  List<DGObjectMeta> Metas { get;  set; }

    }
}
