using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //水源保护区
    [Table("Geology_WSPA")]
    public partial class WSPA : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //水源名称
        public string WSPA_NAME { get; set; }
        //保护区级别
        public string WSPA_CLAS { get; set; }
        //水源面积
        public Nullable<decimal> WSPA_AREA { get; set; }
      
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
