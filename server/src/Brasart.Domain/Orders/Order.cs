using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brasart.Domain.Common.Entities;
using Brasart.Domain.Products;
using Brasart.Domain.Users;
using Brasart.Domain.Users.Customers;
using Brasart.Domain.Users.Employees;

namespace Brasart.Domain.Orders
{
    public class Order: AuditableBaseEntity
    {
        public Guid Id { get;  }
        public DateTime Date { get;  }
        public DateTime EstimatedDeliveryDate { get;  }
        public DateTime ConfirmationDateFromCustomer { get; }
        public DateTime ConfirmationDateFromDeliveryPerson { get; }
        public Employee DeliveryPerson { get;  }
        public virtual Customer Customer { get; set; }
        public virtual List<Product> OrderItems { get; private set; }
        public decimal DeliveryPrice { get; private set; }
        public decimal Discount { get; private set; }
        public decimal Total { get; private set; }

    }

   
}
