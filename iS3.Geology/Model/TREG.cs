using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    ////三轴试验(有效应力）
    [Table("Geology_TREG")]
    public partial class TREG : iS3AreaHandle
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
        //Test type
        public string TREG_TYPE { get; set; }
        //Sample condition statement
        public string TREG_COND { get; set; }
        //Cohesion intercept associated with TREG_PHI
        public Nullable<decimal> TREG_COH { get; set; }
        //Angle of friction for effective shear strength triaxial test
        public Nullable<decimal> TREG_PHI { get; set; }
        //Failure criterion
        public string TREG_FCR { get; set; }

        //Remarks including commentary on effect of specimen  disturbance on test result
        public string TREG_REM { get; set; }
        //Test method
        public string TREG_METH { get; set; }
        //Name of testing laboratory/ organisation
        public string TREG_LAB { get; set; }

        //Accrediting body and reference number (when appropriate)
        public string TREG_CRED { get; set; }
        

        //试验状态
        public string TEST_STAT { get; set; }


        //关联文件
        public string FILE_FSET { get; set; }


    }
}
