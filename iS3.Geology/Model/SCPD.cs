using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //静力触探试验数据
    //
    [Table("Geology_SCPD")]
    public class SCPD : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验集
        public string SCPG_TESN { get; set; }
        //Depth of result
        public Nullable<decimal> SCPD_DPTH { get; set; }
        //Cone resistance (qc)
        public Nullable<decimal> SCPD_RES { get; set; }
        //Local unit side friction resistance (fs)
        public Nullable<decimal> SCPD_FRES { get; set; }
        //Face porewater pressure (u1)
        public Nullable<decimal> SCPD_PWP1 { get; set; }
        //Shoulder porewater pressure (u2)
        public Nullable<decimal> SCPD_PWP2 { get; set; }
        //Top of sleeve porewater pressure (u3)
        public Nullable<decimal> SCPD_PWP3 { get; set; }
        //Conductivity
        public Nullable<decimal> SCPD_CON { get; set; }
        //Temperature
        public Nullable<decimal> SCPD_TEMP { get; set; }
        //pH reading
        public Nullable<decimal> SCPD_PH { get; set; }
        //Slope indicator no. 1
        public Nullable<decimal> SCPD_SLP1 { get; set; }
        //Slope indicator no. 2
        public Nullable<decimal> SCPD_SLP2 { get; set; }
        //Redox potential reading
        public Nullable<decimal> SCPD_REDX { get; set; }
        //Magnetic flux – Total (calculated)
        public Nullable<decimal> SCPD_MAGT { get; set; }
        //Magnetic flux – X
        public Nullable<decimal> SCPD_MAGX { get; set; }
        //Magnetic flux – Y
        public Nullable<decimal> SCPD_MAGY { get; set; }
        //Magnetic flux – Z
        public Nullable<decimal> SCPD_MAGZ { get; set; }
        //Soil moisture
        public Nullable<decimal> SCPD_SMP { get; set; }
        //Natural gamma radiation
        public Nullable<decimal> SCPD_NGAM { get; set; }
        //Remarks
        public string SCPD_REM { get; set; }
        //Friction ratio (Rf)
        public Nullable<decimal> SCPD_FRR { get; set; }
        //Corrected cone resistance (qt) piezocone only
        public Nullable<decimal> SCPD_QT { get; set; }
        //Corrected sleeve resistance (ft) piezocone only
        public Nullable<decimal> SCPD_FT { get; set; }
        //Normalised cone resistance (Qt)
        public Nullable<decimal> SCPD_NQT { get; set; }
        //Normalised friction ratio (Fr)
        public Nullable<decimal> SCPD_NFR { get; set; }
        //Associated file reference (eg raw field data)
        public string FILE_FSET { get; set; }
        //Effective cone resistance (qe) piezocone only
        public Nullable<decimal> SCPD_QE { get; set; }
        //Bulk density of material (measured or assumed)
        public Nullable<decimal> SCPD_BDEN { get; set; }
        //Total vertical stress (based on SCPD_BDEN)
        public Nullable<decimal> SCPD_CPO { get; set; }
        //Effective vertical stress (calculated from SCPD_CPO and SCPD_ISPP or SCPG_WAT)
        public Nullable<decimal> SCPD_CPOD { get; set; }
        //Net cone resistance (qn)
        public Nullable<decimal> SCPD_QNET { get; set; }
        //Corrected friction ratio (Rf’) piezocone only
        public Nullable<decimal> SCPD_FRRC { get; set; }
        //Excess pore pressure (u-uo) piezocone only
        public Nullable<decimal> SCPD_EXPP { get; set; }
        //Pore pressure ratio (Bq) piezocone only
        public Nullable<decimal> SCPD_BQ { get; set; }
        //In situ pore pressure (uo) (measured or assumed where not simple hydrostatic based on SCPG_WAT)
        public Nullable<decimal> SCPD_ISPP { get; set; }
    }
}
