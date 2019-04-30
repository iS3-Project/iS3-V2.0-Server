using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using iS3.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace iS3.Monitoring
{
    public class MonPoint: iS3AreaHandle
    {
        // Summary:
        //    reference point name
        public string refPointName { get; set; }
        // Summary:
        //    distance to the reference point
        public Nullable<decimal> distanceX { get; set; }
        public Nullable<decimal> distanceY { get; set; }
        public Nullable<decimal> distanceZ { get; set; }
        // Summary:
        //    Installation date and time
        public Nullable<DateTime> time { get; set; }
        // Summary:
        //    Instrument detail
        public string instrumentDetail { get; set; }
        // Summary:
        //    Bearing of monitoring axis (A, B, C): in degree
        public Nullable<decimal> bearingA { get; set; }
        public Nullable<decimal> bearingB { get; set; }
        public Nullable<decimal> bearingC { get; set; }
        // Summary:
        //    Inclination of instrument axis (A, B, C): in degree
        public Nullable<decimal> inclinationA { get; set; }
        public Nullable<decimal> inclinationB { get; set; }
        public Nullable<decimal> inclinationC { get; set; }
        // Summary:
        //    Reading sign convention in direction (A, B, C)
        public string readingSignA { get; set; }
        public string readingSignB { get; set; }
        public string readingSignC { get; set; }
        // Summary:
        //    componennt count
        public int componentCount { get; set; }
        // Summary:
        //    Component names
        public string componentNames { get; set; }
        // Summary:
        //    Remarks
        public string remarks { get; set; }
        // Summary:
        //    Contractor who installed monitoring instrument
        public string contractor { get; set; }
        // Summary:
        //    Associated file reference
        public string fileName { get; set; }

        [NotMapped]
        // Summary:
        //    readings dictionary - reading component indexed 
        public Dictionary<string, List<MonReading>> readingsDict;
        [NotMapped]
        public List<MonComponent> monComponentList;
    }
}
