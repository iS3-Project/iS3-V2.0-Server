using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //载荷板试验数据
    //
    [Table("Geology_PLTT")]
    public class PLTT: iS3AreaHandle
    {
        //Location identifier
        public string LOCA_ID { get; set; }
        //Test depth
        public Nullable<decimal> PLTG_DPTH { get; set; }
        //Test reference
        public string PLTG_TESN { get; set; }
        //Load cycle
        public string PLTG_CYC { get; set; }
        //Load stage
        public string PLTT_STG { get; set; }
        //Stage elapsed time
        public Nullable<decimal> PLTT_TIME { get; set; }
        //Applied load
        public Nullable<decimal> PLTT_LOAD { get; set; }
        //Settlement Gauge 1
        public Nullable<decimal> PLTT_SET1 { get; set; }
        //Settlement Gauge 2
        public Nullable<decimal> PLTT_SET2 { get; set; }
        //Settlement Gauge 3
        public Nullable<decimal> PLTT_SET3 { get; set; }
        //Settlement Gauge 4
        public Nullable<decimal> PLTT_SET4 { get; set; }
        //Comments on reading
        public string PLTT_REM { get; set; }
        //Associated file reference (eg test result sheets)
        public string FILE_FSET { get; set; }
    }
}
