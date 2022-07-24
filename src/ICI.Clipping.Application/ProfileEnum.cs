using System;

namespace ICI.Clipping.Application
{
	/// <summary>
	/// Determina o perfil que um usuário está usando para interagir com o sistema
	/// </summary>
	[Flags]
	public enum ProfileEnum : byte
	{
		/// <summary>
		/// Permissão para interagir com recortes de notícia.
		/// </summary>
		Interactive = 1,

		/// <summary>
		/// Permissão para editar cadastros.
		/// </summary>
		Editor = 2,
	}
}