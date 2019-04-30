using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //侧胀试验数据
    //
    [Table("Geology_DMTT")]
    public class DMTT : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验集
        public string DMTG_TESN { get; set; }
        //距离地下水位
        public Nullable<decimal> DMTT_DPTH { get; set; }
        //推力（可填）
        public Nullable<decimal> DMTT_MTH { get; set; }
        //A-气压值
        public Nullable<decimal> DMTT_PTA { get; set; }
        //B-气压值
        public Nullable<decimal> DMTT_PTB { get; set; }
        //C-气压值
        public Nullable<decimal> DMTT_PTC { get; set; }
        //A, p0
        public Nullable<decimal> DMTT_APTA { get; set; }
        //B, p1
        public Nullable<decimal> DMTT_APTB { get; set; }
        //C, p2
        public Nullable<decimal> DMTT_APTC { get; set; }
        //横波速度, Vs
        public Nullable<decimal> DMTT_SWV { get; set; }
        //估计的土体重量,(Y)
        public Nullable<decimal> DMTT_EGAM { get; set; }
        //竖向总应力 (σv),(根据DMTT_EGAM)
        public Nullable<decimal> DMTT_ETVS { get; set; }
        //现场孔隙水压力, (U0) (实测或根据DMTG_WAT计算) 
        public Nullable<decimal> DMTT_ISPP { get; set; }
        //竖向有效应力, (σv’) (根据DMTT_ETVS 、DMTT_ISPP 、 DMTG_WAT计算)
        public Nullable<decimal> DMTT_EEFS { get; set; }
        //备注
        public string DMTT_REM { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
