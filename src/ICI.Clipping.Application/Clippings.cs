using System;
using System.Collections.Generic;
using System.Text;

namespace ICI.Clipping.Application
{
	/// <summary>
	/// Representa a listagem de recortes de notícia.
	/// </summary>
	public class Clippings
	{
		/// <summary>
		/// Usuário atual que está utilizando o clipping.
		/// </summary>
		public User CurrentUser { get; set; } = new AnonymousUser();

		public Clippings(User user)
		{
			var errors = new Dictionary<string, string>();
			if (!User.IsValid(user, out errors))
				throw new InvalidObjectException(errors);

			this.CurrentUser = user;
		}

		/// <summary>
		/// Cria um recorte e salva.
		/// </summary>
		/// <param name="image"></param>
		/// <param name="synopsis"></param>
		/// <param name="link"></param>
		/// <param name="newsChannel"></param>
		/// <param name="publishDate"></param>
		/// <returns></returns>
		public Clipping Create(string image, string synopsis, string link, string newsChannel, DateTime publishDate)
		{
			var clip = new Clipping();
			clip.Image = image;
			clip.Synopsis = synopsis;
			clip.Link = link;
			clip.NewsChannel = newsChannel;
			clip.PublishDateTime = publishDate;
			return Create(clip);
		}

		/// <summary>
		/// Cria um recorte e salva.
		/// </summary>
		/// <param name="clipping"></param>
		public Clipping Create(Clipping clipping)
		{
			var errors = new Dictionary<string, string>();
			if (!Clipping.IsValid(clipping, out errors))
				throw new InvalidObjectException(errors);

			throw new NotImplementedException();
		}

		/// <summary>
		/// Apaga um recorte de notícia.
		/// </summary>
		/// <param name="clipping"></param>
		public void Remove(Clipping clipping)
		{
			Remove(clipping.Id);
		}

		/// <summary>
		/// Apaga um recorte de notícia.
		/// </summary>
		/// <param name="id"></param>
		public void Remove(Guid id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Listar uma quantidade específica de clipping.
		/// </summary>
		/// <param name="recFrom"></param>
		/// <param name="recTo"></param>
		/// <returns></returns>
		public IEnumerable<Clipping> ListRecords(uint recFrom, uint recTo, OrderEnum order = OrderEnum.Descending)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Listar uma quantidade específica de clipping do início ou do final.
		/// </summary>
		/// <param name="recs"></param>
		/// <returns></returns>
		public IEnumerable<Clipping> ListRecords(uint recs, OrderEnum order = OrderEnum.Descending)
		{
			throw new NotImplementedException();
		}
	}

}
