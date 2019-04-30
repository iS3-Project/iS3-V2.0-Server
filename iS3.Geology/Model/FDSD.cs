using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //现场直剪试验数据
    //
    [Table("Geology_FDSD")]
    public class FDSD : iS3AreaHandle
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
        public Nullable<decimal> SPEC_DPTH { get; set; }
        //Ring shear stage
        public string FDSD_TESN { get; set; }
        //Initial bulk density
        public Nullable<decimal> FDSD_BDEN { get; set; }
        //Initial dry density
        public Nullable<decimal> FDSD_DDEN { get; set; }
        //Normal stress applied
        public Nullable<decimal> FDSD_NORM { get; set; }
        //Angular rate for residual stress stage
        public Nullable<decimal> FDSD_DISA { get; set; }
        //Displacement rate for residual  stress stage
        public Nullable<decimal> FDSD_DISR { get; set; }
        //Residual shear stress
        public Nullable<decimal> FDSD_RES { get; set; }
        //Average linear displacement at residual shear stress
        public Nullable<decimal> FDSD_RDIS { get; set; }
        //Cumulative angular displacement  at residual shear stress
        public Nullable<decimal> FDSD_ADIS { get; set; }
        //Particle (solid) density with prefix #  if value assumed
        public string FDSD_PDEN { get; set; }
        //Initial voids ratio
        public Nullable<decimal> FDSD_IVR { get; set; }
        //Initial moisture content
        public Nullable<decimal> FDSD_MCI { get; set; }
        //Final moisture content
        public Nullable<decimal> FDSD_MCF { get; set; }
        //Average inner specimen diameter 
        public Nullable<decimal> FDSD_DIA1 { get; set; }
        //Average outer diameter 
        public Nullable<decimal> FDSD_DIA2 { get; set; }
        //Specimen height
        public Nullable<decimal> FDSD_HGT { get; set; }
        //Residual strength criterion used
        public string FDSD_CRIT { get; set; }
        //Remarks
        public string FDSD_REM { get; set; }
        //关联文件（试验结果记录表）
        public string FILE_FSET { get; set; }
    }
}
