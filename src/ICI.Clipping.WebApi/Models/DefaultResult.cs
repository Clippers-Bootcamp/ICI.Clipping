﻿using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Models
{
	/// <summary>
	/// Modelo de resultado padrão.
	/// </summary>
	public class DefaultResult : ActionResult
	{
		/// <summary>
		/// Momento que a resposta foi fornecida
		/// </summary>
		public DateTime ResultDate { get => DateTime.Now; }

		/// <summary>
		/// Mensagens de erro personalizadas.
		/// </summary>
		public List<string> Errors { get; set; } = new List<string>();
	}
}