using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //侧胀试验
    //
    [Table("Geology_DMTG")]
    public class DMTG : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验集
        public string DMTG_TESN { get; set; }
        //试验时间
        public Nullable<DateTime> DMTG_DATE { get; set; }
        //备注
        public string DMTG_REM { get; set; }
        //地下水位埋深（试验时）
        public Nullable<decimal> DMTG_WAT { get; set; }
        //地下水位确定方法（分析或实测）
        public string DMTG_GWD { get; set; }
        //分包商名称
        public string DMTG_CONT { get; set; }
        //测试所使用的标准
        public string DMTG_METH { get; set; }
        //测试人员
        public string DMTG_CREW { get; set; }
        //渗透装置类型
        public string DMTG_TYPE { get; set; }
        //推力测量方法和校准
        public string DMTG_COT { get; set; }
        //渗透杆的类型和直径
        public string DMTG_TDR { get; set; }
        //叶片校准值, ∆A
        public Nullable<decimal> DMTG_BCVA { get; set; }
        //叶片校准值, ∆B
        public Nullable<decimal> DMTG_BCVB { get; set; }
        //校正因子, Zm
        public string DMTG_CFZM { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
