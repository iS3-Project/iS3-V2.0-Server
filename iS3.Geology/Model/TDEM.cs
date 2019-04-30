using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //隧址区DEM
    [Table("Geology_TDEM")]
    public partial class TDEM : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //线性单位
        public string TDEM_UNIT { get; set; }
        //上范围
        public Nullable<decimal> TDEM_UP { get; set; }
        //下范围
        public Nullable<decimal> TDEM_DOWN { get; set; }
        //左范围
        public Nullable<decimal> TDEM_LEFT { get; set; }
        //右范围
        public Nullable<decimal> TDEM_RIGH { get; set; }
        //备注
        public string TDEM_REM { get; set; }


      
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
