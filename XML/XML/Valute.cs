using System.Xml.Serialization;

namespace XML
{
    public class Valute
    {
        [XmlAttribute]
        public string Code { get; set; }

        [XmlElement]
        public string Nominal { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string Value { get; set; }
    }
}