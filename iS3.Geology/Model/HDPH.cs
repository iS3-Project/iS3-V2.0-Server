using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;


namespace iS3.Geology.Model
{
    //勘探孔基本信息
    [Table("Geology_HDPH")]
    public partial class HDPH : iS3AreaHandle
    {
        //顶埋深
        public Nullable<decimal> HDPH_TOP { get; set; }

        //开始时间
        public string HDPH_STAR { get; set; }
        //结束时间
        public string HDPH_ENDD { get; set; }
        //
        public Nullable<decimal> HDPH_CORX { get; set; }
        //
        public Nullable<decimal> HDPH_CORY { get; set; }
        //
        public string HDPH_CHAI { get; set; }
        //
        public Nullable<decimal> HDPH_WATER { get; set; }

        //备注
        public string HDPH_REM { get; set; }
        //
        public Nullable<decimal> HDPH_ORNT { get; set; }
        //
        public Nullable<decimal> HDPH_INCL { get; set; }

        //
        public string HDPH_DIAM { get; set; }


        //
        public string HDPH_CONT { get; set; }

        //关联文件（钻孔日志。钻孔方向数据等）
        public string FILE_FSET { get; set; }
    }
}
