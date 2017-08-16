using System;
using System.Xml.Serialization;

namespace Sangmado.Inka.Serialization.UnitTests
{
    [Serializable]
    [XmlRoot]
    public class Person
    {
        [XmlAttribute()]
        public int Id { get; set; }

        [XmlAttribute]
        public string FullName { get; set; }

        [XmlAttribute]
        public string FirstName { get; set; }

        [XmlAttribute]
        public string LastName { get; set; }
    }
}
