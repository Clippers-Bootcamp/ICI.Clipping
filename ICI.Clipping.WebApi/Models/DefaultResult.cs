using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Models
{
	/// <summary>
	/// Modelo de resultado padrão.
	/// </summary>
	public class DefaultResult : ActionResult, IStatusCodeActionResult
	{
		/// <summary>
		/// Código de status da página.
		/// </summary>
		public int? StatusCode { get; set; } = 200;

		/// <summary>
		/// Momento que a resposta foi fornecida
		/// </summary>
		public DateTime ResultDate { get => DateTime.Now; }
	}
}