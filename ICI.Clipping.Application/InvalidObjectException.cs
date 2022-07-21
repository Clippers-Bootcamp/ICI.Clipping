using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICI.Clipping.Application
{
	[Serializable]
	internal class InvalidObjectException : Exception
	{
		public InvalidObjectException()
		{
		}

		public InvalidObjectException(Dictionary<string, string> errors) : base("O objeto é inválido. Veja a lista de erros para detalhes.")
		{
			errors.ToList().ForEach(x => this.Data.Add(x.Key, x.Value));
		}

		public InvalidObjectException(string message) : base(message)
		{
		}

		public InvalidObjectException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected InvalidObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}