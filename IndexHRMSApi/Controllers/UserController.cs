using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace IndexHRMSApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
        private readonly IMediator _iMediator;

        public UserController(IMediator iMediator)
        {
            _iMediator = iMediator;
        }

        [HttpGet("getall")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetAllAsync() => Ok(await _iMediator.Send(new GetGeoLocationListQuery()));
    }
}
