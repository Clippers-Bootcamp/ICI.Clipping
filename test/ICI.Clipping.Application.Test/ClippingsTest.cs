using ICI.Clipping.Data;
using System;
using System.Collections.Generic;
using Xunit;

namespace ICI.Clipping.Application.Test
{
	public class ClippingsTest
	{
		[Fact]
		public void Create()
		{
			var context = new ClippingContext();
			var sys = new SystemUser();
			var clips = new Clippings(context, sys);
			var temp = new List<Guid>();
			for (int i = 0; i < 5; i++) {
				var clip = new Clipping() {
					Image = "http://image.com/image.png",
					Link = "https://link.com/link.html",
					Local = "Curitiba",
					NewsChannel = "CBN",
					Publish = DateTime.Now,
					Synopsis = "Teste de recorte",
					Contents = "Teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste teste",
				};
				temp.Add(clips.Create(clip));
			}
			temp.ForEach(x=> clips.Remove(x));
		}
	}
}
