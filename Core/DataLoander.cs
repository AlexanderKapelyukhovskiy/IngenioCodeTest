using Ingenio.CodeTest.Core.Data;
using Ingenio.CodeTest.Core.Utils;

namespace Ingenio.CodeTest.Core
{
    public class DataLoander
    {
        public ItemContainer Load(string xml)
        {
            return Serializer.DeserializeObjectFromXml<ItemContainer>(xml);
        }
    }
}