using ICI.Clipping.Application;
using ICI.Clipping.Data;
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
		private readonly ClippingContext _dbContext;

		public RatingController(ILogger<RatingController> logger, ClippingContext dbContext)
		{
			_logger = logger;
			_dbContext = dbContext;
		}

		[HttpPost]
		[Route("")]
		////[Authorize(Policy.Interactive)]
		public DefaultResult Post ([FromBody] RateModel model)
		{
			var response = new DefaultResult();
            try
            {
				var rates = new Application.Rates(_dbContext);
				var clippings = new Application.Clippings(_dbContext);
				var clipping = clippings.Get(model.ClippingId);
				rates.Insert(CurrentUser, clipping, model.Rate);
			}
			catch (Exception ex)
            {
				Response.StatusCode = 501;
				//todo: colocar listagem de erros
            }
			return response;
		}
	}
}
