using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Application.Helper;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace IndexHRMS.Application.CommandQuery.Accounts.Command.CreateAccounts
{
    public record UserAccountCommand(
     string UserName,
	 string Gender,
     string Phone,
     string Email,
     string EmployeeId,
     string Password,
     string ConfirmPassword)
   : IRequest<Message>;
}
