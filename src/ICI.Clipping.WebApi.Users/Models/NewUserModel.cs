using ICI.Clipping.Application;
using System;

namespace ICI.Clipping.WebApi.Users.Models
{
	/// <summary>
	/// Modelo para criação de novo usuário.
	/// </summary>
	public class NewUserModel : AuthorizeModel
	{
		/// <summary>
		/// Tipos de interações permitidas.
		/// </summary>
		public ProfileEnum[] Profiles { get; set; }

		/// <summary>
		/// Nome do usuário.
		/// </summary>
		public string Nome { get; set; }

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
		public string Senha { get; set; }
	}
}