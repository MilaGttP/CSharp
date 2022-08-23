
using System.Runtime.Serialization;
using System.Xml;

namespace XMLOperations
{
    public class XMLOperation
    {
        public static void Serialize <T> (T obj, string fileName)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings() { Indent = true, IndentChars = "\t", };
            XmlWriter writer = XmlWriter.Create(fileName, settings);
            serializer.WriteObject(writer, obj);
            writer.Close();
            if (!File.Exists(fileName)) throw new FileNotFoundException(fileName);
        }
        public static T Deserialize <T> (string fileName)
        {
            if (!File.Exists(fileName)) throw new FileNotFoundException(fileName);
            FileStream stream = new FileStream(fileName, FileMode.Open);
            XmlTextReader reader = new XmlTextReader(stream);
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            T obj = (T)serializer.ReadObject(reader, true);
            reader.Close(); stream.Close();
            return obj;
        }
    }
}
