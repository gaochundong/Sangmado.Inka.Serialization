using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sangmado.Inka.Serialization.UnitTests
{
    [TestClass]
    public class XmlConvertUnitTest
    {
        [TestMethod]
        public void TestSerializeObject_EmptySetting_EmptyNamespaces_NotIndented()
        {
            var employee = new Employee()
            {
                Company = new Company()
                {
                    Id = 123,
                    Name = "Sangmado",
                },
                Person = new Person()
                {
                    Id = 11111,
                    FullName = "Dennis Gao",
                    FirstName = "Dennis",
                    LastName = "Gao",
                },
            };

            string expected = XmlConvert.SerializeObject(employee);

            string actual = EmbeddedResourceLoader.LoadAsString(
                @"Sangmado.Inka.Serialization.UnitTests.TestXml.Employee-DennisGao-NotIndented.xml");

            Assert.AreEqual(string.CompareOrdinal(expected, actual), 0);
        }

        [TestMethod]
        public void TestSerializeObject_Setting_EmptyNamespaces_Indented()
        {
            var employee = new Employee()
            {
                Company = new Company()
                {
                    Id = 123,
                    Name = "Sangmado",
                },
                Person = new Person()
                {
                    Id = 11111,
                    FullName = "Dennis Gao",
                    FirstName = "Dennis",
                    LastName = "Gao",
                },
            };

            var settings = new XmlWriterSettings()
            {
                Indent = true,
            };

            string expected = XmlConvert.SerializeObject(employee, settings);

            string actual = EmbeddedResourceLoader.LoadAsString(
                @"Sangmado.Inka.Serialization.UnitTests.TestXml.Employee-DennisGao-Indented.xml");

            Assert.AreEqual(string.CompareOrdinal(expected, actual), 0);
        }

        [TestMethod]
        public void TestSerializeObject_Setting_Namespaces_Indented_OmitXmlDeclaration()
        {
            var employee = new Employee()
            {
                Company = new Company()
                {
                    Id = 123,
                    Name = "Sangmado",
                },
                Person = new Person()
                {
                    Id = 11111,
                    FullName = "Dennis Gao",
                    FirstName = "Dennis",
                    LastName = "Gao",
                },
            };

            var settings = new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = true,
                NewLineHandling = NewLineHandling.None,
            };
            var namespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });

            string expected = XmlConvert.SerializeObject(employee, settings, namespaces);

            string actual = EmbeddedResourceLoader.LoadAsString(
                @"Sangmado.Inka.Serialization.UnitTests.TestXml.Employee-DennisGao-Indented-OmitXmlDeclaration.xml");

            Assert.AreEqual(string.CompareOrdinal(expected, actual), 0);
        }
    }
}
