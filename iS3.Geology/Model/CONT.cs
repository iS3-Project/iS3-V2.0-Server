using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //等高线
    [Table("Geology_CONT")]
    public partial class CONT : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //等高线ID
        public Nullable<int> CONT_ID { get; set; }
        //等高线海拔
        public Nullable<int> CONT_ELEV { get; set; }
        //备注
        public string CONT_MEMO { get; set; }

           
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
