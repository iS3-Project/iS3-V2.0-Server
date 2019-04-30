using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //钻孔数据表
    [Table("Geology_BOHO")]
    public partial class BOHO : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //钻孔ID
        public string BOHO_ID { get; set; }
        //钻孔里程
        public string BOHO_MILE { get; set; }
        //孔口标高
        public Nullable<decimal> BOHO_ELET { get; set; }
        //孔底标高
        public Nullable<decimal> BOHO_ELEB { get; set; }
        //地下水位埋深
        public Nullable<decimal> BOHO_DEGR { get; set; }
        //地下水位
        public Nullable<decimal> BOHO_GRTA { get; set; }
        //X坐标
        public Nullable<decimal> LOCA_NATE { get; set; }
        //Y坐标
        public Nullable<decimal> LOCA_NATN { get; set; }
        //备注
        public string LOCA_REM { get; set; }
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
