using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Entity.Entities;

namespace IndexHRMS.Application.Interfaces
{
    public interface ITokenRepository
    {
        string CreateToken(User user);
    }
}
