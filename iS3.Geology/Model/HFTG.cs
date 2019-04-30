using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //水压致裂试验
    //
    [Table("Geology_HFTG")]
    public class HFTG : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验编码
        public string HFTG_TNUM { get; set; }
        //试验日期
        public string HFTG_DATE { get; set; }
        //备注
        public string HFTG_REM { get; set; }
        //地下水位埋深（试验时）
        public Nullable<decimal> HFTG_WAT { get; set; }
        //地下水位确定方法（分析或实测）
        public string HFTG_GWD { get; set; }
        //测试设备
        public string HFTG_SET { get; set; }
        //分包商名称
        public string HFTG_CONT { get; set; }
        //测试所使用的标准
        public string HFTG_METH { get; set; }
        //测试人员
        public string HFTG_CREW { get; set; }
        //关联文件（岩矿鉴定报告）
        public string FILE_FSET { get; set; }
    }
}
