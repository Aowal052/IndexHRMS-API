using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class LoanRepayment : BaseEntity
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
        /// InstallmentNo
        /// </summary>
        public int InstallmentNo { get; set; }

        /// <summary>
        /// InstallmentDate
        /// </summary>
        public DateTime InstallmentDate { get; set; }

        /// <summary>
        /// RepaymentDate
        /// </summary>
        public DateTime RepaymentDate { get; set; }

        /// <summary>
        /// InstallmetAmount
        /// </summary>
        public decimal InstallmetAmount { get; set; }

        /// <summary>
        /// RepaymentAmount
        /// </summary>
        public decimal RepaymentAmount { get; set; }

        /// <summary>
        /// ScheduleNo
        /// </summary>
        public int ScheduleNo { get; set; }

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
        /// Loan
        /// </summary>
        public virtual Loan Loan { get; set; }

        /// <summary>
        /// LoanId
        /// </summary>
        public string LoanId { get; set; }

        /// <summary>
        /// LoanRepaymentSchedule
        /// </summary>
        public virtual LoanRepaymentSchedule LoanRepaymentSchedule { get; set; }

        /// <summary>
        /// LoanRepaymentScheduleId
        /// </summary>
        public string LoanRepaymentScheduleId { get; set; }

        /// <summary>
        /// Salary
        /// </summary>
        public virtual Salary Salary { get; set; }

        /// <summary>
        /// SalaryId
        /// </summary>
        public string SalaryId { get; set; }

        /// <summary>
        /// PayScheduleDetail
        /// </summary>
        public virtual PayScheduleDetail PayScheduleDetail { get; set; }

        /// <summary>
        /// PayScheduleDetailId
        /// </summary>
        public string PayScheduleDetailId { get; set; }

        #endregion Navigation
    }
}
