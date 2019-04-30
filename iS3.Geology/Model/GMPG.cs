using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;


namespace iS3.Geology.Model
{
    //地貌基本信息
    [Table("Geology_GMPG")]
    public partial class GMPG : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //地貌区ID
        public string GMPG_ID { get; set; }
        //几何元素类型
        public string RSVR_GEOM { get; set; }
        //几何元素第一坐标组
        public string RSVR_COOR1 { get; set; }
        //几何元素第二坐标组
        public string RSVR_COOR2 { get; set; }
        //分布范围
        public string GMPG_DSRG { get; set; }
        //成因
        public string GMPG_FMRS { get; set; }
        //类型
        public string GMPG_TYPE { get; set; }
        //形态特征
        public string GMPG_CHAR { get; set; }
        public string GMPG_REM { get; set; }
        //关联文件索引
        public string FILE_FSET { get; set; }
    }
}
