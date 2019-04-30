using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;


namespace iS3.Geology.Model
{
    //遥感信息翻译
    [Table("Geology_IRSI")]
    public partial class IRSI : iS3AreaHandle
    {
        //航片ID
        public string AERP_ID { get; set; }
        //解译索引编号
        public string IRSI_ID { get; set; }
        //解译方法
        public string IRSI_MEAN { get; set; }
        //图像类型
        public string IRSI_PTYPE { get; set; }
        //解译地物类型
        public string IRSI_GTYPE { get; set; }
        //主要解译标志
        public string IRSI_SIGN { get; set; }
        //光学图像处理方法
        public string IRSI_OIPM { get; set; }
        //数字图像处理方法
        public string IRSI_DIPM { get; set; }
        //执行人
        public string IRSI_STAFF { get; set; }
        //承包人
        public string IRSI_CONT { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
