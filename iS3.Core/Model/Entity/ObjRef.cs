using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_ObjRef")]
    public class ObjRef: iS3AreaHandle
    {
        public string ObjDomain { get; set; }
        public string ObjType { get; set; }
        public int ObjID { get; set; }

        public string Layer { get; set; }
        public int FeatureID { get; set; }
        //2D or 3D
        public string FeatureType { get; set; }

    }
}
