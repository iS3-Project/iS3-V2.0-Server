using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_GISDef")]
    public class GISDef:iS3AreaHandle
    {
        public string LayerName { get; set; }
    }
}
