using IndexHRMS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IndexHRMS.Entity.Dtos
{
	public class TravelOnDutyDto:BaseEntity
	{
        #region Scalar


        public string IdNew { get; set; }

        [Required(ErrorMessage = "Employee is required.")]
        public string EmployeeFullName { get; set; }

        public string SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public string EmployeeCode { get; set; }
        [NotMapped]
        public IList<IFormFile> Attachments { get; set; }
        /// <summary>
        /// Record active status.
        /// </summary>
        public bool Active { get; set; }

/// <summary>
/// Record delete status.
/// Default is false.
/// </summary>
        public bool Archive { get; set; }

        [Display(Name = "Work Visit")]
        [Required(ErrorMessage = "Work visit is required.")]
        public string WorkVisit { get; set; }

        [Display(Name = "Work Day")]
        [Required(ErrorMessage = "Work day is required.")]
        public string WorkDay { get; set; }

        public bool IsOthers { get; set; }

        /// <summary>
        /// If other then purpose
        /// </summary>
        public string Purpose { get; set; }

/// <summary>
/// If IsShotrHour=true then Total hour of tour
/// </summary>
        [Display(Name = "Hour")]
        public int TotalHour { get; set; }

        [Display(Name = "Minute")]
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

        [Required(ErrorMessage = "TimeFrom is required.")]
        public TimeSpan TimeFrom { get; set; }

        [Required(ErrorMessage = "TimeTo is required.")]
        public TimeSpan TimeTo { get; set; }

        /// <summary>
        /// Travel/Tour Time from
        /// </summary>
        [Required(ErrorMessage = "TimeFrom is required.")]
        public string StringTimeFrom { get; set; }

        /// <summary>
        /// Travel/Tour Time to
        /// </summary>
        [Required(ErrorMessage = "TimeTo is required.")]
        public string StringTimeTo { get; set; }

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
        /// After apply from ESS it will send to his/her responsiable person
        /// Rresponsiable person can approved or cancel or decline
        /// </summary>
        public bool IsCancel { get; set; }

        public DateTime? CancelationDate { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public string HistoryStatus { get; set; }
        public string BackBy { get; set; }
        public string BackTo { get; set; }
        public decimal? ApprovedDays { get; set; }

        /// <summary>
        /// IsAdminApproved
        /// </summary>
        public bool IsAdminApproved { get; set; }

        /// <summary>
        /// File attachemnt of the leave.
        /// </summary>
        public string FileAttachment { get; set; }

        public int? ApprovalLevel { get; set; }

        #endregion Scalar

        #region Navigation attributes

        public string EmployeeId { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public string CompanyId { get; set; }

/// <summary>
/// BranchId
/// </summary>
        [Display(Name = "Branch")]
        public string BranchId { get; set; }

        /// <summary>
        /// DepartmentId
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// DesignationId
        /// </summary>
        public string DesignationId { get; set; }

        #endregion Navigation attributes

        #region Extra Properties

        public string Type { get; set; }

        #endregion Extra Properties
    }
}
