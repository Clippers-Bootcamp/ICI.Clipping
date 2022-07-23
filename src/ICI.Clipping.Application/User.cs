using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace ICI.Clipping.Application
{
	/// <summary>
	/// Representa um usuário do sistema, leitor ou editor.
	/// </summary>
	public class User
	{
		/// <summary>
		/// Identificador único do usuário.
		/// </summary>
		public Guid Id { get; internal set; }

		/// <summary>
		/// Tipo de interação atual.
		/// </summary>
		public ProfileEnum Profile { get; set; }

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
		public string Password { private get; set; }  //Marshal.SecureStringToBSTR
		
		/// <summary>
		/// Determina se o perfil do usuário foi validado.
		/// </summary>
		public bool Checked { get; set; }

		/// <summary>
		/// Verifica se o usuário atual é válido.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="errors"></param>
		/// <returns></returns>
		internal static bool IsValid(User user, out Dictionary<string, string> errors)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Verifica se o usuário atual é válido.
		/// </summary>
		/// <param name="errors"></param>
		/// <returns></returns>
		internal bool IsValid(out Dictionary<string, string> errors)
		{
			return IsValid(this, out errors);
		}
	}
}
