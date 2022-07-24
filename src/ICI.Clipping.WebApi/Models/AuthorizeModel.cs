using ICI.Clipping.Application;

namespace ICI.Clipping.WebApi.Models
{
	/// <summary>
	/// Representa um modelo de entrada.
	/// </summary>
	public class AuthorizeModel
	{
		/// <summary>
		/// Usuário autenticado na operação atual.
		/// </summary>
		public User CurrentUser { get; set; }
	}
}