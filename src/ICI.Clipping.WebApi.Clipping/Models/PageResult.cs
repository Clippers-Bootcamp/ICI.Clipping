using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Clippings.Models
{
	/// <summary>
	/// Modelo de resultado de listagem de recorte de notícias.
	/// </summary>
	public class PageResult : DefaultResult
	{
		/// <summary>
		/// Listagem de recortes de notícias.
		/// </summary>
		public List<ClippingModel> List { get; set; }
	}
}