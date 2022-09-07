using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class PaySchedule : BaseEntity
    {
        public PaySchedule()
        {
            Salaries = new HashSet<Salary>();
            PayScheduleDetails = new HashSet<PayScheduleDetail>();
        }

        public string Id { get; set; }

        public bool Active { get; set; }

        public bool Archive { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string PayFrequency { get; set; }

        public int ProcessDayOfPeriod { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string PayYear { get; set; }

        public bool IsCurrent { get; set; }
        public bool IsLocked { get; set; }
        public int NumberOfPeriods { get; set; }

        public virtual ICollection<Salary> Salaries { get; set; }

        public virtual ICollection<PayScheduleDetail> PayScheduleDetails { get; set; }

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
