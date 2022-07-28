namespace ICI.Clipping.WebApi.Editor.Models
{
	/// <summary>
	/// Representa um recorte de notícia.
	/// </summary>
	public class ClippingModel
	{
		/// <summary>
		/// Identificador do recorte de notícia.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Caminho da imagem de chamada.
		/// </summary>
		public string Image { get; set; }

		/// <summary>
		/// Resumo do recorte de notícia.
		/// </summary>
		public string Synopsis { get; set; }

		/// <summary>
		/// Canal de divulgação do recorte de notícia.
		/// </summary>
		public string NewsChannel { get; set; }

		/// <summary>
		/// Data de publicação do recorte de notícia.
		/// </summary>
		/// <remarks>String para poder enviar já formatado.</remarks>
		public string Publish { get; set; }

		/// <summary>
		/// Link completo para o canal de divulgação do recorte de notícia.
		/// </summary>
		public string Link { get; set; }

	}
}