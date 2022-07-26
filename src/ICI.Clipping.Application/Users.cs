﻿using ICI.Clipping.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security;
using System.Text;

namespace ICI.Clipping.Application
{
	/// <summary>
	/// Representa a listagem de usuários do sistema.
	/// </summary>
	public class Users : IDisposable
	{
		private readonly ClippingContext _context;

		public Users(ClippingContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Obter um usuário.
		/// </summary>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public User Load(string login, string password)
		{
			var ent = _context.Users.FirstOrDefault(x => x.Login == login);
			if (ent == null)
				throw new UserNotFoundException();

			if (ent.Password != password)
				throw new InvalidPasswordException();

			var user = new User();
			user.Email = ent.Email;
			user.Id = ent.Id;
			user.Login = ent.Login;
			user.Name = ent.Name;
			user.Password = ent.Password;
			user.Profile = (ProfileEnum)ent.Profile;
			return user;
		}

		/// <summary>
		/// Obter um usuário.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public User Load(Guid id)
		{
			var ent = _context.Users.Find(id);
			if (ent == null)
				throw new UserNotFoundException();

			var user = new User();
			user.Email = ent.Email;
			user.Id = ent.Id;
			user.Login = ent.Login;
			user.Name = ent.Name;
			user.Password = ent.Password;
			user.Profile = (ProfileEnum)ent.Profile;
			return user;
		}

		/// <summary>
		/// Cria um usuário e salva.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="login"></param>
		/// <param name="email"></param>
		/// <param name="password"></param>
		/// <param name="profile"></param>
		/// <returns></returns>
		public Guid Create(string name, string login, string email, string password, ProfileEnum profile = ProfileEnum.None)
		{
			var user = new User {
				Id = Guid.NewGuid(),
				Name = name,
				Login = login,
				Email = email,
				Password = password,
				Checked = false,
				Profile = profile
			};
			return Create(user);
		}

		/// <summary>
		/// Cria um usuário e salva.
		/// </summary>
		/// <param name="user"></param>
		public Guid Create(User user)
		{
			if (user.Id == Guid.Empty)
				user.Id = Guid.NewGuid();

			var errors = new ErrorDictionary();
			if (!User.IsValid(user, out errors))
				throw new InvalidObjectException(errors);


			var ent = new Data.Models.User();
			ent.Checked = user.Checked;
			ent.Email = user.Email;
			ent.Id = user.Id;
			ent.Login = user.Login;
			ent.Name = user.Name;
			ent.Password = user.Password;
			ent.Profile = (byte)user.Profile;
			_context.Users.Add(ent);
			_context.SaveChanges();
			return user.Id;
		}

		/// <summary>
		/// Altera os dados de um usuário.
		/// </summary>
		/// <param name="user"></param>
		public void Change(User user)
		{
			var ent = _context.Users.Find(user.Id);
			ent.Checked = user.Checked;
			ent.Email = user.Email;
			ent.Id = user.Id;
			ent.Login = user.Login;
			ent.Name = user.Name;
			ent.Password = user.Password;
			ent.Profile = (byte)user.Profile;
			_context.SaveChanges();
		}

		/// <summary>
		/// Bloqueia um usuário no sistema.
		/// </summary>
		/// <param name="user"></param>
		public void Disable(User user)
		{
			var ent = _context.Users.Find(user.Id);
			ent.Checked = false;
			_context.SaveChanges();
		}

		/// <summary>
		/// Habilita um usuário no sistema.
		/// </summary>
		/// <param name="user"></param>
		public void Enable(User user)
		{
			var ent = _context.Users.Find(user.Id);
			ent.Checked = true;
			_context.SaveChanges();
		}

		/// <summary>
		/// Exclui logicamente um usuário no sistema.
		/// </summary>
		/// <param name="user"></param>
		public void Delete(User user)
		{
			var ent = _context.Users.Find(user.Id);
			ent.Deleted = true;
			_context.SaveChanges();
		}

		/// <summary>
		/// Listar uma quantidade específica de User.
		/// </summary>
		/// <param name="recFrom"></param>
		/// <param name="recTo"></param>
		/// <returns></returns>
		public IEnumerable<User> ListAll()
		{
			foreach (var ent in _context.Users) {
				yield return new User() {
					Checked = ent.Checked,
					Email = ent.Email,
					Id = ent.Id,
					Login = ent.Login,
					Name = ent.Name,
					Profile = (ProfileEnum)ent.Profile,
				};
			}
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				_context.Dispose();
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
