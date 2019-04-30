using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //水化学数据采样
    [Table("Geology_HYCH")]
    public partial class HYCH : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //采样位置
        public string HYCH_LOCA { get; set; }
        //pH值
        public Nullable<decimal> HYCH_PH { get; set; }
        //硬度
        public Nullable<decimal> HYCH_HARD { get; set; }
        //钾离子含量
        public Nullable<decimal> HYCH_K { get; set; }
        //钠离子含量
        public Nullable<decimal> HYCH_NA { get; set; }
        //钙离子含量
        public Nullable<decimal> HYCH_GA { get; set; }
        //镁离子含量
        public Nullable<decimal> HYCH_MG { get; set; }
        //碳酸氢根含量
        public Nullable<decimal> HYCH_HCO3 { get; set; }
        //硫酸根含量
        public string HYCH_SO4 { get; set; }
        //氯离子含量
        public Nullable<decimal> HYCH_CL { get; set; }
        //化学类型
        public string HYCH_CHTY { get; set; }
        //
        public string HYCH_REM { get; set; }

        //关联文件
        public string FILE_FSET { get; set; }
    }
}
