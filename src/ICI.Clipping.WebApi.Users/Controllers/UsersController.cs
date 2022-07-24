﻿using ICI.Clipping.WebApi.Editor.Models;
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
	public class UsersController : ApiControllerBase
	{
		private readonly ILogger<UsersController> _logger;

		public UsersController(ILogger<UsersController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Editor)]
		public DefaultResult Create([FromBody] UserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Editor)]
		public DefaultResult Update([FromBody] UserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Editor)]
		public DefaultResult Delete([FromBody] UserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Editor)]
		public DefaultResult List([FromBody] UserModel model, ushort quantity)
		{
			//todo: usar as propriedades preenchidas de UserModel como filtro
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}
	}
}
