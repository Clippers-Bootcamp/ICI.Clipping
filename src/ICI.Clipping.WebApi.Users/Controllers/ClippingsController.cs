using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Editor.Models;
using ICI.Clipping.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICI.Clipping.WebApi.Clippings.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ClippingsController : ControllerBase
	{
		private readonly ILogger<ClippingsController> _logger;

		public ClippingsController(ILogger<ClippingsController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Editor)]
		public DefaultResult Create([FromBody] ClippingModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Editor)]
		public DefaultResult Update([FromBody] ClippingModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Editor)]
		public DefaultResult Delete([FromBody] ClippingModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPost]
		[Route("[action]")]
		[Authorize(Policy.Editor)]
		public DefaultResult List([FromBody] ClippingModel model, ushort quantity)
		{
			//todo: usar as propriedades preenchidas de UserModel como filtro
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}
	}
}
