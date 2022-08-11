using System;

namespace ICI.Clipping.Application
{
    /// <summary>
    /// Representa uma nota do usuário.
    /// </summary>
    public class Rate
    {
        /// <summary>
        /// Usuário atual.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Recorte de notícia.
        /// </summary>
        public Clipping Clipping { get; set; }

        /// <summary>
        /// Nota do usuário.
        /// </summary>
        public byte RateIndex { get; set; }

		/// <summary>
		/// Verifica se o usuário atual é válido.
		/// </summary>
		/// <param name="rate"></param>
		/// <param name="errors"></param>
		/// <returns></returns>
		public static bool IsValid(Rate rate, out ErrorDictionary errors)
		{
            throw new NotImplementedException();
			return false;
		}

		/// <summary>
		/// Verifica se o usuário atual é válido.
		/// </summary>
		/// <param name="errors"></param>
		/// <returns></returns>
		public virtual bool IsValid(out ErrorDictionary errors)
		{
			return IsValid(this, out errors);
		}
	}
}