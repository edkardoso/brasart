using System.Collections.Generic;
using Brasart.Domain.Products;

namespace Brasart.Domain.Users.Customers
{
   
    public class Customer
    {
        private readonly User _user;

        public Customer(User user)
        {
            _user = user;
        }

        public Dictionary<Product, int> Classification { get; }
        public virtual List<Address> Address { get; set; }
    }
}
