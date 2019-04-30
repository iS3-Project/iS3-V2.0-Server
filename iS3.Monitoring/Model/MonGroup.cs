using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace iS3.Monitoring
{
    public class MonGroup: iS3AreaHandle
    {
        public string groupShape { get; set; }

        public string monPntNamesStr { get; set; }

        [NotMapped]
        // Summary:
        //    Monitoring points names in the group
        public string[] monPntNames { get; set; }
        [NotMapped]
        // Summary:
        //   Monitoring points
        public Dictionary<string, MonPoint> monPntDict { get; set; }
    }
}
