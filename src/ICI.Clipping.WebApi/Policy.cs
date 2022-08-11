using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi
{
	/// <summary>
	/// Nível de permissão dos usuários.
	/// </summary>
	public static class Policy
	{
		public const string Reader = nameof(Reader);
		public const string Editor = nameof(Editor);
		public const string Admin = nameof(Admin);
	}
}
