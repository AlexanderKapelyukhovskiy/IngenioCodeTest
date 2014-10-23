using System.IO;
using System.Xml.Serialization;

namespace Ingenio.CodeTest.Core.Utils
{
    public class Serializer
    {
        public static string SerializeObjectToXml<T>(T toSerialize)
        {
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());
            using (var textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);

                return textWriter.ToString();
            }
        }

        public static T DeserializeObjectFromXml<T>(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            T result;
            using (TextReader reader = new StringReader(xml))
            {
                result = (T)xmlSerializer.Deserialize(reader);
            }
            return result;
        }
    }
}