using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //物探数据表
    [Table("Geology_GEPR")]
    public partial class GEPR : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //X坐标
        public Nullable<decimal> LOCA_NATE { get; set; }
        //Y坐标
        public Nullable<decimal> LOCA_NATN { get; set; }
        //岩心采取率 (TCR)
        public Nullable<decimal> GEPR_PREC { get; set; }
        //土心采取率(SCR)
        public Nullable<decimal> GEPR_SREC { get; set; }
        //岩石质量指标 (RQD)
        public Nullable<decimal> GEPR_RQD { get; set; }
        //取芯直径
        public Nullable<decimal> GEPR_DIAM { get; set; }
        //取芯持续时间
        public Nullable<System.DateTime> GEPR_DURN { get; set; }
        //备注
        public string GEPR_REM { get; set; }


        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
