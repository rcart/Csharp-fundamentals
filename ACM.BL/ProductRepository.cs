namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Create an instance of the Product class
            Product product = new Product(productId);
            
            // Code that retrieves the defined product
            // When I'm actually using a backend 
            
            // Temporary hard coded values to return a populated value
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Un ramo de flores para ti :* ";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call insert
                    }
                    else
                    {
                        // Call update
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}