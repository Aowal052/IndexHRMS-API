using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class PayScheduleDetail : BaseEntity
    {
        public PayScheduleDetail()
        {
            SalaryAdditionalInfoes = new HashSet<SalaryAdditionalInfo>();
            EmployeeBonuses = new HashSet<EmployeeBonus>();
            LoanRepayments = new HashSet<LoanRepayment>();
            AttendanceSummaries = new HashSet<AttendanceSummary>();
            SalaryDonations = new HashSet<SalaryDonation>();
            PayScheduleDetails = new HashSet<PayScheduleDetail>();
            IncomeTaxes = new HashSet<IncomeTax>();
        }

        public string Id { get; set; }

        public bool Active { get; set; }

        public bool Archive { get; set; }

        public string Code { get; set; }

        public int PayYear { get; set; }

        public string Title { get; set; }

        public int Sequence { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? SalaryProcessDate { get; set; }

        public DateTime? BonusProcessDate { get; set; }

        public DateTime? AttendanceProcessDate { get; set; }

        public bool IsLocked { get; set; }

        public virtual ICollection<IncomeTax> IncomeTaxes { get; set; }

        public virtual ICollection<PayScheduleDetail> PayScheduleDetails { get; set; }

        public virtual ICollection<SalaryDonation> SalaryDonations { get; set; }

        public virtual ICollection<SalaryAdditionalInfo> SalaryAdditionalInfoes { get; set; }

        public virtual ICollection<EmployeeBonus> EmployeeBonuses { get; set; }

        public virtual ICollection<LoanRepayment> LoanRepayments { get; set; }

        public virtual ICollection<AttendanceSummary> AttendanceSummaries { get; set; }

        public virtual PaySchedule PaySchedule { get; set; }

        public string PayScheduleId { get; set; }

        public string CompanyId { get; set; }

        public string BranchId { get; set; }

        public Unit Unit { get; set; }
        public string UnitId { get; set; }

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
