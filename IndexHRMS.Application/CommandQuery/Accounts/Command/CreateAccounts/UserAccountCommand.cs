using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Application.Helper;

namespace IndexHRMS.Application.CommandQuery.Accounts.Command.CreateAccounts
{
    public record UserAccountCommand(
        string FirstName,
        string LastName,
        string Email,
        string Country,
        string Password,
        string ConfirmPassword)
   : IRequest<Message>;
}
