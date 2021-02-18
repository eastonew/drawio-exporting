using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace GeneticAlgorithm.Exporting.Draw.io
{
    public class mxfile
    {
        [XmlAttribute(AttributeName = "host")]
        public string host;

        [XmlAttribute(AttributeName = "modified")]
        public DateTime modified;

        [XmlAttribute(AttributeName = "type")]
        public string type;

        [XmlAttribute(AttributeName = "version")]
        public string version;

        public mxDiagram diagram { get; set; }

        public mxfile()
        {
            host = "app.diagrams.net";
            modified = DateTime.UtcNow;
            type = "device";
            version = "13.7.3";
        }

        public mxfile(mxGraphModel model) : this()
        {
            Deflate(model);
        }

        public string Export()
        {
            string xml = String.Empty;
            XmlSerializer xsSubmit = new XmlSerializer(typeof(mxfile));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true,
                IndentChars = "",
                NewLineChars = "\n",
                NewLineHandling = NewLineHandling.Replace
            };
            using (var sw = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(sw, settings))
            {
                xsSubmit.Serialize(writer, this, ns);
                xml = sw.ToString();
            }
            return xml;
        }

        private void Deflate(mxGraphModel model)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(mxGraphModel));
            string xml = String.Empty;
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true,
                NewLineChars = "\n",
                NewLineHandling = NewLineHandling.Replace
            };
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            using (var sw = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(sw, settings))
            {
                xsSubmit.Serialize(writer, model, ns);
                xml = sw.ToString();
            }
            using (MemoryStream output = new MemoryStream())
            {
                using (DeflateStream gzip = new DeflateStream(output, CompressionLevel.NoCompression))
                using (StreamWriter writer = new StreamWriter(gzip, System.Text.Encoding.UTF8))
                {
                    writer.Write(xml);
                }


                diagram = new mxDiagram()
                {
                    diagram = output.ToArray()
                };
            }
        }
    }
}
