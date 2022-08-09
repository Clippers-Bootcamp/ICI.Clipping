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
		/// Texto do recorte de notícia.
		/// </summary>
		public string Contents { get; set; }

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
		public DateTime Publish { get; set; }

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
		public static bool IsValid(Clipping clipping, out ErrorDictionary errors)
		{
			var valid = new Validate();
			var passed = true;
			passed &= Validate.IsUrl(clipping.Image) ||
						valid.AddError(nameof(clipping.Image), "Imagem inválida");
			passed &= Validate.IsUrl(clipping.Link) ||
						valid.AddError(nameof(clipping.Link), "Link inválido");
			passed &= Validate.LengthBetween(clipping.Local, 3, 50) ||
						valid.AddError(nameof(clipping.Local), "Cidade deve conter 3 a 50 caracteres");
			passed &= Validate.LengthBetween(clipping.NewsChannel, 1, 20) ||
						valid.AddError(nameof(clipping.NewsChannel), "Canal de notícias deve conter 1 a 20 caracteres");
			passed &= Validate.DatePast(clipping.Publish) ||
						valid.AddError(nameof(clipping.Publish), "Data deve ser anterior à data atual");
			passed &= Validate.LengthBetween(clipping.Synopsis, 5, 300) ||
						valid.AddError(nameof(clipping.Synopsis), "Resumo do recorte deve conter 5 a 300 caracteres");
			passed &= Validate.LengthBetween(clipping.Contents, 5, 5000) ||
						valid.AddError(nameof(clipping.Contents), "Resumo do recorte deve conter 5 a 5000 caracteres");
			errors = valid.CurrentErrorDictionary;
			return passed;
		}

		/// <summary>
		/// Verifica se o recorte de notícias atual é válido.
		/// </summary>
		/// <param name="errors"></param>
		/// <returns></returns>
		public bool IsValid(out ErrorDictionary errors)
		{
			return IsValid(this, out errors);
		}
	}
}
