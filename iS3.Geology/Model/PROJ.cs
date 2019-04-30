using iS3.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Geology.Model
{
    //施工进度信息
    //
    [Table("Geology_PROJ")]
    public class PROJ : iS3AreaHandle
    {
        //标段号
        public string LOCA_ID { get; set; }
        //左右幅
        public string EPRO_ID { get; set; }
        //记录时间
        public string EPRO_TYPE { get; set; }
        //终点桩号
        public string EPRO_SERV { get; set; }
        //施工面进度
        public string EPRO_DSRG { get; set; }
        //初衬进度
        public string EPRO_REM { get; set; }
        //二衬进度
        public string FILE_FSET { get; set; }
    }
}
