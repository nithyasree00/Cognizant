using NUnit.Framework;
using UtilLib;

namespace UtilLib.Tests
{
    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_ValidUrl_ReturnsHostName()
        {
            string result = parser.ParseHostName("https://www.google.com");

            Assert.That(result, Is.EqualTo("www.google.com"));
        }

        [Test]
        public void ParseHostName_AnotherValidUrl_ReturnsHostName()
        {
            string result = parser.ParseHostName("https://github.com");

            Assert.That(result, Is.EqualTo("github.com"));
        }
    }
}