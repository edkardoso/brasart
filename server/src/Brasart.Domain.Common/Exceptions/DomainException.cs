using System;
using System.Runtime.Serialization;

namespace Brasart.Domain.Common.Exceptions
{
    public class DomainException : Exception
    {
        public string Code { get; }

        public DomainException()
        {
        }

        public DomainException(string message, string code = "") : base(message)
        {
            Code = code;
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DomainException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
