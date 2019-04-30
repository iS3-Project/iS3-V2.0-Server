using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //特殊性岩土
    [Table("Geology_SPEC")]
    public partial class SPEC : iS3AreaHandle
    {

        //特殊性岩土区ID
        public string SPEC_ID { get; set; }

        //特殊性岩土类型
        public string SPEC_TYPE { get; set; }
        //分布范围
        public string SPEC_DSRG { get; set; }
        //面积
        public string SPEC_AREA { get; set; }
        //工程地质性质
        public string SPEC_EGP { get; set; }
        //备注
        public string SPEC_REM { get; set; }
        //
        public string SPEC_DISA { get; set; }
        //
        public string SPEC_LAWD { get; set; }

        //关联文件索引
        public string FILE_FSET { get; set; }
    }
}
