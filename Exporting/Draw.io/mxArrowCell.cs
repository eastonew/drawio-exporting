using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GeneticAlgorithm.Exporting.Draw.io
{
    public class mxArrowCell : mxCell
    {
        [XmlAttribute]
        public string source { get; set; }
        [XmlAttribute]
        public string target { get; set; }
        [XmlAttribute]
        public string edge { get; set; }

        public mxArrowCell()
        {
            mxGeometry = new mxGeometry();
            edge = "1";
            parent = "1";
            style = "edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=1;exitDx=0;exitDy=0;entryX=0.5;entryY=0;entryDx=0;entryDy=0;endArrow=none;endFill=0;";
        }

    }
}
