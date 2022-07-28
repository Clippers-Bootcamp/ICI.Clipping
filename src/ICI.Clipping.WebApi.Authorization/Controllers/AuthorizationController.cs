using ICI.Clipping.WebApi.Authorization.Models;
using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICI.Clipping.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using ICI.Clipping.WebApi.Controllers;

namespace ICI.Clipping.WebApi.Authorization.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AuthorizationController : ApiControllerBase
	{
		private readonly ILogger<AuthorizationController> _logger;

		public AuthorizationController(ILogger<AuthorizationController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		public AuthResult Login([FromBody] LoginModel model) { 
			throw new NotImplementedException();
		}


		[HttpPost]
		////[Authorize(Policy.Editor)]
		////[Authorize(Policy.Interactive)]
		public AuthResult Validate([FromBody] string token)
		{
			throw new NotImplementedException();
		}


	}
}
