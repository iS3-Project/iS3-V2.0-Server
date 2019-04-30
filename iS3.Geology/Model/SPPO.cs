using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //泉点
    [Table("Geology_SPPO")]
    public partial class SPPO : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //泉点名字
        public string SPPO_NAME { get; set; }
        //是否为人工设置的监测点
        public string SPPO_NMYN { get; set; }
        //与线路关系
        public string SPPO_RWTT { get; set; }
        //所属地下水类型
        public string SPPO_GRTY { get; set; }
        //泉点类型
        public string SPPO_TYPE { get; set; }
        //特征
        public string SPPO_CHAR { get; set; }
        //雨季流量
        public string SPPO_RSFL { get; set; }
        //枯季流量
        public string SPPO_DSFL { get; set; }
        //取水规模
        public string SPPO_WISC { get; set; }
        //供水范围
        public string SPPO_WSRA { get; set; }
        //隧道建设对取水点影响
        public string SPPO_INTC { get; set; }
        //X坐标
        public string LOCA_NATE { get; set; }
        //Y坐标
        public string LOCA_NATN { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
