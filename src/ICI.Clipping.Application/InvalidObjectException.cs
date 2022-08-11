using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Collections;

namespace ICI.Clipping.Application
{
	[Serializable]
	internal class InvalidObjectException : Exception
	{
		public InvalidObjectException()
		{
		}

		public InvalidObjectException(ErrorDictionary errors) : base("O objeto é inválido. Veja a lista de erros para detalhes.")
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

		/// <summary>
		/// Retorna a lista de erros de forma simples, desagrupada.
		/// </summary>
		/// <returns></returns>
        public List<string> ToSimpleList()
        {
			var values = this.Data.Values;
			var lists = values.Cast<List<string>>();
			var merged = lists.SelectMany(x => x);
			return merged.ToList();
		}
	}
}