using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
           Customer customer = new Customer(customerId); 
           
           // Retreieve defined customer
           
           // Temporary hard coded customer
           if (customerId == 1)
           {
               customer.EmailAddress = "rcart@gmail.com";
               customer.FirstName = "Ronny";
               customer.LastName = "Cardona";
               customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
           }

           return customer;
        }

        public bool Save(Customer customer)
        {
            // Here you save anything to the DB
            return true;
        }
    }
}