using ICI.Clipping.WebApi.Authorization.Models;
using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICI.Clipping.WebApi.Models;

namespace ICI.Clipping.WebApi.Authorization.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AuthorizationController : ControllerBase
	{
		private readonly ILogger<AuthorizationController> _logger;

		public AuthorizationController(ILogger<AuthorizationController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		public AuthorizationResult Login([FromBody] LoginModel model) { 
			throw new NotImplementedException();
		}


		[HttpPost]
		public AuthorizationResult Validate([FromBody] string token)
		{
			throw new NotImplementedException();
		}
	}
}
