using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //现场直剪试验
    //
    [Table("Geology_FDST")]
    public class FDST : iS3AreaHandle
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
        //样本底埋深
        public Nullable<decimal>  SPEC_DPTH { get; set; }
        //样本概述
        public string SPEC_DESC { get; set; }
        //标本制备的详细信息，例如准备和测试之间的间隔时间
        public string SPEC_PREP { get; set; }
        //采样状态
        public string FDST_COND { get; set; }
        //Residual cohesion intercept
        public Nullable<decimal> FDST_RCOH { get; set; }
        //Residual angle of friction
        public Nullable<decimal> FDST_RPHI { get; set; }
        //Remarks including commentary on effect of specimen  disturbance on test result
        public string FDST_REM { get; set; }
        //Test method	
        public string FDST_METH { get; set; }
        //Name of testing laboratory/ organisation
        public string FDST_LAB { get; set; }
        //Accrediting body and reference number (when appropriate)
        public string FDST_CRED { get; set; }
        //Test status
        public string TEST_STAT { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
