using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Models;
using ICI.Clipping.WebApi.Ratings.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Ratings.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Authorize(Policy = "Editor")]
	public class RatingsController : ControllerBase
	{
		private readonly ILogger<RatingsController> _logger;

		public RatingsController(ILogger<RatingsController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Interactive)]
		public DefaultResult Rate ([FromBody] RateModel model)
		{
			throw new NotImplementedException();
		}
	}
}
