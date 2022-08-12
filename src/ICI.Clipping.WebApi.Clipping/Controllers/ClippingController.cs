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
using ICI.Clipping.Data;

namespace ICI.Clipping.WebApi.Clippings.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ClippingController : ApiControllerBase
	{
		private readonly ILogger<ClippingController> _logger;
		private readonly ClippingContext _context;

		public ClippingController(ILogger<ClippingController> logger, ClippingContext context)
		{
			_logger = logger;
			_context = context;
		}

		[HttpGet]
		[Route("")]
		public JsonResult Get(uint quantity)
		{
			var result = new Models.PageResult();
			try
			{
				var clips = new Application.Clippings(_context);
				var list = clips.List(0, quantity - 1).ToList();
				result.List = list.Select(x => new ClippingModel()
				{
					Id = x.Id.ToString(),
					Image = x.Image,
					Link = x.Link,
					NewsChannel = x.NewsChannel,
					Publish = x.Publish.ToString("dd/MMM"),
					Rate = x.Rate + ".rate.png",
				}).ToList();
			}
			catch (InvalidObjectException ex)
			{
				result.Errors = ex.ToSimpleList();
			}
			return Json(result);
		}

	}
}
