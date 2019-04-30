using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //旁压试验数据
    //
    [Table("Geology_PMTD")]
    public class PMTD : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验底埋深
        public Nullable<decimal> PMTG_DPTH { get; set; }
        //试验集
        public string PMTG_TESN { get; set; }
        //序号
        public Nullable<decimal> PMTD_SEQ { get; set; }
        //轴1位移
        public Nullable<decimal> PMTD_ARM1 { get; set; }
        //轴2位移
        public Nullable<decimal> PMTD_ARM2 { get; set; }
        //轴3位移
        public Nullable<decimal> PMTD_ARM3 { get; set; }
        //总应力
        public Nullable<decimal> PMTD_TPC { get; set; }
        //单元A孔隙压力
        public Nullable<decimal> PMTD_PPA { get; set; }
        //单元B孔隙压力
        public Nullable<decimal> PMTD_PPB { get; set; }
        //测试单元的体积变化
        public Nullable<decimal> PMTD_VOL { get; set; }
        //备注
        public string PMTD_REM { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
