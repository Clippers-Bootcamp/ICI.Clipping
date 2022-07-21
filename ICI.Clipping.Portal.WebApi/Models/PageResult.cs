using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.Clipping.Clippings.WebApi.Models
{
	/// <summary>
	/// Modelo listar clipping.
	/// </summary>
	public class PageResult : DefaultResult
	{
		/// <summary>
		/// Listagem de recortes de notícias.
		/// </summary>
		public List<ClippingModel> ClippingList;
	}
}