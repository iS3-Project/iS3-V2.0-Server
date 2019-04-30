using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //十字板剪切试验数据
    //
    [Table("Geology_VANE")]
    public class VANE : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验深度
        public Nullable<decimal> VANE_DPTH { get; set; }
        //试验集
        public string VANE_TESN { get; set; }
        //试验类型
        public string VANE_TYPE { get; set; }
        //剪切试验结果
        public string VANE_VANE { get; set; }
        //Vane test residual result
        public string VANE_IVAR { get; set; }
        //试验日期
        public Nullable<System.DateTime> VANE_DATE { get; set; }
        //Details of vane test, vane size
        public string VANE_REM { get; set; }
        //Details of weather and environmental conditions during test 
        public string VANE_ENV { get; set; }
        //Test method
        public string VANE_METH { get; set; }
        //Name of testing organisation
        public string VANE_CONT { get; set; }
        //Accrediting body and reference number (when appropriate)
        public string VANE_CRED { get; set; }
        //Test status
        public string TEST_STAT { get; set; }
        
        public string GEOL_STAT { get; set; }
        public string FILE_FSET { get; set; }
    }
}
