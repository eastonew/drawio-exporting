using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GeneticAlgorithm.Exporting.Draw.io
{
    public class mxGeometry
    {
        [XmlAttribute]
        public string relative;
        [XmlAttribute]
        public string x { get; set; }
        [XmlAttribute]
        public string y { get; set; }
        [XmlAttribute]
        public string width { get; set; }
        [XmlAttribute]
        public string height { get; set; }
        [XmlAttribute("as")]
        public string asDetail;

        public mxGeometry()
        {
            asDetail = "geometry";
        }
    }
}
