using System;
using System.Runtime.Serialization;

namespace Electra.Solvace.Core.Commom.Exceptions
{


    [Serializable]
    public class NotificationException : Exception
    {
        private Exception _ex;

        public NotificationException()
        {
        }

        public NotificationException(Exception ex)
        {
            _ex = ex;
        }

        public NotificationException(string message) : base(message)
        {
        }

        public NotificationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotificationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
