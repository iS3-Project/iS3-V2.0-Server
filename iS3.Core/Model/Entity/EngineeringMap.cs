using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_EngineeringMap")]
    public class EngineeringMap:GISMap
    {
        public string MapTypeStr  { get; set; }
        [NotMapped]
        public EngineeringMapType MapType
        {
            get
            {
                EngineeringMapType type = EngineeringMapType.FootPrintMap;
                try
                {
                    type = (EngineeringMapType)Enum.Parse(typeof(EngineeringMapType), MapTypeStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        // Scale factor when the EngineeringMap is merged with world map
        public string Calibrated { get; set; }
        public Nullable<decimal> Scale { get; set; } 
        public Nullable<decimal> ScaleX { get; set; } 
        public Nullable<decimal> ScaleY { get; set; } 

        // ScaleZ for maps that are not footprint map.
        public Nullable<decimal> ScaleZ { get; set; } 
        public string LayerDefIDStr { get; set; }

        // Summary:
        //     Local Layers in a geodatabase
        [NotMapped]
        public List<LayerDef> LocalGdbLayersDef { get; set; }
    }
    public enum EngineeringMapType { FootPrintMap, GeneralProfileMap, Map3D }

}
