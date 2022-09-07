using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class IncomeTax : BaseEntity
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
        /// OpeningBalance
        /// </summary>
        public decimal OpeningBalance { get; set; }

        /// <summary>
        /// TaxAmount
        /// </summary>
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// ChallanNo
        /// </summary>
        public string ChallanNo { get; set; }

        /// <summary>
        /// ChallanDate
        /// </summary>
        public DateTime? ChallanDate { get; set; }

        /// <summary>
        /// IsPaid
        /// </summary>
        public bool IsPaid { get; set; }

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
        /// Salary
        /// </summary>
        public virtual Salary Salary { get; set; }

        /// <summary>
        /// SalaryId
        /// </summary>
        public string SalaryId { get; set; }

        /// <summary>
        /// SalaryHead
        /// </summary>
        public virtual SalaryHead SalaryHead { get; set; }

        /// <summary>
        /// SalaryHeadId
        /// </summary>
        public string SalaryHeadId { get; set; }

        /// <summary>
        /// Employee
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// EmployeeId
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// PayScheduleDetail
        /// </summary>
        public virtual PayScheduleDetail PayScheduleDetail { get; set; }

        /// <summary>
        /// PayScheduleDetailId
        /// </summary>
        public string PayScheduleDetailId { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public string CompanyId { get; set; }

        public Company Company { get; set; }

        /// <summary>
        /// BranchId
        /// </summary>
        public string BranchId { get; set; }

        public Branch Branch { get; set; }
        public string UnitId { get; set; }
        public Unit Unit { get; set; }
        public string DepartmentId { get; set; }

        #endregion Navigation
    }
}
