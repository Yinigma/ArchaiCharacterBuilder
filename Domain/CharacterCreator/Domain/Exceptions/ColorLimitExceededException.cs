using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Exceptions
{
    public class ColorLimitExceededException : Exception
    {
        public ColorLimitExceededException()
        {
        }

        public ColorLimitExceededException(string message) : base(message)
        {
        }

        public ColorLimitExceededException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
