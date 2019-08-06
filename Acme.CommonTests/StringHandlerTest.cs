using Acme.Common;
using NUnit.Framework;

namespace Acme.CommonTests
{
    [TestFixture]
    public class StringHandlerTest
    {
        [Test]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            
            // Act
            var actual = source.InsertSpaces();
            
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void InsertSpacesTestInvalid()
        {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            
            // Act
            var actual = source.InsertSpaces();
            
            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}