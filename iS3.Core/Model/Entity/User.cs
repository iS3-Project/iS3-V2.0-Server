using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_User")]
    public class User : iS3AreaHandle
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
    }
}
