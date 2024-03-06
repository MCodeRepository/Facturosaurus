using System;

namespace Facturosaurus.Api.Exceptions
{
    public class IncorrectPasswordOrEmailException : Exception
    {
        public IncorrectPasswordOrEmailException(string message) : base(message) { }
    }
}
