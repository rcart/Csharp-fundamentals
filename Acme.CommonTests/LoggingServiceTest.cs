using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using NUnit.Framework;

namespace Acme.CommonTests
{
    [TestFixture]
    public class LoggingServiceTest
    {
        [Test]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "rcart@gmail.com",
                FirstName = "Ronny",
                LastName = "Cardona",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 16M
            };
            changedItems.Add(product);
            
            // Act
            LoggingService.WriteToFile(changedItems);
            
        }
    }
}