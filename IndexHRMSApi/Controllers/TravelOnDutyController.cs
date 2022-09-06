using IndexHRMS.Application.CommandQuery.TravelOnDuty.Command.InsertTravelOnDutyInfo;
using IndexHRMS.Application.CommandQuery.TravelOnDuty.Queries.GetAllListByEmployee;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

		[HttpPost("getall-by-user")]
		[ProducesResponseType((int)HttpStatusCode.OK)]
		public async Task<ActionResult> GetAllByUserAsync(GetAprovedTravelOnDutyListQuery userId) => Ok(await _iMediator.Send(userId));


		[HttpPost("insert-travelOnDuty-info")]
		[ProducesResponseType((int)HttpStatusCode.OK)]
		public async Task<ActionResult<int>> CreateAsync([FromForm] TravelOnDutyInfoCommand command) => Ok(await _iMediator.Send(command));
	}
}
