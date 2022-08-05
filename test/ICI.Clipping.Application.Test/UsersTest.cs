using ICI.Clipping.Data;
using System;
using Xunit;

namespace ICI.Clipping.Application.Test
{
	public class UsersTest
	{
		[Fact]
		public void Create()
		{
			var user = new User()
			{
				Checked = false,
				Email = "teste@teste.com",
				Login = "teste",
				Name = "Teste Unitário",
				Password = "xTeste99|x",
				Profile = ProfileEnum.Editor | ProfileEnum.Reader
			};

			var context = new ClippingContext();
			var users = new Users(context);
			var id = users.Create(user);

			user = users.Load(id);
			users.Delete(user);
		}
	}
}
