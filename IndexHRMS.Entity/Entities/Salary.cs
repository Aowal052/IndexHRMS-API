using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class Salary : BaseEntity
    {
        public Salary()
        {
            SalaryDetails = new HashSet<SalaryDetail>();
            LoanRepayments = new HashSet<LoanRepayment>();
            SalaryDonations = new HashSet<SalaryDonation>();
            IncomeTaxes = new HashSet<IncomeTax>();
        }

        public string Id { get; set; }
        public bool Active { get; set; }

        public bool Archive { get; set; }

        /// <summary>
        /// Code name.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Employee Identification number
        /// </summary>
        public string EIN { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// MiddleName
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// NickName
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// DateOfBirth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// DateOfJoining
        /// </summary>
        public DateTime DateOfJoining { get; set; }

        /// <summary>
        /// ProcessDate
        /// </summary>
        public DateTime? ProcessDate { get; set; }

        /// <summary>
        /// PaymentDate
        /// </summary>
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// IsGrossPay
        /// </summary>
        public bool IsGrossPay { get; set; }

        /// <summary>
        /// Basic
        /// </summary>
        public decimal Basic { get; set; }

        /// <summary>
        /// TotalAllowance
        /// </summary>
        public decimal TotalAllowance { get; set; }

        /// <summary>
        /// TotalOtherAllowance
        /// </summary>
        public decimal TotalOtherAllowance { get; set; }

        /// <summary>
        /// TotalDeduction
        /// </summary>
        public decimal TotalDeduction { get; set; }

        /// <summary>
        /// TotalOvertime
        /// </summary>
        public decimal TotalOvertime { get; set; }

        /// <summary>
        /// TotalLWOP
        /// </summary>
        public decimal TotalLWOP { get; set; }

        /// <summary>
        /// TotalLateDeduction
        /// </summary>
        public decimal TotalLateDeduction { get; set; }

        /// <summary>
        /// Gross
        /// </summary>
        public decimal Gross { get; set; }

        /// <summary>
        /// NetSalary
        /// </summary>
        public decimal NetSalary { get; set; }

        /// <summary>
        /// LineNo
        /// </summary>
        public int LineNo { get; set; }

        /// <summary>
        /// IsDraft
        /// </summary>
        public bool IsDraft { get; set; }

        /// <summary>
        /// IsPaid
        /// </summary>
        public bool IsPaid { get; set; }

        /// <summary>
        /// IsPostponed
        /// </summary>
        public bool IsPostponed { get; set; }

        /// <summary>
        /// IsApproved
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// ApprovedDate
        /// </summary>
        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// ApprovedBy
        /// </summary>
        public string ApprovedBy { get; set; }

        public int CD { get; set; }
        public int Abs { get; set; }
        public int Lv { get; set; }
        public int Wrk { get; set; }
        public int Lt { get; set; }
        public decimal OTHour { get; set; }

        public Employee Employee { get; set; }

        public string EmployeeId { get; set; }

        public PaySchedule PaySchedule { get; set; }

        /// <summary>
        /// PayScheduleId
        /// </summary>
        public string PayScheduleId { get; set; }

        /// <summary>
        /// PayScheduleDetail
        /// </summary>
        public PayScheduleDetail PayScheduleDetail { get; set; }

        /// <summary>
        /// Pay Period
        /// </summary>
        public string PayScheduleDetailId { get; set; }

        /// <summary>
        /// CurrentBankId
        /// </summary>
        public string BankId { get; set; }

        /// <summary>
        /// CurrentBankName
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// CurrentBankBranchId
        /// </summary>
        public string BankBranchId { get; set; }

        /// <summary>
        /// CurrentBankBranchName
        /// </summary>
        public string BankBranchName { get; set; }

        /// <summary>
        /// CurrentBankAccountType
        /// </summary>
        public string BankAccountType { get; set; }

        /// <summary>
        /// CurrentBankAccountNo
        /// </summary>
        public string BankAccountNo { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public string CompanyId { get; set; }

        /// <summary>
        /// CurrentCompanyName
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// BranchId
        /// </summary>
        public string BranchId { get; set; }

        public string UnitId { get; set; }

        public string UnitName { get; set; }

        /// <summary>
        /// CurrentBranchName
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// DepartmentId
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// CurrentDepartmentName
        /// </summary>
        public string DepartmentName { get; set; }

        public int DepartmentSequence { get; set; }

        public string SectionId { get; set; }

        public string SectionName { get; set; }

        /// <summary>
        /// DesignationId
        /// </summary>
        public string DesignationId { get; set; }

        /// <summary>
        /// CurrentDesignationName
        /// </summary>
        public string DesignationName { get; set; }

        /// <summary>
        /// CurrentPayPolicyId
        /// </summary>
        public string PayPolicyId { get; set; }

        /// <summary>
        /// CurrentSalaryStructureId
        /// </summary>
        public string SalaryStructureId { get; set; }

        public string PfPolicyId { get; set; }

        public string GratuityPolicyId { get; set; }

        #region Collection

        public ICollection<IncomeTax> IncomeTaxes { get; set; }

        /// <summary>
        /// SalaryDonation
        /// </summary>
        public ICollection<SalaryDonation> SalaryDonations { get; set; }

        /// <summary>
        /// LoanRepayment
        /// </summary>
        public ICollection<LoanRepayment> LoanRepayments { get; set; }

        /// <summary>
        /// SalaryDetail
        /// </summary>
        public ICollection<SalaryDetail> SalaryDetails { get; set; }

        #endregion Collection

        #region Audit

        public string AddedBy { get; set; }

        public DateTime AddedDate { get; set; }

        public string AddedFromIP { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedFromIP { get; set; }

        #endregion Audit
    }
}
