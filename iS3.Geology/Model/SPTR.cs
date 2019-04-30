using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;

namespace iS3.Geology.Model
{
    //标准贯入试验
    //
    [Table("Geology_SPTR")]
    public class SPTR : iS3AreaHandle
    {
        //位置ID
        public string LOCA_ID { get; set; }
        //试验顶深度
        public Nullable<decimal> SPTR_TOP { get; set; }
        //Number of blows for seating drive
        public Nullable<decimal> SPTR_SEAT { get; set; }
        //Number of blows for main test drive
        public Nullable<decimal> SPTR_MAIN { get; set; }
        //Total penetration for seating drive and test drive
        public Nullable<decimal> SPTR_NPEN { get; set; }
        //SPT ‘N’ value
        public Nullable<decimal> SPTR_NVAL { get; set; }
        //SPT reported result
        public string SPTR_REP { get; set; }
        //Casing depth at time of test
        public Nullable<decimal> SPTR_CAS { get; set; }
        //Depth to water at time of test
        public string SPTR_WAT { get; set; }
        //Type of SPT test
        public string SPTR_TYPE { get; set; }
        //Hammer serial number from manufacturer
        public string SPTR_HAM { get; set; }
        //Energy ratio of the hammer
        public Nullable<decimal> SPTR_ERAT { get; set; }
        //Self-weight penetration
        public Nullable<decimal> SPTR_SWP { get; set; }
        //Number of blows for 1st Increment (Seating)
        public Nullable<decimal> SPTR_INC1 { get; set; }
        //Number of blows for 2nd Increment (Seating)
        public Nullable<decimal> SPTR_INC2 { get; set; }
        //Number of blows for 1st Increment (Test)
        public Nullable<decimal> SPTR_INC3 { get; set; }
        //Number of blows for 2nd Increment (Test)
        public Nullable<decimal> SPTR_INC4 { get; set; }
        //Number of blows for 3rd Increment (Test)
        public Nullable<decimal> SPTR_INC5 { get; set; }
        //Number of blows for 4th Increment (Test)
        public Nullable<decimal> SPTR_INC6 { get; set; }
        //Penetration for 1st Increment (Seating Drive)
        public Nullable<decimal> SPTR_PEN1 { get; set; }
        //Penetration for 2nd Increment (Seating Drive)
        public Nullable<decimal> SPTR_PEN2 { get; set; }
        //Penetration for 1st Increment (Test)
        public Nullable<decimal> SPTR_PEN3 { get; set; }
        //Penetration for 2nd Increment (Test)
        public Nullable<decimal> SPTR_PEN4 { get; set; }
        //Penetration for 3rd Increment (Test)
        public Nullable<decimal> SPTR_PEN5 { get; set; }
        //Penetration for 4th Increment (Test)
        public Nullable<decimal> SPTR_PEN6 { get; set; }
        //SPT carried out in rock
        public string SPTR_ROCK { get; set; }
        //Remarks
        public string SPTR_REM { get; set; }
        //Details of weather and environmental conditions during test
        public string SPTR_ENV { get; set; }
        //Test method	
        public string SPTR_METH { get; set; }
        //Accrediting body and reference number (when appropriate)
        public string SPTR_CRED { get; set; }
        //Test status
        public string TEST_STAT { get; set; }
        //关联文件
        public string FILE_FSET { get; set; }
    }
}
