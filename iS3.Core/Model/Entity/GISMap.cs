using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    public class GISMap : iS3AreaHandle
    {
        public string MapID { get; set; }
        public string LocalTileFileNameStr { get; set; }
        public string LocalMapFileNameStr { get; set; }
        public string LocalGeoDbFileNameStr { get; set; }

        public string MapUrl { get; set; }
        public Nullable<decimal> XMax { get; set; }
        public Nullable<decimal> XMin { get; set; }
        public Nullable<decimal> YMax { get; set; }
        public Nullable<decimal> YMin { get; set; }
        public Nullable<decimal> MinimumResolution { get; set; }
        public Nullable<decimal> MapRotation { get; set; }

        [NotMapped]
        public List<string> LocalTileFileNames
        {
            get
            {
                if ((LocalTileFileNameStr != null) && (LocalTileFileNameStr.Length > 0))
                {
                    return LocalTileFileNameStr.Split(',').ToList();
                }
                else
                    return new List<string>();
            }
        }
        [NotMapped]
        public List<string> LocalMapFileNames
        {
            get
            {
                if ((LocalMapFileNameStr != null) && (LocalMapFileNameStr.Length > 0))
                {
                    return LocalMapFileNameStr.Split(',').ToList();
                }
                else
                    return new List<string>();
            }
        }
        [NotMapped]
        public List<string> LocalGeoDbFileNames
        {
            get
            {
                if ((LocalGeoDbFileNameStr != null) && (LocalGeoDbFileNameStr.Length > 0))
                {
                    return LocalGeoDbFileNameStr.Split(',').ToList();
                }
                else
                    return new List<string>();
            }
        }

    }
}
