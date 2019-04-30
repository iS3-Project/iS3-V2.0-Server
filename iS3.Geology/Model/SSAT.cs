using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //研究区卫星图

    [Table("Geology_SSAT")]
    public partial class SSAT : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }

        //上范围
        public Nullable<decimal> SSAT_UP { get; set; }
        //下范围
        public Nullable<decimal> SSAT_DOWN { get; set; }
        //左范围
        public Nullable<decimal> SSAT_LEFT { get; set; }
        //右范围
        public Nullable<decimal> SSAT_RIGH { get; set; }
        //备注
        public string SSAT_REM { get; set; }


      
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
