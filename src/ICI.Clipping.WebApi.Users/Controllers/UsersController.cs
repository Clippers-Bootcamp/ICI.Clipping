﻿using ICI.Clipping.WebApi.Users.Models;
using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICI.Clipping.WebApi.Controllers;
using ICI.Clipping.WebApi.Models;

namespace ICI.Clipping.WebApi.Users.Controllers
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
		public DefaultResult NewUser([FromBody] NewUserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		public DefaultResult CheckUser([FromBody] CheckUserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		public DefaultResult ChangeUser([FromBody] ChangeUserModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		public ListProfilesResult ListProfiles([FromBody] ListProfilesModel model)
		{
			var response = new ListProfilesResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpGet]
		[Route("[action]")]
		public ListProfilesResult ListProfiles(Guid userId, string email)
		{
			return ListProfiles(new ListProfilesModel() { Email = email, UserId = userId });
		}
	}
}
