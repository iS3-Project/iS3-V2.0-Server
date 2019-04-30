using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //静力触探试验
    //
    [Table("Geology_SCPG")]
    public class SCPG : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验集
        public string SCPG_TESN { get; set; }
        //Cone test type
        public string SCPG_TYPE { get; set; }
        //Cone reference
        public string SCPG_REF { get; set; }
        //Surface area of cone tip
        public Nullable<decimal> SCPG_CSA { get; set; }
        //Nominal rate of penetration of the cone
        public Nullable<decimal> SCPG_RATE { get; set; }
        //Type of filter material used
        public string SCPG_FILT { get; set; }
        //Friction reducer used
        public string SCPG_FRIC { get; set; }
        //Groundwater level at time of test
        public Nullable<decimal> SCPG_WAT { get; set; }
        //Origin of water level in SCPG_WAT
        public string SCPG_WATA { get; set; }
        //Comments on testing and basis of any interpretated parameters included in SCPT and SCPP
        public string SCPG_REM { get; set; }
        //Details of weather and environmental conditions during test
        public string SCPG_ENV { get; set; }
        //Subcontractors name
        public string SCPG_CONT { get; set; }
        //Standard followed for testing
        public string SCPG_METH { get; set; }
        //Accrediting body and reference number (when appropriate)
        public string SCPG_CRED { get; set; }
        //Cone area ratio used to calculate qt
        public Nullable<decimal> SCPG_CAR { get; set; }
        //Sleeve area ratio used to calculate ft
        public Nullable<decimal> SCPG_SLAR { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
