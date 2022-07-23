﻿using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Models;
using System;

namespace ICI.Clipping.WebApi.Users.Models
{
	/// <summary>
	/// Modelo para pesquisa de perfis de um usuário.
	/// </summary>
	public class ListProfilesModel : AuthorizeModel
	{
		/// <summary>
		/// Identificador do usuário.
		/// </summary>
		public Guid UserId { get; set; }

		/// <summary>
		/// Identificador do usuário.
		/// </summary>
		public string Email { get; set; }

	}
}