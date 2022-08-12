using ICI.Clipping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICI.Clipping.Application
{
	/// <summary>
	/// Representa a listagem de recortes de notícia.
	/// </summary>
	public class Clippings : IDisposable
	{
		private readonly ClippingContext _context;

		/// <summary>
		/// Usuário atual que está utilizando o clipping.
		/// </summary>
		public readonly User CurrentUser;

		public Clippings(ClippingContext context, User user = default(User))
		{
			user ??= new AnonymousUser();

			var errors = new ErrorDictionary();
			if (!user.IsValid(out errors))
				throw new InvalidObjectException(errors);

			_context = context;
			CurrentUser = user;
		}

		/// <summary>
		/// Cria um recorte e salva.
		/// </summary>
		/// <param name="image"></param>
		/// <param name="synopsis"></param>
		/// <param name="link"></param>
		/// <param name="newsChannel"></param>
		/// <param name="publishDate"></param>
		public Guid Create(string image, string synopsis, string link, string newsChannel, DateTime publishDate)
		{
			var clipping = new Clipping();
			clipping.Image = image;
			clipping.Synopsis = synopsis;
			clipping.Link = link;
			clipping.NewsChannel = newsChannel;
			clipping.Publish = publishDate;
			return Create(clipping);
		}

		/// <summary>
		/// Cria um recorte e salva.
		/// </summary>
		/// <param name="clipping"></param>
		public Guid Create(Clipping clipping)
		{
			if (CurrentUser is AnonymousUser)
				throw new InvalidUserException();
			

			var errors = new ErrorDictionary();
			if (!Clipping.IsValid(clipping, out errors))
				throw new InvalidObjectException(errors);

			var ent = new Data.Models.Clipping();
			ent.Id = Guid.NewGuid();
			ent.Image = clipping.Image;
			ent.Link = clipping.Link;
			ent.Local = clipping.Local;
			ent.NewsChannel = clipping.NewsChannel;
			ent.Publish = clipping.Publish;
			ent.Synopsis = clipping.Synopsis;
			ent.Contents = clipping.Contents;
			_context.Clippings.Add(ent);
			_context.SaveChanges();
			return ent.Id;
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
			var ent = _context.Clippings.Find(id);
			_context.Clippings.Remove(ent);
			_context.SaveChanges();
		}

		/// <summary>
		/// Obter um recorte de notícia.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Clipping Get(Guid id)
		{
			var ent = _context.Clippings.Find(id);
			var clipping = new Clipping() {
				Id = ent.Id,
				Image = ent.Image,
				Link = ent.Link,
				Local = ent.Local,
				NewsChannel = ent.NewsChannel,
				Publish = ent.Publish,
				Synopsis = ent.Synopsis,
				Contents = ent.Contents,
			};
			return clipping;
		}

		/// <summary>
		/// Listar uma quantidade específica de clipping.
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <returns></returns>
		public IEnumerable<Clipping> List(uint from, uint to, OrderEnum order = OrderEnum.Descending)
		{
			foreach (var ent in _context.Clippings.Skip((int)from).Take((int)(to - from))) {
				yield return new Clipping() { 
					Id = ent.Id,
					Image = ent.Image,
					Link = ent.Link,
					Local = ent.Local,
					NewsChannel = ent.NewsChannel,
					Publish = ent.Publish,
					Synopsis = ent.Synopsis,
					Contents = ent.Contents,
				};
			}
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				_context.Dispose();
			}
		}

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
