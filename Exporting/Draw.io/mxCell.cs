using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GeneticAlgorithm.Exporting.Draw.io
{
    [XmlInclude(typeof(mxArrowCell))]
    [XmlInclude(typeof(mxBoxCell))]
    public class mxCell
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string parent { get; set; }
        public mxGeometry mxGeometry { get; set; }
        [XmlAttribute]
        public string style { get; set; }

        public mxCell()
        {
        }
    }
}
