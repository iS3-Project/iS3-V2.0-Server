using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    // 注水试验记录表
    [Table("Geology_WITR")]
    public partial class WITR : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //次数
        public Nullable<int> WITR_FREQ { get; set; }
        //达到试验压力的时间
        public Nullable<System.DateTime> WITR_TTTP { get; set; }
        //恒压结束的时间
        public Nullable<System.DateTime> WITR_TECP { get; set; }
        //恒压持续时间
        public Nullable<decimal> WITR_CPTI { get; set; }
        //恒压时间内补入的水量
        public Nullable<decimal> WITR_WAAD { get; set; }
        //实测渗水量
        public Nullable<decimal> WITR_MWSE { get; set; }
        //负责人
        public string WITR_OBPE { get; set; }
        //备注
        public string WITR_MEMO { get; set; }

       
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
