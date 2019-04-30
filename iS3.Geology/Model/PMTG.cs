using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //旁压试验
    //
    [Table("Geology_PMTG")]
    public class PMTG : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验底埋深
        public Nullable<decimal> PMTG_DPTH { get; set; }
        //试验集
        public string PMTG_TESN { get; set; }
        //试验时间
        public  Nullable<DateTime> PMTG_DATE { get; set; }
        //地下水位埋深（推断或实测）
        public Nullable<decimal> PMTG_WAT { get; set; }
        //分包商
        public string PMTG_CONT { get; set; }
        //操作者
        public string PMTG_CREW { get; set; }
        //试验仪器序列号
        public string PMTG_REF { get; set; }
        //旁压仪类型
        public string PMTG_TYPE { get; set; }
        //未加压旁压仪直径
        public Nullable<decimal> PMTG_DIAM { get; set; }
        //现场水平应力
        public Nullable<decimal> PMTG_HO { get; set; }
        //现场剪切模量
        public Nullable<decimal> PMTG_GI { get; set; }
        //不排水抗剪强度
        public Nullable<decimal> PMTG_CU { get; set; }
        //极限压力
        public Nullable<decimal> PMTG_PL { get; set; }
        //摩擦角
        public Nullable<decimal> PMTG_AF { get; set; }
        //剪胀角
        public Nullable<decimal> PMTG_AD { get; set; }
        //摩擦角固定体积状态(*cv)
        public Nullable<decimal> PMTG_AFCV { get; set; }
        //用于确定土壤衍生参数的方法
        public string PMTG_METH { get; set; }
        //试验状态
        public string TEST_STAT { get; set; }
        //试验天气状况及环境状况
        public string PMTG_ENV { get; set; }
        //备注
        public string PMTG_REM { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
