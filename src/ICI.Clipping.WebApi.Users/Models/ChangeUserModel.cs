using ICI.Clipping.Application;
using System;

namespace ICI.Clipping.WebApi.Users.Models
{
	/// <summary>
	/// Modelo para atualização de usuário existente.
	/// </summary>
	public class ChangeUserModel : AuthorizeModel
	{
		/// <summary>
		/// Identificador do usuário.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Nome do usuário.
		/// </summary>
		public string Nome { get; set; }

		/// <summary>
		/// Senha do usuário.
		/// </summary>
		public string Senha { get; set; }

		/// <summary>
		/// Perfil de leitor.
		/// </summary>
		public bool IsReader { get; set; }

		/// <summary>
		/// Perfil de editor.
		/// </summary>
		public bool IsEditor { get; set; }

	}
}