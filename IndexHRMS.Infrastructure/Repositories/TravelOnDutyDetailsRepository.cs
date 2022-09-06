using IndexHRMS.Application.Interfaces;
using IndexHRMS.Entity.Entities;
using IndexHRMS.Infrastructure.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Infrastructure.Repositories
{
	public class TravelOnDutyInfoRepository : RepositoryBase<TravelOnDutyInfo>, ITravelOnDutyInfoRepository
	{
		public TravelOnDutyInfoRepository(DataContext context) : base(context)
		{
		}

		//public async Task<string> GetIdAsync()
		//{
		//	try
		//	{
		//		var idList = _context.TravelOnDutyInfo
		//			.OrderByDescending(x => x.TravelOnDutyDate)
		//			.Select(x => x.Id)
		//			.ToList();
		//		return idList.Any() ? idList.Max(x => Convert.ToInt64(x) + 1).ToString() : "1";
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}
	}
}
