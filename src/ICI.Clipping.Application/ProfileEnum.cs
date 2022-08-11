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
		/// Sem permissões, somente leitura.
		/// </summary>
		None = 0,

		/// <summary>
		/// Permissão para interagir com recortes de notícia.
		/// </summary>
		Reader = 1,

		/// <summary>
		/// Permissão para editar cadastros.
		/// </summary>
		Editor = 2,

		/// <summary>
		/// Permissão total.
		/// </summary>
		Admin = 4,
	}
}