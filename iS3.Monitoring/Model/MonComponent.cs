using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Monitoring
{
    public class MonComponent
    {
        public string componentName { get; set; }
        public List<MonReading> readings { get; set; }
    }
}
