using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Application.Interfaces;
using IndexHRMS.Entity.Entities;
using IndexHRMS.Infrastructure.Context;

namespace IndexHRMS.Infrastructure.Repositories
{
    public class AccountsRepository : RepositoryBase<User>, IAccountsRepository
    {
        public AccountsRepository(DataContext context): base(context)
        {

        }
    }
}
