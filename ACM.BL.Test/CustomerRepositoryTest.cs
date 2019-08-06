using System.Collections.Generic;
using NUnit.Framework;

namespace ACM.BL.Test
{
    [TestFixture]
    public class CustomerRepositoryTest
    {
        [Test]
        public void RetrieveValid()
        {
            // Arrange 
            var customerRepository = new CustomerRepository();
            
            var expected = new Customer(1)
            {
                EmailAddress = "rcart@gmail.com",
                FirstName = "Ronny",
                LastName = "Cardona"
            };
            // Act
            var actual = customerRepository.Retrieve(1);
            
            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [Test]
        public void RetrieveWithExistingAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "rcart@gmail.com",
                FirstName = "Ronny",
                LastName = "Cardona",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreeLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreeLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    }
                }
            };
            // Act
            var actual = customerRepository.Retrieve(1);
            
            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            //Crazy way to test the objects per instructor at pluralsight
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);            
                Assert.AreEqual(expected.AddressList[i].StreeLine1, actual.AddressList[i].StreeLine1);            
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);            
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);            
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);            
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);            
            }
        }
    }
}