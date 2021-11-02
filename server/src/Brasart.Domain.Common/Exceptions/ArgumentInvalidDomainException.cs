using Brasart.Domain.Common.Exceptions;

namespace Electra.Solvace.Core.Commom.Exceptions
{
    public class ArgumentInvalidDomainException : DomainException
    {
        public ArgumentInvalidDomainException(string nameDomain, string nameProperty)
            : base($"The value of property '{nameProperty}' of object '{nameProperty}' is invalid. Make sure it is not empty or has no special characters.") { }
    }
}
