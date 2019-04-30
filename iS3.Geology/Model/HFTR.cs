using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    // 压水试验记录表
    [Table("Geology_HFTR")]
    public partial class HFTR : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //试验段编号
        public string PROJ_TSSN { get; set; }
        //水柱压力
        public Nullable<decimal> HTFR_WCPR { get; set; }
        //压力阶段
        public string HTFR_PRST { get; set; }
        //测量时间
        public Nullable<System.DateTime> HTFR_METI { get; set; }
        //时间间隔
        public Nullable<decimal> HTFR_TIIN { get; set; }
        //压力表压力
        public Nullable<decimal> HTFR_PRRE { get; set; }
        //压力损失
        public Nullable<decimal> HTFR_PRLO { get; set; }
        //总压力
        public Nullable<decimal> HTFR_TOPR { get; set; }
        //水表读数
        public Nullable<decimal> HTFR_INWM { get; set; }

        //流量
        public Nullable<decimal> HTFR_INFL { get; set; }

        //备注
        public string HTRF_MEMO { get; set; }


        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
