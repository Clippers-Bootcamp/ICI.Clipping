using ICI.Clipping.Application;
using System;

namespace ICI.Clipping.WebApi.Clippings.Models
{
	/// <summary>
	/// Modelo para obtenção de uma página de recortes de notícia.
	/// </summary>
	public class GetPageModel
	{
		/// <summary>
		/// Número da Página.
		/// </summary>
		public ushort PageIndex { get; set; }

		/// <summary>
		/// Total de registros por página.
		/// </summary>
		public ushort PageCount { get; set; } = 4;
	}
}