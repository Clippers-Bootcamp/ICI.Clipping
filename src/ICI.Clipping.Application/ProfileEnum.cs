namespace ICI.Clipping.Application
{
	/// <summary>
	/// Determina o perfil que um usuário está usando para interagir com o sistema
	/// </summary>
	public enum ProfileEnum : byte
	{
		/// <summary>
		/// O usuário está lendo os recortes de notícia.
		/// </summary>
		Reader = 1,

		/// <summary>
		/// O usuário está editando os recortes de notícia.
		/// </summary>
		Editor = 2,
	}
}