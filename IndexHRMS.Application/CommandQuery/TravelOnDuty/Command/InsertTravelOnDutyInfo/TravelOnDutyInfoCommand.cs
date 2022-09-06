using IndexHRMS.Application.Helper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Application.CommandQuery.TravelOnDuty.Command.InsertTravelOnDutyInfo
{
	public record TravelOnDutyInfoCommand
	(
        string TravelOnDutyId,
        string Comment,
        string Latitude,
        string Longitude,
        string Address,
        List<IFormFile> Attachments
    ) : IRequest<Message>;
}
