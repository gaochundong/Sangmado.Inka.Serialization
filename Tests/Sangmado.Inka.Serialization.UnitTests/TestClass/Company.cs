using System;
using System.Xml.Serialization;

namespace Sangmado.Inka.Serialization.UnitTests
{
    [Serializable]
    [XmlRoot]
    public class Company
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute]
        public string Name { get; set; }
    }
}
