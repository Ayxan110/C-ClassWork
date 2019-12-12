using System.Xml.Serialization;

namespace XML
{
    public class ValType
    {
        [XmlAttribute]
        public string Type { get; set; }
        [XmlElement]
        public Valute[] Valute { get; set; }
    }
}