using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Authorization.Models
{
	/// <summary>
	/// Modelo de resultado de autorização do usuário logado.
	/// </summary>
	public class AuthResult : DefaultResult
	{
		public string Token { get; set; }

		public DateTime Validade { get; set; }
	}
}