using System;
using System.Collections.Generic;

namespace Brasart.Domain.Common.ValueObjects
{
    public sealed class GuidVo : ValueObject
    {
        public static Guid Value => Guid.NewGuid();

        public static Guid? GetValueOrNew(Guid? current) => current.HasValue ? current : Value;


        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
