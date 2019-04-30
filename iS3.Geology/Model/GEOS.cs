using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;


namespace iS3.Geology.Model
{
    //地质构造信息
    [Table("Geology_GEOS")]
    public partial class GEOS : iS3AreaHandle
    {
        //构造ID
        public string GEOS_ID { get; set; }
        //构造名称
        public string GEOS_NAME { get; set; }
        //构造类型
        public string GEOS_TYPE { get; set; }
        //几何元素类型
        public string GEOS_GEOM { get; set; }
        //几何元素第一坐标组
        public string GEOS_COOR1 { get; set; }
        //几何元素第二坐标组
        public string GEOS_COOR2 { get; set; }
        //产状
        public string GEOS_ATTD { get; set; }
        //长度
        public Nullable<decimal> GEOS_LGTH { get; set; }
        //与线路关系
        public string GEOS_RELA { get; set; }
        //备注
        public string GEOS_REM { get; set; }
        //关联文件索引
        public string FILE_FSET { get; set; }
    }
}
