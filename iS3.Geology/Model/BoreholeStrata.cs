using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    [Table("Geology_BoreholeStrata")]
    public class BoreholeStrata:iS3AreaHandle
    {
        public string OBJECTID { get; set; }
        public Nullable<int> StratumSequenceInBorehole { get; set; }
        public Nullable<int> StratumSectionID { get; set; }
        public Nullable<int> SectionSequenceBorhole { get; set; }
        public string SectionSequenceStrata { get; set; }
        public double ElevationOfStratumBottom { get; set; }
        public Nullable<int> BoreholeID { get; set; }
        public Nullable<int> StratumID { get; set; }
        [NotMapped]
        public double Top { get; set; }
        [NotMapped]
        public double Base { get; set; }
    }
}
