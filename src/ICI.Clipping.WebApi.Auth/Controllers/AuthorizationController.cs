using ICI.Clipping.WebApi.Auth.Models;
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
using ICI.Clipping.Data;

namespace ICI.Clipping.WebApi.Auth.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AuthorizationController : ApiControllerBase
	{
		private readonly ILogger<AuthenticationController> _logger;
        private readonly ClippingContext _context;

        public AuthorizationController(ILogger<AuthenticationController> logger, ClippingContext context)
		{
			_logger = logger;
            _context = context;
        }

        [HttpGet]
        [Route("[action]")]
        public JsonResult Profile(Guid userId)
        {
            var result = new ProfileResult();
            try
            {
                var users = new Users(_context);
                var user = users.Load(userId);
                result.IsAdmin = user.Profile.HasFlag(ProfileEnum.Admin);
                result.IsEditor = user.Profile.HasFlag(ProfileEnum.Editor);
                result.IsReader = user.Profile.HasFlag(ProfileEnum.Reader);
                Response.StatusCode = 200;
            }
            catch (UserNotFoundException ex)
            {
                result.Errors = new List<string>() { ex.Message };
                Response.StatusCode = 400;
            }
            return Json(result);
        }
    }
}
