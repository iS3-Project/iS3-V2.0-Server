using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //注水记录数
    [Table("Geology_WADD")]
    public partial class WADD : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //顶埋深
        public Nullable<decimal> WADD_TOP { get; set; }
        //底埋深
        public Nullable<decimal> WADD_BASE { get; set; }
        //注入水量
        public Nullable<decimal> WADD_VOLM { get; set; }
        //与注水有关的钻进方法（HDPH_TYPE）的缩写
        public Nullable<decimal> WADD_METH { get; set; }
        //备注（注水设备，方法）
        public string WADD_REM { get; set; }
        //关联文件（钻孔日志）
        public string FILE_FSET { get; set; }
    }
}
