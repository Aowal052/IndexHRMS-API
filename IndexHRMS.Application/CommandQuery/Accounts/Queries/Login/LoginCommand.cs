using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Application.Helper;
using IndexHRMS.Domain.ResponseModel;

namespace IndexHRMS.Application.CommandQuery.Accounts.Queries.Login
{
    public record LoginCommand(
        string UserId,
        string Password)
   : IRequest<LoginResponseModel>;
}
