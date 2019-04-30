using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //岩石密度试验
    //
    [Table("Geology_RDEN")]
    public class RDEN : iS3AreaHandle
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
        //标本制备的详细信息，例如准备和测试之间的间隔时间
        public string SPEC_PREP { get; set; }
        //含水量
        public Nullable<decimal> RDEN_MC { get; set; }
        //饱和含水量
        public Nullable<decimal> RDEN_SMC { get; set; }
        //体积密度
        public Nullable<decimal> RDEN_BDEN { get; set; }
        //干密度
        public Nullable<decimal> RDEN_DDEN { get; set; }
        //孔隙率
        public Nullable<decimal> RDEN_PORO { get; set; }
        //颗粒表观密度
        public Nullable<decimal> RDEN_PDEN { get; set; }
        //样品干燥温度
        public Nullable<decimal> RDEN_TEMP { get; set; }
        //备注
        public string RDEN_REM { get; set; }
        //测试方法
        public string RDEN_METH { get; set; }
        //检测组织或机构
        public string RDEN_LAB { get; set; }
        //认证机构和参考编号（如果有的话填写）
        public string RDEN_CRED { get; set; }
        //试验状态
        public string TEST_STAT { get; set; }
        //关联文件（测试结果表）
        public string FILE_FSET { get; set; }
    }
}
