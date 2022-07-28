using ICI.Clipping.Application;
using ICI.Clipping.WebApi.Controllers;
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
	////[Authorize(Policy.Editor)]
	public class ClippingController : ApiControllerBase
	{
		private readonly ILogger<ClippingController> _logger;

		public ClippingController(ILogger<ClippingController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		[Route("")]
		public DefaultResult Post([FromBody] ClippingModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpPut]
		[Route("")]
		public DefaultResult Put([FromBody] ClippingModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpDelete]
		[Route("")]
		public DefaultResult Delete([FromBody] ClippingModel model)
		{
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}

		[HttpGet]
		[Route("")]
		public DefaultResult Get(ClippingModel model, ushort quantity)
		{
			//todo: usar as propriedades preenchidas de UserModel como filtro
			var response = new DefaultResult();
			throw new NotImplementedException();
			return response;
		}
	}
}
