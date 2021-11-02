using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brasart.Domain.Common.Entities;
using Brasart.Domain.Common.Exceptions;

namespace Brasart.Domain.Products
{
    public class Product: AuditableBaseEntity
    {
        protected Product()
        {

        }

        public string Name { get;  }
        public string Description { get; }
        public Category Category { get;  }
        public decimal CostPrice { get; }
        public decimal SalePrice { get; }

    }

    public class RangeClassfication
    {
        private readonly string _description;
        private readonly int _min;
        private readonly int _max;


        public string Description { get; }

        public int Value { get; private set; }

        public RangeClassfication(string description, int min = 1, int max = 5)
        {
            _description = description;
            _min = min;
            _max = max;
        }

        public void SetValue(int value)
        {
            if (value < _min || value > _max)
                throw new InvalidDomainException($"A classficação deve estar entre {_min} e {_max}.");

            Value = value;

        }

    }

    public class Classification
    {
        public int Flavor { get; set; }
    }
}
