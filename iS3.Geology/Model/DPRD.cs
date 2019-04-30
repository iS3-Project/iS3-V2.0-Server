using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //动力触探试验数据
    //
    [Table("Geology_DPRD")]
    public class DPRD: iS3AreaHandle
    {

       
        public string DPRD_ID { get; set; }
        //试验集
        public string DPRG_TESN { get; set; }
        
        public Nullable<decimal> DPRD_MAHN { get; set; }
        
        public Nullable<decimal> DPRD_CORF { get; set; }
        
        public Nullable<decimal> DPRD_MHMN { get; set; }
        public string DPRD_DENS { get; set; }
        public Nullable<decimal> DPRD_INFA { get; set; }
        public Nullable<decimal> DPRD_BEAR { get; set; }
        public Nullable<decimal> DPRD_MODF { get; set; }

        //Notes on events during increment
        public string DPRD_REM { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
