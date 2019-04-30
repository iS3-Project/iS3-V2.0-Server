using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //载荷板试验
    //
    [Table("Geology_PLTG")]
    public class PLTG : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验底埋深
        public Nullable<decimal> PLTG_DPTH { get; set; }
        //试验集
        public string PLTG_TESN { get; set; }
        //负载周期
        public string PLTG_CYC { get; set; }
        //载荷板直径
        public Nullable<decimal> PLTG_PDIA { get; set; }
        //包括设备质量在内的负载
        public Nullable<decimal> PLTG_SEAT { get; set; }
        //Factor a0
        public Nullable<decimal> PLTG_FA0 { get; set; }
        //Factor a1
        public Nullable<decimal> PLTG_FA1 { get; set; }
        //Factor a2
        public Nullable<decimal> PLTG_FA2 { get; set; }
        //变形模量
        public Nullable<decimal> PLTG_SMOD { get; set; }
        //N二次加载周期弹性模量
        public Nullable<decimal> PLTG_EV2 { get; set; }
        //地基反力系数
        public Nullable<decimal> PLTG_MOSR { get; set; }
        //弹性模量
        public Nullable<decimal> PLTG_EMOD { get; set; }
        //试验日期
        public  Nullable<System.DateTime> PLTG_DATE { get; set; }
        //Amount of stabiliser added
        public Nullable<decimal> PLTG_STAB { get; set; }
        //Type of stabiliser added
        public string PLTG_STYP { get; set; }
        //备注
        public string PLTG_REM { get; set; }
        //试验时的气候、环境细节
        public string PLTG_ENV { get; set; }
        //测试方法
        public string PLTG_METH { get; set; }
        //测试机构名称
        public string PLTG_CONT { get; set; }
        //认证机构和参考编号
        public string PLTG_CRED { get; set; }
        //测试状态
        public string TEST_STAT { get; set; }
        //地层记录代码或编号
        public string GEOL_STAT { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
