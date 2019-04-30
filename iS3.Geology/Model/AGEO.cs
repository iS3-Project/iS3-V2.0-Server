using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //不良地质
    [Table("Geology_AGEO")]
    public partial class AGEO : iS3AreaHandle
    {

        //不良地质现象区ID
        public string AGEO_ID { get; set; }
        //不良地质现象类型
        public string AGEO_TYPE { get; set; }
        //分布范围
        public string AGEO_DSRG { get; set; }
        //面积
        public string AGEO_AREA { get; set; }
        //工程地质性质
        public string AGEO_EGP { get; set; }
        //发展规律
        public string AGEO_LAWD { get; set; }
        //备注
        public string AGEO_REM { get; set; }
        //
        public string AGEO_DISA { get; set; }
        //关联文件索引
        public string FILE_FSET { get; set; }
    }
}
