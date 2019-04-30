using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using iS3.Core;

namespace iS3.Geology.Model
{
    //水文地质单元
    [Table("Geology_HYUN")]
    public partial class HYUN : iS3AreaHandle
    {
        //工程ID
        public string PROJ_ID { get; set; }
        //水文地质单元ID
        public string HYUN_ID { get; set; }
        //地层代号
        public string HYUN_STCO { get; set; }
        //地层厚度
        public string HYUN_STDE { get; set; }
        //地层岩性
        public string HYUN_STLI { get; set; }
        //地下水类型
        public string HYUN_GRTY { get; set; }
        //泉/暗河流量
        public string HYUN_FLOW { get; set; }
        //地下径流模数
        public string HYUN_UNRM { get; set; }
        //富水性
        public string HYUN_WAAB { get; set; }
        
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
