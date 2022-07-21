using ICI.Clipping.Clippings.WebApi.Models;
using ICI.Clipping.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.Clipping.Clippings.WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PortalController : ControllerBase
	{
		private readonly ILogger<PortalController> _logger;

		public PortalController(ILogger<PortalController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		[Route("[action]")]
		public PageResult GetPage([FromBody] GetPageModel model)
		{
			var response = new PageResult();
			throw new NotImplementedException();
			return response;
		}

	}
}
