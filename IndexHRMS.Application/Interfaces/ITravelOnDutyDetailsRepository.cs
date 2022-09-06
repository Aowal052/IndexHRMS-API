using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Application.Interfaces
{
	public interface ITravelOnDutyInfoRepository : IAsyncRepository<TravelOnDutyInfo>
	{
		//Task<string> GetIdAsync();
	}
}
