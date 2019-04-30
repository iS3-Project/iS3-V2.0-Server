using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    //三轴试验数据(有效应力）
    [Table("Geology_TRET")]
    public partial class TRET : iS3AreaHandle
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
        //三轴试验集
        public string TRET_TESN { get; set; }
        //试件直径或边长
        public Nullable<decimal> TRET_SDIA { get; set; }
        //试件长度
        public Nullable<decimal> TRET_LEN { get; set; }
        //试件初始含水率
        public Nullable<decimal> TRET_IMC { get; set; }
        //试件最终含水率
        public Nullable<decimal> TRET_FMC { get; set; }
        //Initial bulk density
        public Nullable<decimal> TRET_BDEN { get; set; }
        //Initial dry density
        public Nullable<decimal> TRET_DDEN { get; set; }
        //Method of saturation
        public string TRET_SAT { get; set; }
        //Details of consolidation stage
        public string TRET_CONS { get; set; }
        //Effective stress at end of consolidation/ start of shear stage
        public Nullable<decimal> TRET_CONP { get; set; }
        //Total cell pressure
        public Nullable<decimal> TRET_CELL { get; set; }
        //Porewater pressure at start of shear stage
        public Nullable<decimal> TRET_PWPI { get; set; }
        //Rate of axial strain during shear
        public Nullable<decimal> TRET_STRR { get; set; }
        //Axial strain at failure
        public Nullable<decimal> TRET_STRN { get; set; }
        //Deviator stress at failure
        public Nullable<decimal> TRET_DEVF { get; set; }
        //Porewater pressure at failure
        public Nullable<decimal> TRET_PWPF { get; set; }
        //Volumetric strain at failure (drained only)
        public Nullable<decimal> TRET_STV { get; set; }
            
        //破坏模式
        public string TRET_MODE { get; set; }
        //备注
        public string TRET_REM { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }


    }
}
