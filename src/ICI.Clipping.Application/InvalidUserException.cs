using System;
using System.Runtime.Serialization;

namespace ICI.Clipping.Application
{
	[Serializable]
	public class InvalidUserException : Exception
	{
		public InvalidUserException() : base("Usuário inválido para a operação especificada.")
		{
		}

		public InvalidUserException(string message) : base(message)
		{
		}

		public InvalidUserException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected InvalidUserException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}