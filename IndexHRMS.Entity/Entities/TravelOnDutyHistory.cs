using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class TravelOnDutyHistory : BaseEntity
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
        /// SequenceNo
        /// </summary>
        public int SequenceNo { get; set; }

        /// <summary>
        /// Back application to previous person
        /// </summary>
        public bool IsBacked { get; set; }

        /// <summary>
        /// IsApproved
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// IsAdminApproval
        /// </summary>
        public bool IsAdminApproval { get; set; }

        /// <summary>
        /// ApprovedDate
        /// </summary>
        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// Leave approved date from
        /// </summary>
        public DateTime? ApprovedDateFrom { get; set; }

        /// <summary>
        /// Leave approved date to
        /// </summary>
        public DateTime? ApprovedDateTo { get; set; }

        /// <summary>
        /// Total leave approved days
        /// </summary>
        public decimal? ApprovedDays { get; set; }

        /// <summary>
        /// IsCanceled
        /// </summary>
        public bool IsCancel { get; set; }

        /// <summary>
        /// CanceledDate
        /// </summary>
        public DateTime? CancelationDate { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        public string Comments { get; set; }

        public string BackBy { get; set; }
        public string BackTo { get; set; }
        public string ForwardBy { get; set; }
        public string ForwardTo { get; set; }
        public string Status { get; set; }
        public bool Back { get; set; }

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
        /// Employee
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// EmployeeId
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// SupervisorId
        /// </summary>
        public string SupervisorId { get; set; }

        /// <summary>
        /// TravelOnDuty
        /// </summary>
        public virtual TravelOnDuty TravelOnDuty { get; set; }

        /// <summary>
        /// TravelOnDuty id
        /// </summary>
        public string TravelOnDutyId { get; set; }

        #endregion Navigation
    }
}
