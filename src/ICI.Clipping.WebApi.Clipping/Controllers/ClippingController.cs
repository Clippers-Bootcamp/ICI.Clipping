using ICI.Clipping.WebApi.Clippings.Models;
using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using ICI.Clipping.WebApi.Controllers;

namespace ICI.Clipping.WebApi.Clippings.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ClippingController : ApiControllerBase
	{
		private readonly ILogger<ClippingController> _logger;

		public ClippingController(ILogger<ClippingController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		[Route("")]
		public PageResult Get(GetPageModel model)
		{
			var response = new PageResult();
			throw new NotImplementedException();
			return response;
		}

	}
}
