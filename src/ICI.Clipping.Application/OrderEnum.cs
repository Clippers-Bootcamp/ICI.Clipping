namespace ICI.Clipping.Application
{
	/// <summary>
	/// Determina a ordem de leitura por publicação do Clipping.
	/// </summary>
	public enum OrderEnum : sbyte
	{
		/// <summary>
		/// Listagem em ordem ascendente.
		/// </summary>
		Ascending = 1,

		/// <summary>
		/// Listagem em ordem descendente.
		/// </summary>
		Descending = -1,
	}
}