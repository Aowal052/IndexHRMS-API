using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Entity.Entities
{
	public class TravelOnDuty:BaseEntity
	{

        #region Scalar


        /// <summary>
        /// Record active status.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Record delete status.
        /// Default is false.
        /// </summary>
        public bool Archive { get; set; }

        /// <summary>
        /// Factory visit, Customer visit, Business travel
        /// </summary>
        public string WorkVisit { get; set; }

        /// <summary>
        /// Full day, Half day, Short day
        /// </summary>
        public string WorkDay { get; set; }

        public bool IsOthers { get; set; }

        /// <summary>
        /// If other then purpose
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// If IsShotrHour=true then Total hour of tour
        /// </summary>
        public int TotalHour { get; set; }

        public int TotalMinute { get; set; }

        /// <summary>
        /// Travel/Tour date from
        /// </summary>
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Travel/Tour date to
        /// </summary>
        public DateTime DateTo { get; set; }

        /// <summary>
        /// RequestDays
        /// </summary>
        public decimal RequestDays { get; set; }

        /// <summary>
        /// Travel/Tour Time from
        /// </summary>
        public TimeSpan TimeFrom { get; set; }

        /// <summary>
        /// Travel/Tour Time to
        /// </summary>
        public TimeSpan TimeTo { get; set; }

        /// <summary>
        /// Self, Admin
        /// </summary>
        public string AppliedBy { get; set; }

        /// <summary>
        /// After apply from ESS it will send to his/her responsiable person
        /// Rresponsiable person can approved or cancel or decline
        /// </summary>
        public bool IsApproved { get; set; }

        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// Total leave approved days
        /// </summary>
        public decimal? ApprovedDays { get; set; }

        /// <summary>
        /// After apply from ESS it will send to his/her responsiable person
        /// Rresponsiable person can approved or cancel or decline
        /// </summary>
        public bool IsCancel { get; set; }

        public DateTime? CancelationDate { get; set; }
        public string Remarks { get; set; }

        /// <summary>
        /// IsAdminApproved
        /// </summary>
        public bool IsAdminApproved { get; set; }

        /// <summary>
        /// File attachemnt of the leave.
        /// </summary>
        public string FileAttachment { get; set; }

        public string Status { get; set; }
        public string SupervisorId { get; set; }
        public int? ApprovalLevel { get; set; }

        #endregion Scalar


        //public virtual Employee Employee { get; set; }
        public string EmployeeId { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public string CompanyId { get; set; }

        /// <summary>
        /// BranchId
        /// </summary>
        public string BranchId { get; set; }

        //public Unit Unit { get; set; }
        public string UnitId { get; set; }

        /// <summary>
        /// DepartmentId
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// DesignationId
        /// </summary>
        public string DesignationId { get; set; }
    }
}
