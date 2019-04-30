using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //分水岭
    [Table("Geology_WASH")]
    public partial class WASH : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //分水岭ID
        public Nullable<int> WASH_ID { get; set; }
        //最高海拔
        public string WASH_HIGH { get; set; }
        //备注
        public string WASH_MEMO { get; set; }
           
        //关联文件
        public string FILE_FSET{ get; set; }
    }
}
