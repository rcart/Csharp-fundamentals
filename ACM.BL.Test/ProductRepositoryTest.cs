using NUnit.Framework;

namespace ACM.BL.Test
{
    [TestFixture]
    public class ProductRepositoryTest
    {
        [Test]
        public void RetrieveTest()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Un ramo de flores para ti :* ",
                ProductName = "Sunflowers",
            };
            
            // Act
            var actual = productRepository.Retrieve(2);
            
            // Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [Test]
        public void SaveTestValid()
        {
            // Arrrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Un ramo de flores para ti :* ",
                CurrentPrice = 15.96M,
                HasChanges = true
            };
            
            // Act
            var actual = productRepository.Save(updatedProduct);
            
            // Assert
            Assert.AreEqual(true, actual);
        }
        [Test]
        public void SaveTestMissingPrice()
        {
            // Arrrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Un ramo de flores para ti :* ",
                CurrentPrice = null,
                HasChanges = true
            };
            
            // Act
            var actual = productRepository.Save(updatedProduct);
            
            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}