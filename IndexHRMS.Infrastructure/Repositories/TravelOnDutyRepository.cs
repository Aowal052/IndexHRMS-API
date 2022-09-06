using IndexHRMS.Application.Interfaces;
using IndexHRMS.Entity.Entities;
using IndexHRMS.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Infrastructure.Repositories
{
	public class TravelOnDutyRepository : RepositoryBase<TravelOnDuty>, ITravelOnDutyRepository
	{
		public TravelOnDutyRepository(DataContext context) : base(context)
		{
		}

		public async Task<IEnumerable<TravelOnDuty>> GetAllByUserAsync(string userId)
		{
			return await _context.TravelOnDuties.Where(x => x.EmployeeId == userId && x.IsApproved==true).ToListAsync();
		}

		//public async Task<IEnumerable<TravelOnDutyInfo>> GetAllTravelOnDutyByUserAsync(string userId)
		//{
		//	return await _context.TravelOnDutyInfo.Where(x => x.EmployeeId == userId).ToListAsync();
		//}
	}
}
