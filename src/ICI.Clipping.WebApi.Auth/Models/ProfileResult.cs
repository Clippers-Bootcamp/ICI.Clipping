using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Auth.Models
{
	/// <summary>
	/// Modelo de resultado de permissões de um usuário.
	/// </summary>
	public class ProfileResult : DefaultResult
	{
		public bool IsReader { get; set; }

		public bool IsEditor { get; set; }

		public bool IsAdmin { get; set; }
	}
}