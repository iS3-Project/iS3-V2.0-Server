using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    //岩石单轴抗压试验
    [Table("Geology_RUCS")]
    public partial class RUCS : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //采样顶埋深
        public Nullable<decimal> SAMP_TOP { get; set; }
        //采样集
        public string SAMP_REF { get; set; }
        //采样类型
        public string SAMP_TYPE { get; set; }
        //采样ID
        public string SAMP_ID { get; set; }
        //样本集
        public string SPEC_REF { get; set; }
        //样本顶埋深
        public Nullable<decimal> SPEC_DPTH { get; set; }
        //样本描述
        public string SPEC_DESC { get; set; }
        //标本制备的详细信息，例如准备和测试之间的间隔时间
        public string SPEC_PREP { get; set; }
        //试件直径或边长
        public Nullable<decimal> RUCS_SDIA { get; set; }
        //试件长度
        public Nullable<decimal> RUCS_LEN { get; set; }
        //试件含水率
        public Nullable<decimal> RUCS_MC { get; set; }
        //Condition of specimen as tested
        public string RUCS_COND { get; set; }
        //Test duration
        public Nullable<System.DateTime> RUCS_DURN { get; set; }
        //Stress rate
        public Nullable<decimal> RUCS_STRA { get; set; }
        //Uniaxial compressive strength
        public Nullable<decimal> RUCS_UCS { get; set; }
        //Mode of failure
        public string RUCS_MODE { get; set; }
        //Young’s modulus
        public Nullable<decimal> RUCS_E { get; set; }
        //Poisson’s ratio
        public Nullable<decimal> RUCS_MU { get; set; }
        //Stress level at which modulus has been measured
        public string RUCS_ESTR { get; set; }
        //Method of determination of Young’s modulus
        public string RUCS_ETYP { get; set; }
        //Type of testing machine
        public string RUCS_MACH { get; set; }

        public string RUCS_REM { get; set; }
        //Test method
        public string RUCS_METH { get; set; }
        //Name of testing laboratory/ organisation
        public string RUCS_LAB { get; set; }

        //Accrediting body and reference number (when appropriate)
        public string RUCS_CRED { get; set; }
        

        //试验状态
        public string TEST_STAT { get; set; }


        //关联文件
        public string FILE_FSET { get; set; }


    }
}
