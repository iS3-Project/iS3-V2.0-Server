using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //侧胀试验衍生参数
    //
    [Table("Geology_DMTP")]
    public class DMTP : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验集
        public string DMTG_TESN { get; set; }
        //距离地下水位
        public Nullable<decimal> DMTT_DPTH { get; set; }
        //解释参考
        public string DMTP_REF { get; set; }
        //材料指数, (ID)
        public Nullable<decimal> DMTP_DMID { get; set; }
        //水平应力指数, (KD)
        public Nullable<decimal> DMTP_DKD { get; set; }
        //扁铲模量, (ED)
        public Nullable<decimal> DMTP_DED { get; set; }
        //解释土壤描述
        public string DMTP_DSD { get; set; }
        //侧胀仪尖端轴承(qD)
        public Nullable<decimal> DMTP_DQD { get; set; }
        //静止侧压力系数(K0),
        public Nullable<decimal> DMTP_DKO { get; set; }
        //超固结比 (OCR)
        public Nullable<decimal> DMTP_DOCR { get; set; }
        //有效内摩擦角 (φ’)
        public Nullable<decimal> DMTP_DPHI { get; set; }
        //垂直排水约束模量, (M)
        public Nullable<decimal> DMTP_DVDM { get; set; }
        //不排水抗剪强度(Cu)
        public Nullable<decimal> DMTP_DSU { get; set; }
        //小应变剪切模量(G0)
        public Nullable<decimal> DMTP_DGO { get; set; }
        //备注
        public string DMTP_REM { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
