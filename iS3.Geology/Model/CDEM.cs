using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //地理空间数据云DEM
    [Table("Geology_CDEM")]
    public partial class CDEM : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //线性单位
        public string CDEM_UNIT { get; set; }
        public string CDEM_NAME { get; set; }
        //上范围
        public Nullable<decimal> CDEM_UP { get; set; }
        //下范围
        public Nullable<decimal> CDEM_DOWN { get; set; }
        //左范围
        public Nullable<decimal> CDEM_LEFT { get; set; }
        //右范围
        public Nullable<decimal> CDEM_RIGH { get; set; }
        //备注
        public string CDEM_REM { get; set; }


      
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
