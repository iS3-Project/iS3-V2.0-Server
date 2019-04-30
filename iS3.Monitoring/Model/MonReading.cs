using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core;
namespace iS3.Monitoring
{
    public class MonReading: iS3AreaHandle
    {
        // Summary:
        //     monitoring point name
        public string monPointName { get; set; }
        // Summary:
        //     reading date and time
        public DateTime time { get; set; }
        // Summary:
        //     reading component
        public string component { get; set; }
        // Summary:
        //    raw reading
        public string reading { get; set; }
        // Summary:
        //    reading value
        public decimal value { get; set; }
        // Summary:
        //    reading unit
        public string unit { get; set; }
    }
}
