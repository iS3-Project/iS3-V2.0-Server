using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //抽水试验记录表
    [Table("Geology_PUTR")]
    public partial class PUTR : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //抽水观测时间
        public Nullable<System.DateTime> PUBR_TIME { get; set; }
        //累计时间
        public Nullable<decimal> PUBR_ACTI { get; set; }

        //水位
        public Nullable<decimal> PUBR_WATA { get; set; }
        //降深
        public Nullable<decimal> PUBR_DRDO { get; set; }
        //涌水量
        public Nullable<decimal> PUBR_GUSH { get; set; }
        //负责人
        public string PUBR_OBPE { get; set; }
        //备注
        public string PUBR_MEMO { get; set; }

        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
