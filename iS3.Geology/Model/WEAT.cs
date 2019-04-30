using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //气象信息
    [Table("Geology_WEAT")]
    public partial class WEAT:iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //气象区ID
        public string WEAT_ID { get; set; }
        //几何元素类型
        public string WEAT_GEOM { get; set; }
        //几何元素第一坐标组
        public string WEAT_COOR1 { get; set; }
        //几何元素第二坐标组
        public string WEAT_COOR2 { get; set; }
        //气候类型
        public string WEAT_TYPE  { get; set; }
        //气候概述
        public string WEAT_DESC { get; set; }
        //年平均降水量
        public string WEAT_MAP { get; set; }
        //年平均温度
        public Nullable<decimal> WEAT_MAT { get; set; }
        //雨季时间
        public string WEAT_RAIN { get; set; }
        //备注
        public string WEAT_REM { get; set; }
        //关联文件索引
        public string FILE_FSET { get; set; }
    }
}
