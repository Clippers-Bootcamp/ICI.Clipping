namespace ICI.Clipping.Application
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
			this.Nome = "Anonymous User";
			this.Profile = ProfileEnum.Reader;
			this.Senha = "";
		}
	}
}