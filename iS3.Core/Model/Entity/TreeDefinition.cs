using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iS3.Core.Model
{
    [Table("Project_TreeDefinition")]
    public class TreeDefinition: iS3AreaHandle
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
        /// 父节点ID
        /// </summary>
        public int ParentID { get; set; }
        /// <summary>
        /// 对应的对象组ID，重要
        /// </summary>
        public int RefObjID { get; set; }
        /// <summary>
        /// 节点描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 节点所属Domain
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// 节点Filter，筛选条件
        /// </summary>
        public string Filter { get; set; } = "";
        //ignore
        /// <summary>
        /// 树的子节点
        /// </summary>
        [NotMapped]
        public ObservableCollection<TreeDefinition> Chillds { get; set; } = new ObservableCollection<TreeDefinition>();

        [NotMapped]
        public bool HasChild
        {
            get
            {
                return (Chillds != null) && (Chillds.Count > 0);
            }
        }
    }
}
