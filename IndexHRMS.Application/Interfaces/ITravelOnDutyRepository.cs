using IndexHRMS.Entity.Dtos;
using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Application.Interfaces
{
	public interface ITravelOnDutyRepository : IAsyncRepository<TravelOnDuty>
	{
		Task<List<TravelOnDutyDto>> GetAllByUserAsync(string userId);
		//Task<IEnumerable<TravelOnDutyInfo>> GetAllTravelOnDutyByUserAsync(string userId);
	}
}
