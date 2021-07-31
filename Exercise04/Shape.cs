using Aspose.Pdf.Drawing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Exercise04
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    public abstract class Shape
    {
        public static string Colour { get; set; }
        public abstract double Area { get; }

    }

    
}



