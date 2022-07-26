﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Newtonsoft.Json;
using System.Text.Encodings;

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
		public static bool IsValid(User user, out ErrorDictionary errors)
		{
			var valid = new Validate();
			var passed = true;
			passed &= Validate.IsEmail(user.Email) ||
						valid.AddError(nameof(user.Email), "Email inválido");
			passed &= Validate.LengthBetween(user.Login, 5, 15) ||
						valid.AddError(nameof(user.Login), "Login deve conter 5 a 15 caracteres");
			passed &= Validate.LengthBetween(user.Name, 3, 30) ||
						valid.AddError(nameof(user.Name), "Nome deve conter 3 a 30 caracteres");
			passed &= Validate.LengthBetween(user.Password, 5, 10) ||
						valid.AddError(nameof(user.Password), "Senha deve conter 5 a 10 caracteres");
			passed &= Validate.Includes(user.Password, "[0-9]", "[a-z]", "[A-Z]", @"[""'!@#$%¨&*()_+=`{´\[^}~\]<>:?,.;/|\-]") ||
						valid.AddError(nameof(user.Password), "Senha deve conter caracteres numéricos, letras minúsculas, letras maiúsculas e caracteres especiais do teclado");
			passed &= user.Profile != ProfileEnum.None ||
						valid.AddError(nameof(user.Profile), "É necessário especificar ao menos um perfil para o usuário");
			errors = valid.CurrentErrorDictionary;
			return passed;
		}

		/// <summary>
		/// Verifica se o usuário atual é válido.
		/// </summary>
		/// <param name="errors"></param>
		/// <returns></returns>
		public virtual bool IsValid(out ErrorDictionary errors)
		{
			return IsValid(this, out errors);
		}

		/// <summary>
		/// Criptografar o usuário atual num token.
		/// </summary>
		/// <returns></returns>
		public virtual string ToTokenString(bool includePassword = false) {
			var user = new
			{
				login = this.Login,
				email = this.Email,
				id = this.Id,
				name = this.Name,
				profile = this.Profile,
				password = includePassword ? this.Password : null,
				@checked = this.Checked,
			};
			var json = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(user));
			return Convert.ToBase64String(json);
		}

		/// <summary>
		/// Descriptografar um token para o usuário atual.
		/// </summary>
		/// <returns></returns>
		public virtual void FromTokenString(string token)
		{
			var contents = Convert.FromBase64String(token);
			var json = Encoding.UTF8.GetString(contents);
			var user = JsonConvert.DeserializeObject<User>(json);
			this.Email = user.Email;
			this.Checked = user.Checked;
			this.Id = user.Id;
			this.Login = user.Login;
			this.Name = user.Name;
			this.Password = user.Password;
			this.Profile = user.Profile;
		}
	}
}
