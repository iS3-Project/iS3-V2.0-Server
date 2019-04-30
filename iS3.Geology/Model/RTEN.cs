using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    [Table("Geology_RTEN")]
    public partial class RTEN : iS3AreaHandle
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
        //Specimen diameter
        public Nullable<decimal> RTEN_SDIA { get; set; }
        //Specimen thickness
        public Nullable<decimal> RTEN_LEN { get; set; }
        //Water content of test specimen
        public Nullable<decimal> RTEN_MC { get; set; }
        //Condition of specimen as tested
        public string RTEN_COND { get; set; }
        //Test duration
        public Nullable<System.DateTime> RTEN_DURN { get; set; }
        //Stress rate
        public Nullable<decimal> RTEN_STRA { get; set; }
        //Tensile strength
        public Nullable<decimal> RTEN_TENS { get; set; }
        //Mode of failure
        public string RTEN_MODE { get; set; }
        //Testing machine
        public string RTEN_MACH { get; set; }
        //Remarks
        public string RTEN_REM { get; set; }
        //试验方法
        public string RTEN_METH { get; set; }
        //检测组织或机构
        public string RTEN_LAB { get; set; }
        //认证机构和参考编号（如果有的话填写）
        public string RTEN_CRED { get; set; }
        //试验状态
        public string TEST_STAT { get; set; }


        //关联文件（现场日志表）
        public string FILE_FSET { get; set; }


    }
}
