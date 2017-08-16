using System;
using System.Xml.Serialization;

namespace Sangmado.Inka.Serialization.UnitTests
{
    [Serializable]
    [XmlRoot]
    public class Employee
    {
        [XmlElement]
        public Company Company { get; set; }

        [XmlElement]
        public Person Person { get; set; }
    }
}
