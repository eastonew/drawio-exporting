using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GeneticAlgorithm.Exporting.Draw.io
{
    public class mxBoxCell : mxCell
    {
        [XmlAttribute]
        public string value { get; set; }
        [XmlAttribute]
        public string vertex { get; set; }

        public mxBoxCell()
        {
            style = "rounded=1;whiteSpace=wrap;html=1";
            vertex = "1";
            parent = "1";
        }

    }
}
