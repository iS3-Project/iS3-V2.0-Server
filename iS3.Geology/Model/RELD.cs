using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    // 相对密度试验
    //
    [Table("Geology_RELD")]
    public class RELD : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //采样顶埋深
        public Nullable<decimal>  SAMP_TOP { get; set; }
        //采样集
        public string SAMP_REF { get; set; }
        //采样类型
        public string SAMP_TYPE { get; set; }
        //采样ID
        public string SAMP_ID { get; set; }
        //样本集
        public string SPEC_REF { get; set; }
        //样本顶埋深
        public Nullable<decimal>  SPEC_DPTH { get; set; }
        //样本描述
        public string SPEC_DESC { get; set; }
        //Details of specimen preparation including time between preparation and testing
        public string SPEC_PREP { get; set; }
        //Maximum dry density
        public Nullable<decimal> RELD_DMAX { get; set; }
        //Weight percent of sample retained on 37.5mm sieve
        public Nullable<decimal> RELD_375 { get; set; }
        //Weight percent of sample retained on 6.3mm sieve
        public Nullable<decimal> RELD_063 { get; set; }
        //Weight percent of sample retained on 2mm sieve
        public Nullable<decimal> RELD_020 { get; set; }
        //Minimum dry density
        public Nullable<decimal> RELD_DMIN { get; set; }
        //Remarks on test
        public string RELD_REM { get; set; }
        //Test method
        public string RELD_METH { get; set; }
        //Name of testing laboratory/ organisation
        public string RELD_LAB { get; set; }
        //Accrediting body and reference number (when appropriate)
        public string RELD_CRED { get; set; }
        //试验状态
        public string TEST_STAT { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
