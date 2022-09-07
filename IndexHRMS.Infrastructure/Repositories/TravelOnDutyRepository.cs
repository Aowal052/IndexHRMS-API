using IndexHRMS.Application.Interfaces;
using IndexHRMS.Entity.Dtos;
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

		public async Task<List<TravelOnDutyDto>> GetAllByUserAsync(string userId)
		{
			var data = await (from td in _context.TravelOnDuties
					   join u in _context.Users
					   on td.EmployeeId equals u.EmployeeId
					   join su in _context.Users
					   on td.SupervisorId equals su.UserId
					   where td.EmployeeId == userId
					   select new TravelOnDutyDto
					   {
						   IdNew = userId,
						   EmployeeFullName = u.FullName,
						   SupervisorId = u.SupervisorId,
						   SupervisorName = su.FullName,
						   EmployeeCode = td.EmployeeId,
						   Active = td.Active,
						   Archive=td.Archive,
						   WorkDay=td.WorkDay,
						   WorkVisit = td.WorkVisit,
						   IsAdminApproved=td.IsAdminApproved,
						   IsApproved=td.IsApproved,
						   IsOthers = td.IsOthers,
						   Purpose=td.Purpose,
						   TotalHour=td.TotalHour,
						   TotalMinute = td.TotalMinute,
						   AppliedBy=td.AppliedBy,
						   TimeFrom=td.TimeFrom,
						   TimeTo=td.TimeTo,
						   ApprovalLevel=td.ApprovalLevel,
						   ApprovedDate = td.ApprovedDate,
						   IsCancel = td.IsCancel,
						   CancelationDate = td.CancelationDate,
						   CompanyId=td.CompanyId,
						   DepartmentId=td.DepartmentId,
						   DesignationId=td.DesignationId,
						   Remarks =td.Remarks,
						   RequestDays=td.RequestDays,
						   EmployeeId=td.EmployeeId,
						   BranchId=td.BranchId,
						   Email = u.Email,
						   PhoneNumber = u.Phone
					   }).ToListAsync();
			return data;
		}

		//public async Task<IEnumerable<TravelOnDutyInfo>> GetAllTravelOnDutyByUserAsync(string userId)
		//{
		//	return await _context.TravelOnDutyInfo.Where(x => x.EmployeeId == userId).ToListAsync();
		//}
	}
}
