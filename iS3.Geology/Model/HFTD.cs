using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //水压致裂试验数据
    //
    [Table("Geology_HFTD")]
    public class HFTD : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验编码
        public string HFTG_TNUM { get; set; }
        //试验点埋深
        public Nullable<decimal> HFTD_DPTH { get; set; }
        //裂缝倾向
        public string HFTD_DIP { get; set; }
        //裂缝倾角
        public string HFTD_DIR { get; set; }
        //已持续时间（试验开始起计）
        public string HFTD_TIME { get; set; }
        //井口压力
        public string HFTD_WELLP { get; set; }
        //注入速率
        public string HFTD_INRATE { get; set; }
        //回流速率
        public string HFTD_RERATE { get; set; }
        //注入体积
        public string HFTD_BULK { get; set; }
        //温度
        public string HFTD_TEMP { get; set; }
        //备注
        public string HFTD_REM { get; set; }
        //关联文件（岩矿鉴定报告）
        public string FILE_FSET { get; set; }
    }
}
