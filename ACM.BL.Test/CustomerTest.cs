using NUnit.Framework;

namespace ACM.BL.Test
{
    [TestFixture]
    public class CustomerTests 
    {
        [Test]
        public void FullNameTestValid()
        {
            Customer customer = new Customer {FirstName = "Ronny", LastName = "Cardona"};
            string expected = "Cardona, Ronny";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer {LastName = "Cardona"};
            string expected = "Cardona";
            
            //Act
            string actual = customer.FullName;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountCustomerInstances()
        {
           //Arrange
           Customer c1 = new Customer {FirstName = "Ronny"};
           Customer.InstanceCount++;
           Customer c2 = new Customer {FirstName = "Jason"};
           Customer.InstanceCount++;
           Customer c3 = new Customer {FirstName = "Mia"};
           Customer.InstanceCount++;
           Assert.AreEqual(3, Customer.InstanceCount);
        }

        [Test]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer {LastName = "Cardona", EmailAddress = "rcart@email.com"};
            var expected = true;
            
            // Act
            var actual = customer.Validate();
            
            // Assert
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void ValidateInvalid()
        {
            // Arrange
            var customer = new Customer {EmailAddress = "rcart@email.com"};
            var expected = false ;
            
            // Act
            var actual = customer.Validate();
            
            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
