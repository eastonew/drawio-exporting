using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GeneticAlgorithm.Exporting.Draw.io
{
    public class mxGraphModel
    {
        [XmlAttribute]
        public int dx;
        [XmlAttribute]
        public int dy;
        [XmlAttribute]
        public int page;
        [XmlAttribute]
        public int pageScale;
        [XmlAttribute]
        public int pageWidth;
        [XmlAttribute]
        public int pageHeight;

        public mxCell[] root { get; set; }

        public mxGraphModel()
        {
            dx = 1000;
            dy = 1000;
            page = 1;
            pageScale = 1;
            pageWidth = 1000;
            pageHeight = 1000;
        }

    }
}
