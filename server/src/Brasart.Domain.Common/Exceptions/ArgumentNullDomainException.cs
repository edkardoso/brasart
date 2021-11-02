using Brasart.Domain.Common.Exceptions;

namespace Electra.Solvace.Core.Commom.Exceptions
{
    public class ArgumentNullDomainException : DomainException
    {
        public ArgumentNullDomainException(string nameDomain, string nameProperty)
            : base($"The '{nameProperty}' property of the '{nameDomain}' object is null and is required.") { }
    }
}
