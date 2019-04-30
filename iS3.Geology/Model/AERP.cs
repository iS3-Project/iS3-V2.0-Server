using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //航空航片信息
    [Table("Geology_AERP")]
    public partial class AERP : iS3AreaHandle
    {
        //航片ID
        public string AERP_ID { get; set; }
        //航片类型
        public string AERP_TYPE { get; set; }
        //飞行高度
        public string AERP_HEIG { get; set; }
        //俯视角度
        public string AERP_DIP { get; set; }
        //成像时间
        public string AERP_DTIM { get; set; }
        //执行人
        public string AERP_STAFF { get; set; }
        //承包人
        public string AERP_CONT { get; set; }
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
