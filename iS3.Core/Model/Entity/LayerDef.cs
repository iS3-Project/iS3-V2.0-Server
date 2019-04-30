using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace iS3.Core.Model
{
    [Table("Project_LayerDef")]
    public class LayerDef: iS3AreaHandle
    {
        public string Name { get; set; }
        public string GeometryTypeStr { get; set; }

        [NotMapped]
        public GeometryType GeometryType
        {
            get
            {
                GeometryType type = GeometryType.Point;
                try
                {
                    type = (GeometryType)Enum.Parse(typeof(GeometryType), GeometryTypeStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string IsVisibleStr { get; set; }
        [NotMapped]
        public bool IsVisible
        {
            get
            {
                bool result = true;
                try
                {
                    result = bool.Parse(IsVisibleStr);
                }
                catch (Exception ex)
                {
                    return result;
                }

                return result;
            }
        }
        // Layer display options
        public string ColorStr { get; set; }
        [NotMapped]
        public Color Color
        {
            get
            {
                Color type = Colors.Black ;
                try
                {
                    type = (Color)ColorConverter.ConvertFromString(ColorStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string SelectionColorStr { get; set; }
        [NotMapped]
        public Color SelectionColor
        {
            get
            {
                Color type = Colors.Red;
                try
                {
                    type = (Color)ColorConverter.ConvertFromString(SelectionColorStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public Nullable<decimal> MarkerSize { get; set; }
        public string MarkerStyleStr { get; set; }
        [NotMapped]
        public SimpleMarkerStyle MarkerStyle
        {
            get
            {
                SimpleMarkerStyle type = SimpleMarkerStyle.Circle;
                try
                {
                    type = (SimpleMarkerStyle)Enum.Parse(typeof(SimpleMarkerStyle), MarkerStyleStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string LineStyleStr { get; set; }
        [NotMapped]
        public SimpleLineStyle LineStyle
        {
            get
            {
                SimpleLineStyle type = SimpleLineStyle.Solid;
                try
                {
                    type = (SimpleLineStyle)Enum.Parse(typeof(SimpleLineStyle), LineStyleStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string FillStyleStr { get; set; }
        [NotMapped]
        public SimpleFillStyle FillStyle
        {
            get
            {
                SimpleFillStyle type = SimpleFillStyle.Solid;
                try
                {
                    type = (SimpleFillStyle)Enum.Parse(typeof(SimpleFillStyle), FillStyleStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string OutlineColorStr { get; set; }
        [NotMapped]
        public Color OutlineColor
        {
            get
            {
                Color type = Colors.Black;
                try
                {
                    type = (Color)ColorConverter.ConvertFromString(OutlineColorStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public Nullable<decimal> LineWidth { get; set; }

        // Renderer definition: override layer display options if specified.
        //public RendererDef RendererDef { get; set; }

        // Layer labelling options
        public string EnableLabelStr { get; set; }
        [NotMapped]
        public bool EnableLabel
        {
            get
            {
                bool result = true;
                try
                {
                    result = bool.Parse(EnableLabelStr);
                }
                catch (Exception ex)
                {
                    return result;
                }

                return result;
            }
        }
        public string LabelTextExpression { get; set; }
        public string LabelWhereClause { get; set; }
        public string LabelColorStr { get; set; }
        [NotMapped]
        public Color LabelColor
        {
            get
            {
                Color type = Colors.Black;
                try
                {
                    type = (Color)ColorConverter.ConvertFromString(LabelColorStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string LabelBackgroundColorStr { get; set; }
        [NotMapped]
        public Color LabelBackgroundColor
        {
            get
            {
                Color type = Colors.Black;
                try
                {
                    type =(Color)ColorConverter.ConvertFromString(LabelBackgroundColorStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string LabelBorderLineColorStr { get; set; }
        [NotMapped]
        public Color LabelBorderLineColor
        {
            get
            {
                Color type = Colors.Black;
                try
                {
                    type = (Color)ColorConverter.ConvertFromString(LabelBackgroundColorStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public Nullable<decimal> LabelBorderLineWidth { get; set; }
        public string LabelFontFamily { get; set; } 
        public Nullable<decimal> LabelFontSize { get; set; } 
        public string LabelFontStyleStr { get; set; }
        [NotMapped]
        public SymbolFontStyle LabelFontStyle
        {
            get
            {
                SymbolFontStyle type = SymbolFontStyle.Normal;
                try
                {
                    type = (SymbolFontStyle)Enum.Parse(typeof(SymbolFontStyle), LabelFontStyleStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string LabelFontWeightStr { get; set; }
        [NotMapped]
        public SymbolFontWeight LabelFontWeight
        {
            get
            {
                SymbolFontWeight type = SymbolFontWeight.Normal;
                try
                {
                    type = (SymbolFontWeight)Enum.Parse(typeof(SymbolFontWeight), LabelFontWeightStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
        public string LabelTextDecorationStr { get; set; }
        [NotMapped]
        public SymbolTextDecoration LabelTextDecoration
        {
            get
            {
                SymbolTextDecoration type = SymbolTextDecoration.None;
                try
                {
                    type = (SymbolTextDecoration)Enum.Parse(typeof(SymbolTextDecoration), LabelTextDecorationStr);
                }
                catch (Exception ex)
                {
                    return type;
                }

                return type;
            }
        }
    }
    // Summary:
    //     Geometry Type Enumeration
    public enum GeometryType
    {
        // Summary:
        //     Unknown geometry type
        Unknown = 0,
        //
        // Summary:
        //     Point
        Point = 1,
        //
        // Summary:
        //     Multipoint
        Multipoint = 2,
        //
        // Summary:
        //     Polyline
        Polyline = 3,
        //
        // Summary:
        //     Polygon
        Polygon = 4,
        //
        // Summary:
        //     Envelope
        Envelope = 5,
    }

    // Represents the style of a ISimpleMarkerSymbol
    public enum SimpleMarkerStyle
    {
        Circle = 0,
        Cross = 1,
        Diamond = 2,
        Square = 3,
        X = 4,
        Triangle = 5,
    }

    // Represents the style of a ISimpleFillSymbol
    public enum SimpleFillStyle
    {
        BackwardDiagonal = 0,
        Cross = 1,
        DiagonalCross = 2,
        ForwardDiagonal = 3,
        Horizontal = 4,
        Null = 5,
        Solid = 6,
        Vertical = 7,
    }

    // Represents the style of a ISimpleLineSymbol
    public enum SimpleLineStyle
    {
        Dash = 0,
        DashDot = 1,
        DashDotDot = 2,
        Dot = 3,
        Null = 4,
        Solid = 5,
    }

    // Summary:
    //     Describes the font style to be used when drawing text symbol.  The default
    //     value is SymbolFontStyle.Normal.
    public enum SymbolFontStyle
    {
        // Summary:
        //     font-style : normal (default)
        Normal = 0,
        //
        // Summary:
        //     font-style : italic
        Italic = 1,
    }

    // Summary:
    //     Describes the font weight to be used when drawing text symbol.  The default
    //     value is SymbolFontWeight.Normal.
    public enum SymbolFontWeight
    {
        // Summary:
        //     font-wegiht : normal (default)
        Normal = 0,
        //
        // Summary:
        //     font-weight : bold
        Bold = 1,
    }

    // Summary:
    //     Describes the text decoration to be used when drawing text symbol.  The default
    //     value is SymbolTextDecoration.None.
    public enum SymbolTextDecoration
    {
        // Summary:
        //     text-decoration : none (default)
        None = 0,
        //
        // Summary:
        //     text-decoration : line-through
        LineThrough = 1,
        //
        // Summary:
        //     text-decoration : underline
        Underline = 2,
    }
}
