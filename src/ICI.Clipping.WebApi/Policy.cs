using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi
{
	/// <summary>
	/// Nível de permissão das páginas.
	/// </summary>
	public static class Policy
	{
		public const string Interactive = nameof(Interactive);
		public const string Editor = nameof(Editor);
		public const string Reader = nameof(Reader);
	}
}
