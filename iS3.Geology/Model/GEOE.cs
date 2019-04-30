using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    [Table("Geology_GEOE")]
    public partial class GEOE:iS3AreaHandle
    {
        //
        public string GEOE_ID { get; set; }
        //
        public string GEOE_SCHAI { get; set; }
        //
        public string GEOE_ECHAI { get; set; }
        //
        public Nullable<decimal> GEOE_LGTH { get; set; }
        //
        public string GEOE_METH { get; set; }
        //
        public string GEOE_RESU { get; set; }
        //
        public string GEOE_STAR { get; set; }
        //
        public string GEOE_ENDD { get; set; }
        //
        public string GEOE_CONT { get; set; }
        //
        public string GEOE_CREW { get; set; }
        //关联文件(掌子面照片或视频）

        public string FILE_FSET { get; set; }

    }
}
