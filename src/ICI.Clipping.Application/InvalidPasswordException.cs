using System;
using System.Runtime.Serialization;

namespace ICI.Clipping.Application
{
    [Serializable]
    internal class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("Senha incorreta")
        {
        }

        public InvalidPasswordException(string message) : base(message)
        {
        }

        public InvalidPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}