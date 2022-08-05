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
		public string Password { internal get; set; }  //Marshal.SecureStringToBSTR

		/// <summary>
		/// Determina se o perfil do usuário foi validado.
		/// </summary>
		public bool Checked { get; set; }

		/// <summary>
		/// Perfis do usuário.
		/// </summary>
		public ProfileEnum Profile { get; set; }

		/// <summary>
		/// Verifica se o usuário atual é válido.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="errors"></param>
		/// <returns></returns>
		internal static bool IsValid(User user, out Dictionary<string, string> errors)
		{
			var errdic = new Dictionary<string, string>();
			Func<string, string, bool> addError = (prop, msg) => {
				errdic.Add(prop, msg);
				return false;
			};

			var valid = true;
			valid &= Validators.IsEmail(user.Email) || 
						addError(nameof(user.Email), "Email inválido");
			valid &= Validators.LengthBetween(user.Login, 5, 15) || 
						addError(nameof(user.Login), "Login deve conter de 5 a 15 caracteres");
			valid &= Validators.LengthBetween(user.Name, 3, 30) || 
						addError(nameof(user.Name), "Nome deve conter de 3 a 30 caracteres");
			valid &= Validators.LengthBetween(user.Password, 5, 10) || 
						addError(nameof(user.Password), "Senha deve conter de 5 a 10 caracteres");
			valid &= Validators.Includes(user.Password, "[0-9]", "[a-z]", "[A-Z]", @"[""'!@#$%¨&*()_+=`{´\[^}~\]<>:?,.;/|\-]") ||
						addError(nameof(user.Password), "Senha deve conter caracteres numéricos, letras minúsculas, letras maiúsculas e caracteres especiais do teclado");
			valid &= user.Profile != ProfileEnum.None || 
						addError(nameof(user.Profile), "É necessário especificar ao menos um perfil para o usuário");
			errors = errdic;
			return valid;
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
