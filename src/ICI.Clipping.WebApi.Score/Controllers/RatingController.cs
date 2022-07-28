using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Controllers;
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
	public class RatingController : ApiControllerBase
	{
		private readonly ILogger<RatingController> _logger;

		public RatingController(ILogger<RatingController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		[Route("")]
		////[Authorize(Policy.Interactive)]
		public DefaultResult Post ([FromBody] RateModel model)
		{
			throw new NotImplementedException();
		}
	}
}
