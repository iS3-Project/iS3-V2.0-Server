using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //动力触探试验
    //
    [Table("Geology_DPRG")]
    public class DPRG : iS3AreaHandle
    {
        //位置ID
        public string DPRG_ID { get; set; }
        //试验集
        public string DPRG_TESN { get; set; }
        public string DPRG_NUMB { get; set; }
        public string DPRG_LOCA { get; set; }
        public string DPRG_STRA { get; set; }
        public string DPRG_DESC { get; set; }

       
        public Nullable<decimal> DPRG_TOP { get; set; }
      
        public Nullable<decimal> DPRG_BASE { get; set; }
      
        public Nullable<decimal> DPRG_LEGH { get; set; }
        public string DPRG_WATER { get; set; }
        public string DPRG_REM { get; set; }

        //关联文件（设备检验表）
        public string FILE_FSET { get; set; }
    }
}
