using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Threading.Tasks;

namespace ICI.Clipping.Users.WebApi.Models
{
	/// <summary>
	/// Modelo para atualização de usuário existente.
	/// </summary>
	public class DefaultResult : ActionResult, IStatusCodeActionResult
	{
		public int? StatusCode { get; set; } = 200;

		public DateTime ResultDate { get => DateTime.Now; }
	}
}