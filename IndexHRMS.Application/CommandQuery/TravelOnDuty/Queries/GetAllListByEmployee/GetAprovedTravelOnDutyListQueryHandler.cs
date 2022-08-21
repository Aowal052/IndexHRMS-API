using AutoMapper;
using IndexHRMS.Application.Interfaces;
using IndexHRMS.Entity.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndexHRMS.Application.CommandQuery.TravelOnDuty.Queries.GetAllListByEmployee
{
	public class GetAprovedTravelOnDutyListQueryHandler : IRequestHandler<GetAprovedTravelOnDutyListQuery, List<TravelOnDutyDto>>
	{
		private readonly IMapper _iMapper;
		private readonly ITravelOnDutyRepository _iTravelOnDutyRepository;
		private readonly IHttpContextAccessor _iHttpContextAccessor;
		public GetAprovedTravelOnDutyListQueryHandler(IMapper iMapper, ITravelOnDutyRepository iTravelOnDutyRepository, IHttpContextAccessor iHttpContextAccessor)
		{
			_iMapper = iMapper;
			_iTravelOnDutyRepository = iTravelOnDutyRepository;
			_iHttpContextAccessor = iHttpContextAccessor;
		}

		public async Task<List<TravelOnDutyDto>> Handle(GetAprovedTravelOnDutyListQuery request, CancellationToken cancellationToken)
		{
			var items = await _iTravelOnDutyRepository.GetAllByUserAsync(request.userId);
			return _iMapper.Map<List<TravelOnDutyDto>>(items);
		}
	}
}
