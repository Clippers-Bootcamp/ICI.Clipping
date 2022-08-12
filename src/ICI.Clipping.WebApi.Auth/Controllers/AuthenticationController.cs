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
	public class AuthenticationController : ApiControllerBase
	{
		private readonly ILogger<AuthenticationController> _logger;
        private readonly ClippingContext _context;

        public AuthenticationController(ILogger<AuthenticationController> logger, ClippingContext context)
		{
			_logger = logger;
            _context = context;
        }

		[HttpPost]
        [Route("[action]")]
        public JsonResult Login([FromBody] LoginModel model) { 
            var result = new AuthResult();
            try
            {
                var users = new Users(_context);
                var user = users.Load(model.UserName, model.Password);
                result.Token = user.ToTokenString(true);
                Response.StatusCode = 201;
            }
            catch (Exception ex)
            {
                if (ex is UserNotFoundException || ex is InvalidPasswordException)
                {
                    result.Errors = new List<string>() { ex.Message };
                    Response.StatusCode = 400;
                }
                else {
                    Response.StatusCode = 500;
                    throw;
                }
            }
            return Json(result);
		}


		[HttpGet]
        [Route("[action]")]
        public bool Validate(string token)
		{
			//todo: descriptografar o token
            //todo: pelo objeto ir na base verificar se o usuário é valido
		}


	}
}
