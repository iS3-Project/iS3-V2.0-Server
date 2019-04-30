using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //研究区DEM
    [Table("Geology_SDEM")]
    public partial class SDEM : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //线性单位
        public string SDEM_UNIT { get; set; }
        //上范围
        public Nullable<decimal> SDEM_UP { get; set; }
        //下范围
        public Nullable<decimal> SDEM_DOWN { get; set; }
        //左范围
        public Nullable<decimal> SDEM_LEFT { get; set; }
        //右范围
        public Nullable<decimal> SDEM_RIGH { get; set; }
        //备注
        public string SDEM_REM { get; set; }


      
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
