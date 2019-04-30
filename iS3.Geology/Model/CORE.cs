using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;


namespace iS3.Geology.Model
{
    //取芯信息
    [Table("Geology_CORE")]
    public partial class CORE : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //顶埋深
        public Nullable<decimal> CORE_TOP { get; set; }
        //底埋深
        public Nullable<decimal> CORE_BASE { get; set; }
        //岩心采取率（TCR）
        public Nullable<decimal> CORE_PREC { get; set; }
        //土心采取率（SCR）
        public Nullable<decimal> CORE_SREC { get; set; }
        //岩石质量指标（RQD）
        public Nullable<decimal> CORE_RQD { get; set; }
        //取芯直径
        public Nullable<decimal> CORE_DIAM { get; set; }
        //取芯持续时间
        public Nullable<DateTime> CORE_DURN { get; set; }
        //岩芯描述
        public string CORE_DESC { get; set; }
        //备注
        public string CORE_REM { get; set; }
        //关联文件（现场日志表）
        public string FILE_FSET { get; set; }
    }
}
