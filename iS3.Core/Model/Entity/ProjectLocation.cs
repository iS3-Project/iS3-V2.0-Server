using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_ProjectLocation")]
    public class ProjectLocation : iS3AreaHandle
    {
        /// <summary>
        /// 工程代号
        /// </summary>
        public string CODE { get; set; }
        /// <summary>
        /// 工程标题
        /// </summary>
        public string ProjectTitle { get; set; }
        /// <summary>
        /// 工程X坐标
        /// </summary>
        public Nullable<Decimal> X { get; set; }
        /// <summary>
        /// 工程Y坐标
        /// </summary>
        public Nullable<Decimal> Y { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }
    }
}
