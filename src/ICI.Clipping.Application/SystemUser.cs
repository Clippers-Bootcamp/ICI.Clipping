﻿namespace ICI.Clipping.Application
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
			this.Name = "System User";
			this.Profile = ProfileEnum.Editor;
			this.Password = "8D7BAFF33F7E";
		}
	}
}