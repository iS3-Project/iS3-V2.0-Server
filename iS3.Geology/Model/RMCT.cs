using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //岩矿含量
    //
    [Table("Geology_RMCT")]
    public class RMCT : iS3AreaHandle
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
        //矿物名
        public string RMCT_NAME { get; set; }
        //含量比
        public Nullable<decimal> RMCT_CONT { get; set; }
        //关联文件（岩矿鉴定报告）
        public string FILE_FSET { get; set; }
    }
}
