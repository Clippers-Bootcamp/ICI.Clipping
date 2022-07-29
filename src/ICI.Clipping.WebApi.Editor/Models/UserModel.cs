using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Models;
using System;

namespace ICI.Clipping.WebApi.Editor.Models
{
	/// <summary>
	/// Modelo para atualização de usuário existente.
	/// </summary>
	public class UserModel : AuthorizeModel
	{
		/// <summary>
		/// Identificador do usuário.
		/// </summary>
		public Guid? Id { get; set; }

		/// <summary>
		/// Nome do usuário.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Login do usuário.
		/// </summary>
		public string Login { get; set; }

		/// <summary>
		/// Email do usuário.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Senha do usuário.
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Perfil de leitor.
		/// </summary>
		public bool? IsReader { get; set; }

		/// <summary>
		/// Perfil de editor.
		/// </summary>
		public bool? IsEditor { get; set; }

		/// <summary>
		/// Perfil de administrador.
		/// </summary>
		public bool? IsAdmin { get; set; }
	}
}