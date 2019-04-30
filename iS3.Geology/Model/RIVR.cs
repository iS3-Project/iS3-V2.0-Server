using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //河流
    [Table("Geology_RIVR")]
    public partial class RIVR : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        public int FID { get; set; }
 
        //河流名称
        public string RIVR_NAME { get; set; }


        //位置描述
        public string RIVR_LOCA { get; set; }

        //所属水系
        public string RIVR_SYS { get; set; }
        //汇流面积
        public string RIVR_CFAR { get; set; }
        //旱季流量
        public string RIVR_DRYF { get; set; }
        //雨季流量
        public string RIVR_RAIF { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
