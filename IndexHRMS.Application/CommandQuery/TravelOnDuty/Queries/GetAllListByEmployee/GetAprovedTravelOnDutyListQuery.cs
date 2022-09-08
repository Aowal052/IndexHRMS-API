using IndexHRMS.Domain.ResponseModel;
using IndexHRMS.Entity.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Application.CommandQuery.TravelOnDuty.Queries.GetAllListByEmployee
{
	public record GetAprovedTravelOnDutyListQuery(string userId) : IRequest<BaseResponseModel>;
}
