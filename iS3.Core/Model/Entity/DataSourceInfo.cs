using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_DataSourceInfo")]
    public class DataSourceInfo:iS3AreaHandle
    {
        public int DSType { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Port { get; set; }
        public string DBName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Remark { get; set; }
    }
}
