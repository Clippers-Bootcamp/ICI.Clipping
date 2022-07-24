using ICI.Clipping.WebApi.Models;

namespace ICI.Clipping.WebApi.Ratings.Models
{
	/// <summary>
	/// Modelo de ranqueamento do recorte de notícias.
	/// </summary>
	public class RateModel : AuthorizeModel
	{
		/// <summary>
		/// Ranqueamento fornecido pelo usuário.
		/// </summary>
		public float Rate { get; set; }

	}
}