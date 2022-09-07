using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class SalaryDetail : BaseEntity
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
        /// IsBasic
        /// </summary>
        public bool IsBasic { get; set; }

        /// <summary>
        /// IsFixedAmount
        /// </summary>
        public bool IsFixedAmount { get; set; }

        /// <summary>
        /// Percentage
        /// </summary>
        public decimal Percentage { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// IsRecurring
        /// </summary>
        public bool IsRecurring { get; set; }

        /// <summary>
        /// IsDraft
        /// </summary>
        public bool IsDraft { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        #endregion Scalar

        #region Navigation

        /// <summary>
        /// SalaryHead
        /// </summary>
        public SalaryHead SalaryHead { get; set; }

        /// <summary>
        /// SalaryHeadId
        /// </summary>
        public string SalaryHeadId { get; set; }

        /// <summary>
        /// SalaryHeadName
        /// </summary>
        public string SalaryHeadName { get; set; }

        /// <summary>
        /// SalaryHeadCode
        /// </summary>
        public string SalaryHeadCode { get; set; }

        /// <summary>
        /// HeadType
        /// </summary>
        public string HeadType { get; set; }

        /// <summary>
        /// Salary
        /// </summary>
        public Salary Salary { get; set; }

        /// <summary>
        /// SalaryId
        /// </summary>
        public string SalaryId { get; set; }

        /// <summary>
        /// Employee
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// EmployeeId
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// PayScheduleDetail
        /// </summary>
        public PayScheduleDetail PayScheduleDetail { get; set; }

        /// <summary>
        /// PayScheduleDetailId
        /// </summary>
        public string PayScheduleDetailId { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public string CompanyId { get; set; }

        /// <summary>
        /// BranchId
        /// </summary>
        public string BranchId { get; set; }

        public Unit Unit { get; set; }
        public string UnitId { get; set; }
        public Company Company { get; set; }
        public Branch Branch { get; set; }

        /// <summary>
        /// DepartmentId
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// SectionId
        /// </summary>
        public string SectionId { get; set; }

        /// <summary>
        /// DesignationId
        /// </summary>
        public string DesignationId { get; set; }

        #endregion Navigation
    }
}
