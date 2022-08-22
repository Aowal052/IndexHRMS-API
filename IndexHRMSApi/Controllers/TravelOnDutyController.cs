using IndexHRMS.Application.CommandQuery.TravelOnDuty.Queries.GetAllListByEmployee;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace IndexHRMSApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TravelOnDutyController : BaseController
	{
		private readonly IMediator _iMediator;
		public TravelOnDutyController(IMediator mediator)
		{
			_iMediator = mediator;
		}

		[HttpGet("getall-by-user/{userId}")]
		[ProducesResponseType((int)HttpStatusCode.OK)]
		public async Task<ActionResult> GetAllByUserAsync(string userId) => Ok(await _iMediator.Send(new GetAprovedTravelOnDutyListQuery(userId)));
	}
}
