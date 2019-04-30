using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Geology.Model
{
    [Table("Geology_Borehole")]
    public partial class Borehole:iS3AreaHandle
    {
        public string OBJECTID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public Nullable<int> StratumSection { get; set; }
        public Nullable<int> SectionSequence { get; set; }
        public string BoreholeType { get; set; }
        public double TopElevation { get; set; }
        public double BoreholeLength { get; set; }
        public string Mileage { get; set; }
        public Nullable<double> Xcoordinate { get; set; }
        public Nullable<double> Ycoordinate { get; set; }
        [NotMapped]
        public List<BoreholeStrata> BoreholeStratas { get; set; } = new List<BoreholeStrata>();
    }
}
