using System;
using Brasart.Domain.Common.Exceptions;

namespace Electra.Solvace.Core.Commom.Exceptions
{
    public class InvalidOperationRecordDelete : DomainException
    {
        public InvalidOperationRecordDelete(Guid guid) : base($"You cannot change the state of a deleted object (id: {guid}).")
        {

        }
    }
}
