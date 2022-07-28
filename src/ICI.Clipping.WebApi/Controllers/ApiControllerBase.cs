using ICI.Clipping.WebApi.Models;
using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.IdentityModel.Tokens.Jwt;

namespace ICI.Clipping.WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ApiControllerBase : Controller
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			if (!IsAnonymousAllowed(context))
				CheckAuthorization(context);
			
		}

		private void CheckAuthorization(ActionExecutingContext context)
		{
			string autorization = HttpContext.Request.Headers["Authorization"].FirstOrDefault();
			if (autorization != null && !IsAnonymousAllowed(context)) {
				context.Result = Unauthorized();
				return;
			}

			if (autorization != null) {
				var bearer = autorization.Substring("bearer ".Length);
				var jwtToken = new JwtSecurityTokenHandler().ReadJwtToken(bearer);
				////this.SessaoAtual = Guid.Parse(jwtToken.Claims.First(x => x.Type == JwtRegisteredClaimNames.Sub).Value);  //claim da sessão
			}
		}

		/// <summary>
		/// Verifica se o modo anônimo está habilitado para o contexto atual.
		/// </summary>
		/// <param name="context">Contexto da action atual.</param>
		protected bool IsAnonymousAllowed(FilterContext context)
		{
			return !context.Filters.Any(x => x is AuthorizeFilter) || context.Filters.Any(x => x is AllowAnonymousFilter);
		}
	}
}
