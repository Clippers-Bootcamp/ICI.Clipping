namespace ICI.Clipping.WebApi.Users.Models
{
	public class CheckUserModel : AuthorizeModel
	{
		/// <summary>
		/// E-mail do usuário que está sendo checado.
		/// </summary>
		public string Email { get; set; }
	}
}