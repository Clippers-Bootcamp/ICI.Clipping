namespace ICI.Clipping.Clippings.WebApi.Models
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
		public string PublishDateTime { get; set; }

		/// <summary>
		/// Link completo para o canal de divulgação do recorte de notícia.
		/// </summary>
		public string Link { get; set; }

		/// <summary>
		/// Pontuação do recorte de notícia.
		/// </summary>
		/// <remarks>Usar o nome da imagem: 1i.score.png (1 estrela inteira), 2m.score.png (1 estrela inteira e meia)</remarks>
		public string Score { get; set; }
	}
}