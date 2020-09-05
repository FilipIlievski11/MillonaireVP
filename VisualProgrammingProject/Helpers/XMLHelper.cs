using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VisualProgrammingProject.Helpers
{
    public class XMLHelper
    {
        public static ObjectType ReadXml<ObjectType>(string fileName)
        {
            using (var sw = new StreamReader(fileName))
            {
                return (ObjectType)new XmlSerializer(typeof(ObjectType)).Deserialize(sw);
            }
        }

        public static void SaveXml<ObjectType>(ObjectType o, string fileName)
        {
            using (var sw = new StreamWriter(fileName))
            {
                new XmlSerializer(typeof(ObjectType)).Serialize(sw, o);
            }
        }
        public static ObjectType ReadXmlString<ObjectType>(string xmlString)
        {
            using (var sw = new StringReader(xmlString))
            {
                return (ObjectType)new XmlSerializer(typeof(ObjectType)).Deserialize(sw);
            }
        }

        public static string SaveXmlString<ObjectType>(ObjectType o)
        {
            using (var sw = new StringWriter())
            {
                new XmlSerializer(typeof(ObjectType)).Serialize(sw, o);
                return sw.ToString();
            }
        }
    }
}
