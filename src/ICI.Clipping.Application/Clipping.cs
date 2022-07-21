using System;
using System.Collections.Generic;

namespace ICI.Clipping.Application
{
	/// <summary>
	/// Um recorte de notícia.
	/// </summary>
	public class Clipping
	{
		/// <summary>
		/// Identificação do recorte de notícia.
		/// </summary>
		public Guid Id { get; internal set; } = Guid.NewGuid();

		/// <summary>
		/// Imagem de chamada do recorte de notícia.
		/// </summary>
		public string Image { get; set; }

		/// <summary>
		/// Sinópse, resumo do recorte de notícia.
		/// </summary>
		public string Synopsis { get; set; }

		/// <summary>
		/// Link para o canal de divulgação.
		/// </summary>
		public string Link { get; set; }

		/// <summary>
		/// Canal de divulgação.
		/// </summary>
		public string NewsChannel { get; set; }

		/// <summary>
		/// Local da notícia.
		/// </summary>
		public string Local { get; set; }

		/// <summary>
		/// Data/hora de publicação.
		/// </summary>
		public DateTime PublishDateTime { get; set; }

		/// <summary>
		/// Média de pontuação da notícia.
		/// </summary>
		public float Score
		{
			get {
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Verifica se o recorte de notícias atual é válido.
		/// </summary>
		/// <param name="clipping"></param>
		/// <param name="errors"></param>
		/// <returns></returns>
		internal static bool IsValid(Clipping clipping, out Dictionary<string, string> errors)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Verifica se o recorte de notícias atual é válido.
		/// </summary>
		/// <param name="errors"></param>
		/// <returns></returns>
		internal bool IsValid(out Dictionary<string, string> errors)
		{
			return IsValid(this, out errors);
		}
	}
}
