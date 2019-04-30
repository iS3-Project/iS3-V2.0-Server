using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iS3.Core.Model;

namespace iS3.Core.Server.Model
{
    [Table("Project_UserToken")]
    public partial class UserToken: iS3AreaHandle
    {
        public string Token { get; set; }
        public int UId { get; set; }
        public string Permission { get; set; }
        public string UserType { get; set; }
        public DateTime Timeout { get; set; }
    }
}
