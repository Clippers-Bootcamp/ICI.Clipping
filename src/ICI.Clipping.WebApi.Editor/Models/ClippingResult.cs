using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Editor.Models
{
	/// <summary>
	/// Modelo de resultado de listagem de recorte de notícias.
	/// </summary>
	public class ClippingResult : DefaultResult
	{
		/// <summary>
		/// Listagem de retorno.
		/// </summary>
		public List<ClippingModel> List;
	}
}