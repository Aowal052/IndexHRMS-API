using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class Loan : BaseEntity
    {
        public Loan()
        {
            LoanResheduleApplications = new HashSet<LoanResheduleApplication>();
            LoanRepaymentSchedules = new HashSet<LoanRepaymentSchedule>();
            LoanRepayments = new HashSet<LoanRepayment>();
        }

        /// <summary>
        /// Primary key.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Code name.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Reference number
        /// </summary>
        public string RefNo { get; set; }

        /// <summary>
        /// TotalInstallment
        /// </summary>
        public int TotalInstallment { get; set; }

        /// <summary>
        /// TotalInstallmentPerYear
        /// </summary>
        public int TotalInstallmentPerYear { get; set; }

        /// <summary>
        /// DisbursementDate
        /// </summary>
        public DateTime DisbursementDate { get; set; }

        /// <summary>
        /// RepaymentStartDate
        /// </summary>
        public DateTime RepaymentStartDate { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// ProfitRate
        /// </summary>
        public decimal ProfitRate { get; set; }

        /// <summary>
        /// ProfitAmount
        /// </summary>
        public decimal ProfitAmount { get; set; }

        /// <summary>
        /// OtherAmount
        /// </summary>
        public decimal OtherAmount { get; set; }

        /// <summary>
        /// The get or ser Balance.
        /// Balance will decrease in after every repayment.
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// IsFullRepaid
        /// </summary>
        public bool IsFullRepaid { get; set; }

        /// <summary>
        /// IsDeductFromSalary
        /// </summary>
        public bool IsDeductFromSalary { get; set; }

        /// <summary>
        /// Record active status.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Record delete status.
        /// Default is false.
        /// </summary>
        public bool Archive { get; set; }

        #region Audit

        public string AddedBy { get; set; }

        public DateTime AddedDate { get; set; }

        public string AddedFromIP { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedFromIP { get; set; }

        #endregion Audit

        /// <summary>
        /// SalaryHead
        /// </summary>
        public virtual SalaryHead SalaryHead { get; set; }

        /// <summary>
        /// References with salary head.
        /// </summary>
        public string SalaryHeadId { get; set; }

        /// <summary>
        /// LoanType
        /// </summary>
        public virtual LoanType LoanType { get; set; }

        /// <summary>
        /// Reference with LoanType entity.
        /// </summary>
        public string LoanTypeId { get; set; }

        /// <summary>
        /// Employee
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// References with employee entity.
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// LoanApplication
        /// </summary>
        public virtual LoanApplication LoanApplication { get; set; }

        /// <summary>
        /// References with LoanApplication entity
        /// </summary>
        public string LoanApplicationId { get; set; }

        /// <summary>
        /// FK plain with company
        /// </summary>
        public string CompanyId { get; set; }

        /// <summary>
        /// FK plain with branch
        /// </summary>
        public string BranchId { get; set; }

        public Unit Unit { get; set; }
        public string UnitId { get; set; }

        /// <summary>
        /// LoanResheduleApplication
        /// </summary>
        public virtual ICollection<LoanResheduleApplication> LoanResheduleApplications { get; set; }

        /// <summary>
        /// LoanRepaymentSchedule
        /// </summary>
        public virtual ICollection<LoanRepaymentSchedule> LoanRepaymentSchedules { get; set; }

        /// <summary>
        /// LoanRepayment
        /// </summary>
        public virtual ICollection<LoanRepayment> LoanRepayments { get; set; }
    }
}
