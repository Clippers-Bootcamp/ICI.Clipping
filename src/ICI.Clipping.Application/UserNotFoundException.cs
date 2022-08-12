using System;
using System.Runtime.Serialization;

namespace ICI.Clipping.Application
{
    [Serializable]
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException(): base("Usuário inválido ou não encontrado")
        {
        }

        public UserNotFoundException(string message) : base(message)
        {
        }

        public UserNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}