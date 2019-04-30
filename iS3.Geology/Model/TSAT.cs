using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //隧址区卫星图
    [Table("Geology_TSAT")]
    public partial class TSAT : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }

        //上范围
        public Nullable<decimal> TSAT_UP { get; set; }
        //下范围
        public Nullable<decimal> TSAT_DOWN { get; set; }
        //左范围
        public Nullable<decimal> TSAT_LEFT { get; set; }
        //右范围
        public Nullable<decimal> TSAT_RIGH { get; set; }
        //备注
        public string TSAT_REM { get; set; }


      
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
