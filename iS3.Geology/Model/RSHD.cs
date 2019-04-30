using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    [Table("Geology_RSHD")]
    public partial class RSHD : iS3AreaHandle
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
        //环剪切阶段
        public string RSHD_TESN { get; set; }
        //Initial bulk density
        public Nullable<decimal> RSHD_BDEN { get; set; }
        //Initial dry density
        public Nullable<decimal> RSHD_DDEN { get; set; }
        //Normal stress applied
        public Nullable<decimal> RSHD_NORM { get; set; }
        //Angular rate for residual stress stage
        public Nullable<decimal> RSHD_DISA { get; set; }
        //Displacement rate for residual  stress stage
        public Nullable<decimal> RSHD_DISR { get; set; }
        //Residual shear stress
        public Nullable<decimal> RSHD_RES { get; set; }
        //Average linear displacement at residual shear stress
        public Nullable<decimal> RSHD_RDIS { get; set; }
        //Cumulative angular displacement  at residual shear stress
        public Nullable<decimal> RSHD_ADIS { get; set; }
        //Particle (solid) density with prefix #  if value assumed
        public string RSHD_PDEN { get; set; }
        //Initial voids ratio
        public Nullable<decimal> RSHD_IVR { get; set; }
        //Initial moisture content
        public Nullable<decimal> RSHD_MCI { get; set; }
        //Final moisture content
        public Nullable<decimal> RSHD_MCF { get; set; }
        //Average inner specimen diameter 
        public Nullable<decimal> RSHD_DIA1 { get; set; }
        //Average outer diameter  
        public Nullable<decimal> RSHD_DIA2 { get; set; }
        //Specimen height
        public Nullable<decimal> RSHD_HGT { get; set; }
        //Residual strength criterion used
        public string RSHD_CRIT { get; set; }
        //备注
        public string RSHD_REM { get; set; }



        //关联文件（试验记录表）
        public string FILE_FSET { get; set; }


    }
}
