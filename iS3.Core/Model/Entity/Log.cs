using iS3.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_Log")]
    public class Log: iS3AreaHandle
    {
        public string Action { get; set; }
        public string Detail { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatorLoginName { get; set; }
    }
}
