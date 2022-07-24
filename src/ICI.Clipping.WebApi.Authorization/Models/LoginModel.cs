using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Authorization.Models
{
	/// <summary>
	/// Modelo para autenticação de usuário.
	/// </summary>
	public class LoginModel
	{
		public string UserName { get; set; }

		public string Password { get; set; }
	}
}