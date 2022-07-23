using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace ICI.Clipping.Application
{
	/// <summary>
	/// Representa a listagem de usuários do sistema.
	/// </summary>
	public class Users
	{
		/// <summary>
		/// Cria um usuário e salva.
		/// </summary>
		/// <param name="title"></param>
		/// <param name="synopsis"></param>
		/// <param name="link"></param>
		/// <param name="newsChannel"></param>
		/// <param name="publishDate"></param>
		/// <returns></returns>
		public User Create(string nome, string login, string email, string senha)
		{
			var user = new User();
			user.Name = nome;
			user.Login = login;
			user.Email = email;
			user.Password = senha;
			user.Checked = false;
			return Create(user);
		}

		/// <summary>
		/// Cria um usuário e salva.
		/// </summary>
		/// <param name="User"></param>
		public User Create(User User)
		{
			var errors = new Dictionary<string, string>();
			if (!User.IsValid(User, out errors))
				throw new InvalidObjectException(errors);

			throw new NotImplementedException();
		}

		/// <summary>
		/// Altera os dados de um usuário.
		/// </summary>
		/// <param name="User"></param>
		public void Change(User User)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Bloqueia um usuário no sistema.
		/// </summary>
		/// <param name="User"></param>
		public void Disable(User User)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Habilita um usuário no sistema.
		/// </summary>
		/// <param name="User"></param>
		public void Enable(User User)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Listar uma quantidade específica de User.
		/// </summary>
		/// <param name="recFrom"></param>
		/// <param name="recTo"></param>
		/// <returns></returns>
		public IEnumerable<User> ListAll()
		{
			throw new NotImplementedException();
		}

	}
}
