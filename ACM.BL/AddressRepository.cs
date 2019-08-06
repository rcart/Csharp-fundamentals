using System.Collections;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            // Create an instance of the Address class
            Address address = new Address(addressId);
            
            // Here should go the backend calls
            
            // This are hard coded values to return an Address object
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreeLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // This code will get all customer's addresses
            // This are just hard coded values to return
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreeLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreeLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);
            return addressList;
        }

        public bool Save(Address address)
        {
            // Here should go the backend calls to save the Address object into db
            return true;
        }
    }
}