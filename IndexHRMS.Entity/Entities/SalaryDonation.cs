using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class SalaryDonation : BaseEntity
    {
        #region Scalar

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
        /// Fixed amount flag.
        /// </summary>
        public bool FixedAmount { get; set; }

        /// <summary>
        /// IsPayByDay
        /// </summary>
        public bool PayByDay { get; set; }

        /// <summary>
        /// Hours donate if IsPayByDay=false
        /// </summary>
        public decimal Hours { get; set; }

        /// <summary>
        /// Multiplier
        /// </summary>
        public decimal Multiplier { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gross or basic/net payment
        /// </summary>
        public string DonationSource { get; set; }

        #endregion Scalar

        #region Audit

        public string AddedBy { get; set; }

        public DateTime AddedDate { get; set; }

        public string AddedFromIP { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedFromIP { get; set; }

        #endregion Audit

        #region Navigation

        /// <summary>
        /// Employee entity.
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Foreign key
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Reference with company.
        /// </summary>
        public string CompanyId { get; set; }

        /// <summary>
        /// Reference with branch.
        /// </summary>
        public string BranchId { get; set; }

        public Unit Unit { get; set; }
        public string UnitId { get; set; }
        public Company Company { get; set; }
        public Branch Branch { get; set; }

        /// <summary>
        /// Reference with department
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// Reference with Section Name.
        /// </summary>
        public string SectionId { get; set; }

        /// <summary>
        /// Referenc with designation.
        /// </summary>
        public string DesignationId { get; set; }

        /// <summary>
        /// PayScheduleDetail entity.
        /// </summary>
        public virtual PayScheduleDetail PayScheduleDetail { get; set; }

        /// <summary>
        /// Foreing Key.
        /// </summary>
        public string PayScheduleDetailId { get; set; }

        /// <summary>
        /// Salary entity.
        /// </summary>
        public virtual Salary Salary { get; set; }

        /// <summary>
        /// Foreign key.
        /// </summary>
        public string SalaryId { get; set; }

        #endregion Navigation
    }
}
