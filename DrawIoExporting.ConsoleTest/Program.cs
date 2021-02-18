using GeneticAlgorithm.Exporting.Draw.io;
using System;
using System.IO;

namespace DrawIoExporting.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a simple diagram with two boxes and an arrow linking them
            mxGraphModel model = new mxGraphModel()
            {
                dx = 300,
                dy = 300,
                pageWidth = 300,
                pageHeight = 300
            };
            model.root = GenerateNodes();
            mxfile file = new mxfile(model);
            string fileExport = file.Export();
            File.WriteAllText("testdiagram4.drawio", fileExport);
        }

        static mxCell[] GenerateNodes()
        {
            mxCell[] nodes = new mxCell[5];
            //create the document parent node - not sure if this is needed but seems to be present in all diagrams generated online
            nodes[0] = new mxCell() { id = "0" };
            //create the parent for the elements
            nodes[1] = new mxCell() { id = "1", parent = "0" };

            nodes[2] = new mxBoxCell()
            {
                id = "2",
                parent = "1",
                mxGeometry = new mxGeometry()
                {
                    height = "50",
                    width = "70",
                    x = "50",
                    y = "50",
                },
                value = "Box 1"
            };
            nodes[3] = new mxBoxCell()
            {
                id = "3",
                parent = "1",
                mxGeometry = new mxGeometry()
                {
                    height = "50",
                    width = "70",
                    x = "200",
                    y = "50",
                },
                value = "Box 2"
            };
            nodes[4] = new mxArrowCell()
            {
                id = "2-3",
                parent = "1",
                mxGeometry = new mxGeometry()
                {
                    relative = "1"
                },
                source = "2",
                target = "3"
            };

            return nodes;
        }
    }
}
