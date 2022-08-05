﻿namespace ICI.Clipping.Application
{
	/// <summary>
	/// Representa um usuário que ainda não foi cadastrado.
	/// </summary>
	sealed class AnonymousUser : User
	{
		public AnonymousUser()
		{
			this.Id = System.Guid.Empty;
			this.Email = "anonymous@clipping.sys";
			this.Login = "anonymous";
			this.Name = "Anonymous User";
			this.Profile = ProfileEnum.Reader;
			this.Password = "B3AA65EB8408";
		}
	}
}