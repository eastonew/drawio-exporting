using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GeneticAlgorithm.Exporting.Draw.io
{
    public class mxDiagram
    {
        [XmlAttribute("id")]
        public string id;
        [XmlAttribute("name")]
        public string name;
        [XmlText]
        public byte[] diagram;

        public mxDiagram()
        {
            id = "1";
            name = "Page-1";
        }
    }
}
