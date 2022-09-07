using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class SalaryHead : BaseEntity
    {
        public SalaryHead()
        {
            SalaryDetails = new HashSet<SalaryDetail>();
            SalaryAdditionalInfoes = new HashSet<SalaryAdditionalInfo>();
            MiscellAllowanceDeductions = new HashSet<MiscellAllowanceDeduction>();
            CharityFunds = new HashSet<CharityFund>();
            BonusTypes = new HashSet<BonusType>();
            AttendanceBonuses = new HashSet<AttendanceBonus>();
            LoanTypes = new HashSet<LoanType>();
            OvertimePolicies = new HashSet<OvertimePolicy>();
            LatePolicies = new HashSet<LatePolicy>();
            BonusTypes = new HashSet<BonusType>();
            SalaryStructureDetails = new HashSet<SalaryStructureDetail>();
            AbsentPolicies = new HashSet<AbsentPolicy>();
            LatePolicies = new HashSet<LatePolicy>();
            ProvidentFunds = new HashSet<ProvidentFund>();
            IncomeTaxes = new HashSet<IncomeTax>();
        }

        public string Id { get; set; }

        public bool Active { get; set; }

        public bool Archive { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int LineNo { get; set; }

        public string Description { get; set; }

        public bool IsRecurring { get; set; }

        public bool IsBasic { get; set; }

        public string SalaryHeadTypeId { get; set; }

        public string SalaryHeadTypeName { get; set; }

        public string CompanyId { get; set; }

        public string BranchId { get; set; }

        public Unit Unit { get; set; }
        public string UnitId { get; set; }
        public virtual ICollection<IncomeTax> IncomeTaxes { get; set; }

        public virtual ICollection<ProvidentFund> ProvidentFunds { get; set; }

        public virtual ICollection<SalaryDetail> SalaryDetails { get; set; }

        public virtual ICollection<SalaryAdditionalInfo> SalaryAdditionalInfoes { get; set; }

        public virtual ICollection<MiscellAllowanceDeduction> MiscellAllowanceDeductions { get; set; }

        public virtual ICollection<Hardship> Hardships { get; set; }

        public virtual ICollection<CharityFund> CharityFunds { get; set; }

        public virtual ICollection<BonusType> BonusTypes { get; set; }

        public virtual ICollection<AttendanceBonus> AttendanceBonuses { get; set; }

        public virtual ICollection<LoanType> LoanTypes { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }

        public virtual ICollection<OvertimePolicy> OvertimePolicies { get; set; }

        public virtual ICollection<LatePolicy> LatePolicies { get; set; }

        public virtual ICollection<SalaryStructureDetail> SalaryStructureDetails { get; set; }

        public virtual ICollection<AbsentPolicy> AbsentPolicies { get; set; }

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
