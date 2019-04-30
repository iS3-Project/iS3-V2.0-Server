using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    //三轴试验数据(总应力）
    [Table("Geology_TRIT")]
    public partial class TRIT : iS3AreaHandle
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
        public string TRIT_TESN { get; set; }
        //试件直径或边长
        public Nullable<decimal> TRIT_SDIA { get; set; }
        //试件长度
        public Nullable<decimal> TRIT_SLEN { get; set; }
        //试件初始含水率
        public Nullable<decimal> TRIT_IMC { get; set; }
        //试件最终含水率
        public Nullable<decimal> TRIT_FMC { get; set; }
        //Total cell pressure
        public Nullable<decimal> TRIT_CELL { get; set; }
        //Corrected deviator stress at failure
        public Nullable<decimal> TRIT_DEVF { get; set; }
        //Initial bulk density
        public Nullable<decimal> TRIT_BDEN { get; set; }
        //Initial dry density
        public Nullable<decimal> TRIT_DDEN { get; set; }
        //Axial strain at failure
        public Nullable<decimal> TRIT_STRN { get; set; }
        //破坏时不排水抗剪强度
        public Nullable<decimal> TRIT_CU { get; set; }
        //破坏模式
        public string TRIT_MODE { get; set; }
        //备注
        public string TRIT_REM { get; set; }


        //关联文件
        public string FILE_FSET { get; set; }


    }
}
