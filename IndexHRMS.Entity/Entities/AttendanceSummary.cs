using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class AttendanceSummary : BaseEntity
    {
        #region Scalar attributes

        /// <summary>
        /// Primary key.
        /// </summary>
        public string Id { get; set; }

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
        /// Code name.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Total working day in a month.
        /// </summary>
        public int TotalWorkingDay { get; set; }

        /// <summary>
        /// Total present days in a month.
        /// </summary>
        public int TotalPresent { get; set; }

        /// <summary>
        /// Total absent days in a month.
        /// </summary>
        public int TotalAbsent { get; set; }

        /// <summary>
        /// Total late comming days in a month.
        /// </summary>
        public int TotalLate { get; set; }

        /// <summary>
        /// Total leave days in a month.
        /// </summary>
        public int TotalLeave { get; set; }

        /// <summary>
        /// Total leave without pay day in a month.
        /// </summary>
        public int TotalLWOP { get; set; }

        /// <summary>
        /// Total early left from office in a month.
        /// </summary>
        public decimal TotalEarlyLeft { get; set; }

        /// <summary>
        /// Total check out missing days in a month.
        /// </summary>
        public decimal TotalCheckOutMissing { get; set; }

        /// <summary>
        /// Total holiday in a month.
        /// </summary>
        public int TotalHoliday { get; set; }

        /// <summary>
        /// Total week day in a month.
        /// </summary>
        public decimal TotalWeekoff { get; set; }

        /// <summary>
        /// Total normal hour as per shifting hour in a month.
        /// </summary>
        public int TotalNormalHour { get; set; }

        /// <summary>
        /// Total working hour in a month.
        /// </summary>
        public int TotalWorkingHour { get; set; }

        /// <summary>
        /// Total travel on duty in a month.
        /// </summary>
        public decimal TotalTravelOnDuty { get; set; }

        /// <summary>
        /// Total overtime in Minute in a month.
        /// </summary>
        public decimal TotalOvertime { get; set; }

        /// <summary>
        /// Total night hour in minute in a month.
        /// </summary>
        public decimal TotalNightHour { get; set; }

        /// <summary>
        /// Summary processed flag.
        /// </summary>
        public bool IsProcessed { get; set; }

        #endregion Scalar attributes

        #region Audit

        public string AddedBy { get; set; }

        public DateTime AddedDate { get; set; }

        public string AddedFromIP { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedFromIP { get; set; }

        #endregion Audit

        #region Navigation attributes

        public virtual Employee Employee { get; set; }

        /// <summary>
        /// FK, with Employee entity.
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// PayScheduleDetail
        /// </summary>
        public virtual PayScheduleDetail PayScheduleDetail { get; set; }

        /// <summary>
        /// Pay Period.
        /// FK, with PayScheduleDetail entity.
        /// </summary>
        public string PayScheduleDetailId { get; set; }

        /// <summary>
        /// FK(Plain).
        /// </summary>
        public string CompanyId { get; set; }

        public Unit Unit { get; set; }
        public string UnitId { get; set; }
        public Company Company { get; set; }
        public Branch Branch { get; set; }

        /// <summary>
        /// FK(Plain).
        /// </summary>
        public string BranchId { get; set; }

        /// <summary>
        /// FK(Plain).
        /// </summary>
        public string DepartmentId { get; set; }

        public Department Department { get; set; }

        #endregion Navigation attributes
    }
}
