using ICI.Clipping.Application;

namespace ICI.Clipping.Users.WebApi.Models
{
	/// <summary>
	/// Representa um modelo de entrada.
	/// </summary>
	public class AuthorizeModel
	{
		/// <summary>
		/// Usuário autenticado na operação atual.
		/// </summary>
		internal User CurrentUser { get; set; }
	}
}