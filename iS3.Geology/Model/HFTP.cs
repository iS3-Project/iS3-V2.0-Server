using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //水压致裂试验衍生数据
    //
    [Table("Geology_HFTP")]
    public class HFTP : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验编码
        public string HFTG_TNUM { get; set; }
        //试验点埋深
        public Nullable<decimal> HFTD_DPTH { get; set; }
        //解译编码
        public string HFTP_INUM { get; set; }
        //地层开裂压力（Pb）
        public string HFTP_PB { get; set; }
        //裂缝重张压力（Pr）
        public string HFTP_PR { get; set; }
        //瞬时关井压力（ISIP）
        public string HFTP_ISIP { get; set; }
        //裂缝闭合压力（Pc）
        public string HFTP_PC { get; set; }
        //最小水平主应力（Shmin）
        public string HFTP_SHMIN { get; set; }
        //最大水平主应力（Shmax）
        public string HFTP_SHMAX { get; set; }
        //竖向应力（Sv）
        public string HFTP_SV { get; set; }
        //抗拉强度(Pt）
        public string HFTP_PT { get; set; }
        //备注
        public string HFTP_REM { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
