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

namespace ICI.Clipping.WebApi.Editor.Controllers
{
	[ApiController]
	[Route("[controller]")]
	////[Authorize(Policy.Editor)]
	public class UserController : ApiControllerBase
	{
		private readonly ILogger<UserController> _logger;

		public UserController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		[Route("")]
		public DefaultResult Post([FromBody] UserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
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
