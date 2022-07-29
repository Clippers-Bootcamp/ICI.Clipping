using System;
using System.Collections.Generic;
using System.Linq;
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
		/// <param name="name"></param>
		/// <param name="login"></param>
		/// <param name="email"></param>
		/// <param name="password"></param>
		/// <param name="profile"></param>
		/// <returns></returns>
		public static User Create(string name, string login, string email, string password, ProfileEnum profile = ProfileEnum.None)
		{
			var user = new User();
			user.Id = Guid.NewGuid();
			user.Name = name;
			user.Login = login;
			user.Email = email;
			user.Password = password;
			user.Checked = false;
			user.Profile = profile;
			return Create(user);
		}

		/// <summary>
		/// Cria um usuário e salva.
		/// </summary>
		/// <param name="user"></param>
		public static User Create(User user)
		{
			if (user.Id == Guid.Empty)
				user.Id = Guid.NewGuid();

			var errors = new Dictionary<string, string>();
			if (!User.IsValid(user, out errors))
				throw new InvalidObjectException(errors);


			using var context = new Data.ClippingContext();
			var userEnt = new Data.Models.User();
			userEnt.Checked = user.Checked;
			userEnt.Email = user.Email;
			userEnt.Id = user.Id;
			userEnt.Login = user.Login;
			userEnt.Name = user.Name;
			userEnt.Password = user.Password;
			userEnt.Profile = (byte)user.Profile;
			context.Users.Add(userEnt);
			context.SaveChanges();
			return user;
		}

		/// <summary>
		/// Altera os dados de um usuário.
		/// </summary>
		/// <param name="user"></param>
		public void Change(User user)
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
