using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Ingenio.CodeTest.Core.Data
{
    [Serializable]
    public class Item
    {
        [XmlAttribute("categoryId")]
        public int CategoryId { get; set; }
        [XmlAttribute("parentCategoryId")]
        public int ParentCategoryId { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("keywords")]
        public string Keywords { get; set; }
    }
}