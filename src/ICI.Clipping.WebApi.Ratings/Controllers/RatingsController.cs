using ICI.Clipping.Application;
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
	public class RatingsController : ControllerBase
	{
		private readonly ILogger<RatingsController> _logger;

		public RatingsController(ILogger<RatingsController> logger)
		{
			_logger = logger;
		}

	}
}
