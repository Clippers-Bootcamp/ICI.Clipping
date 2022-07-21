using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Users.Models
{
	/// <summary>
	/// Modelo para atualização de usuário existente.
	/// </summary>
	public class ListProfilesResult : DefaultResult
	{
		/// <summary>
		/// Listagem de perfis do usuário.
		/// </summary>
		public List<ProfileEnum> Profiles;
	}
}