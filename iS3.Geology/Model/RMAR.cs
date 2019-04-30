using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //岩矿鉴定试验结果
    //
    [Table("Geology_RMAR")]
    public class RMAR : iS3AreaHandle
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
        //样本底埋深
        public Nullable<decimal>  SPEC_DPTH { get; set; }
        //样本描述
        public string SPEC_DESC { get; set; }
        //标本制备的详细信息，例如准备和测试之间的间隔时间
        public string SPEC_PREP { get; set; }
        //试验时间
        public  Nullable<System.DateTime> RMAR_DATE { get; set; }
        //准确定名
        public string RMAR_NAME { get; set; }
        //典型特征描述
        public string RMAR_DESC { get; set; }
        //关联文件（手标本照片，显微镜照片）
        public string FILE_FSET { get; set; }
    }
}
