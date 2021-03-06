﻿using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace InvoiceXpressDotNet
{
    public static class XmlExtensions
    {
        public static string XmlSerializeToString(this object objectInstance)
        {
            
            var xml = new XmlWriterSettings();
            xml.Indent = false;
            xml.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(stream, xml))
            {
                var serializer = new XmlSerializer(objectInstance.GetType());
                var ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
                serializer.Serialize(writer, objectInstance, ns);
                return stream.ToString();
            }

            
        }


        public static T DeserializeXml<T>(this string xmlData, bool removeEmptyElements = true) where T : class
        {
            string xmlDeserialize = removeEmptyElements
                ? Utils.CleanXml(xmlData)
                : xmlData;

            Trace.WriteLine(xmlDeserialize);

            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xmlDeserialize))
                return (T) serializer.Deserialize(reader);
        }
    }
}