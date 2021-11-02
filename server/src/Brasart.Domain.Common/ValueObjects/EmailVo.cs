using System;
using System.Collections.Generic;

namespace Brasart.Domain.Common.ValueObjects
{


    public class EmailVo : ValueObject
    {
        private readonly string _email;
        private readonly string _owner;

        public EmailVo(string email, string owner)
        {
            _email = email;
            _owner = owner;
        }

        public string Owner => _owner;

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return _email;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
