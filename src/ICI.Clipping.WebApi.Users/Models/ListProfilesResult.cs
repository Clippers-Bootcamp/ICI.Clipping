using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Users.Models
{
	/// <summary>
	/// Modelo de resultado de listagem de perfis.
	/// </summary>
	public class ListProfilesResult : DefaultResult
	{
		/// <summary>
		/// Listagem de perfis do usuário.
		/// </summary>
		public List<ProfileEnum> Profiles;
	}
}