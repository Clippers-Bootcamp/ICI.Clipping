using ICI.Clipping.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security;
using System.Text;

namespace ICI.Clipping.Application
{
	/// <summary>
	/// Representa a contabilização de notas.
	/// </summary>
	public class Rates : IDisposable
	{
		private readonly ClippingContext Context;

		public Rates(ClippingContext _context)
		{
			this.Context = _context;
		}

		/// <summary>
		/// Obter a nota geral de um recorte de notícias.
		/// </summary>
		/// <param name="clippingId"></param>
		/// <returns></returns>
		public double Total(Clipping clipping)
		{
			return Context.Rates.Where(x => x.ClippingId == clipping.Id).Average(x => x.RateIndex);
		}

		/// <summary>
		/// Inserir uma nota do usuário.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="clipping"></param>
		/// <param name="rate"></param>
		public void Insert(User user, Clipping clipping, byte rateIndex)
		{
			var rate = new Rate() {
				User = user,
				Clipping = clipping,
				RateIndex = rateIndex,
			};
			Insert(rate);
		}

		/// <summary>
		/// Inserir uma nota do usuário.
		/// </summary>
		/// <param name="rate"></param>
		public void Insert(Rate rate)
		{
			var errors = new ErrorDictionary();
			if (!Rate.IsValid(rate, out errors))
				throw new InvalidObjectException(errors);


			var ent = new Data.Models.Rate();
			ent.Id = Guid.NewGuid();
			ent.UserId = rate.User.Id;
			ent.ClippingId = rate.Clipping.Id;
			ent.RateIndex = rate.RateIndex;
			Context.Rates.Add(ent);
			Context.SaveChanges();
		}

		/// <summary>
		/// Alterar uma nota do usuário.
		/// </summary>
		/// <param name="rate"></param>
		public void Change(Rate rate)
		{
			var errors = new ErrorDictionary();
			if (!Rate.IsValid(rate, out errors))
				throw new InvalidObjectException(errors);

			var ent = Context.Rates.FirstOrDefault(x => x.ClippingId == rate.Clipping.Id && x.UserId == rate.User.Id);
			ent.RateIndex = rate.RateIndex;
			Context.Rates.Update(ent);
			Context.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				Context.Dispose();
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
