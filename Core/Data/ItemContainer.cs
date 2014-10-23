using System;
using System.Xml.Serialization;

namespace Ingenio.CodeTest.Core.Data
{
    [Serializable]
    public class ItemContainer
    {
        public Item[] Items { get; set; }
    }
}