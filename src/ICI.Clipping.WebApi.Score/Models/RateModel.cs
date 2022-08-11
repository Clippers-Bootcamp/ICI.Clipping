using ICI.Clipping.WebApi.Models;
using System;

namespace ICI.Clipping.WebApi.Ratings.Models
{
	/// <summary>
	/// Modelo de ranqueamento do recorte de notícias.
	/// </summary>
	public class RateModel
	{
		/// <summary>
		/// Código do recorte de notícia.
		/// </summary>
		public Guid ClippingId { get; set; }

		/// <summary>
		/// Ranqueamento fornecido pelo usuário.
		/// </summary>
		public byte Rate { get; set; }

	}
}