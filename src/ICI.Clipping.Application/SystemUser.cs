namespace ICI.Clipping.Application
{
	/// <summary>
	/// Representa o próprio sistema.
	/// </summary>
	sealed class SystemUser : User
	{
		public SystemUser()
		{
			this.Id = System.Guid.Empty;
			this.Email = "system@clipping.sys";
			this.Login = "system";
			this.Nome = "System User";
			this.Profile = ProfileEnum.Editor;
			this.Senha = "";
		}
	}
}