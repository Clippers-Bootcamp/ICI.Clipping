using ICI.Clipping.WebApi.Editor.Models;
using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICI.Clipping.WebApi.Controllers;
using ICI.Clipping.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using ICI.Clipping.Data;

namespace ICI.Clipping.WebApi.Editor.Controllers
{
	[ApiController]
	[Route("[controller]")]
	////[Authorize(Policy.Editor)]
	public class UserController : ApiControllerBase
	{
		private readonly ILogger<UserController> _logger;
		private readonly ClippingContext _context;

		public UserController(ILogger<UserController> logger, ClippingContext context)
		{
			_logger = logger;
			_context = context;
		}

		[HttpPost]
		[Route("")]
		public JsonResult Post([FromBody] UserModel model)
		{
			var result = new DefaultResult();
            try
            {
				var users = new Users(_context);
			var profile = ProfileEnum.None;
				if (model?.IsReader ?? false) profile |= ProfileEnum.Reader;
				if (model?.IsEditor ?? false) profile |= ProfileEnum.Editor;
				if (model?.IsAdmin ?? false) profile |= ProfileEnum.Admin;
				var user = new Application.User()
				{
					Checked = false,
					Email = model.Email,
					Login = model.Login,
					Name = model.Name,
					Password = model.Password,
					Profile = profile,
				};
				var id = users.Create(user);
				result.StatusCode = 201;
			}
			catch (InvalidObjectException ex)
            {
				result.Errors = ex.ToSimpleList();
				result.StatusCode = 400;
            }
			return Json(result);
		}

		[HttpPut]
		[Route("")]
		public DefaultResult Put([FromBody] UserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpDelete]
		[Route("")]
		public DefaultResult Delete([FromBody] UserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpGet]
		[Route("")]
		public DefaultResult Get(UserModel model, ushort quantity)
		{
			//todo: usar as propriedades preenchidas de UserModel como filtro
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}
	}
}
