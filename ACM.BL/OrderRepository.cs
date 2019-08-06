using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            
            // Here I should cal the backend to retrieve the actual Order details
            // This is just a hard coded version
            if (orderId == 10)
            {
                // Use current year in a hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save()
        {
            // Should save to DB
            return true;
        }
    }
}