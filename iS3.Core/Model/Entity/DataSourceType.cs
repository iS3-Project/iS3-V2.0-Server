using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_DataSourceType")]
    public class DataSourceType:iS3AreaHandle
    {
        public string Name { get; set; }
        public string CODE { get; set; }
        public string Remark { get; set; }
    }
}
