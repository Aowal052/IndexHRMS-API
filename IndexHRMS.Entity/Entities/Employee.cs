using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class Employee : BaseEntity
    {
        #region Constractor

        public Employee()
        {
            SalaryAdditionalInfoes = new HashSet<SalaryAdditionalInfo>();
            Salaries = new HashSet<Salary>();
            MiscellAllowanceDeductions = new HashSet<MiscellAllowanceDeduction>();
            EmployeeBonuses = new HashSet<EmployeeBonus>();
            LoanResheduleApplications = new HashSet<LoanResheduleApplication>();
            LoanApprovers = new HashSet<LoanApprover>();
            LoanApprovalHistories = new HashSet<LoanApprovalHistory>();
            LoanApplications = new HashSet<LoanApplication>();
            Loans = new HashSet<Loan>();
            LeaveBalances = new HashSet<LeaveBalance>();
            LeaveApplicationHistories = new HashSet<LeaveApplicationHistory>();
            LeaveApplicationDetails = new HashSet<LeaveApplicationDetail>();
            LeaveApplications = new HashSet<LeaveApplication>();
            EmployeeTrainingInfoes = new HashSet<EmployeeTrainingInfo>();
            EmployeeStatuses = new HashSet<EmployeeStatus>();
            EmployeeShifts = new HashSet<EmployeeShift>();
            EmployeeServicePeriods = new HashSet<EmployeeServicePeriod>();
            EmployeeSalaryStructures = new HashSet<EmployeeSalaryStructure>();
            EmployeeProfesionalInfoes = new HashSet<EmployeeProfesionalInfo>();
            EmployeePFPolicies = new HashSet<EmployeePFPolicy>();
            EmployeeOvertimePolicies = new HashSet<EmployeeOvertimePolicy>();
            EmployeeLeaveCategories = new HashSet<EmployeeLeaveCategory>();
            EmployeeLatePolicies = new HashSet<EmployeeLatePolicy>();
            EmployeeHardships = new HashSet<EmployeeHardship>();
            EmployeeGratuityPolicies = new HashSet<EmployeeGratuityPolicy>();
            EmployeeFoodSubsidies = new HashSet<EmployeeFoodSubsidy>();
            EmployeeDocuments = new HashSet<EmployeeDocument>();
            EmployeeDesignations = new HashSet<EmployeeDesignation>();
            EmployeeDepartments = new HashSet<EmployeeDepartment>();
            EmployeeCompanies = new HashSet<EmployeeCompany>();
            EmployeeChildrens = new HashSet<EmployeeChildren>();
            EmployeeCharityFunds = new HashSet<EmployeeCharityFund>();
            EmployeeBranches = new HashSet<EmployeeBranch>();
            EmployeeBanks = new HashSet<EmployeeBank>();
            EmployeeAttendanceBonuses = new HashSet<EmployeeAttendanceBonus>();
            EmployeeAssets = new HashSet<EmployeeAsset>();
            EmployeeAcademicInfoes = new HashSet<EmployeeAcademicInfo>();
            EmployeeAbsentPolicies = new HashSet<EmployeeAbsentPolicy>();
            AttendanceDailies = new HashSet<AttendanceDaily>();
            AttendanceLogs = new HashSet<AttendanceLog>();
            AttendanceSummaries = new HashSet<AttendanceSummary>();
            SalaryDetails = new HashSet<SalaryDetail>();
            SalaryDonations = new HashSet<SalaryDonation>();
            ProvidentFunds = new HashSet<ProvidentFund>();
            IncomeTaxes = new HashSet<IncomeTax>();
            UtilitySalaryHistories = new HashSet<UtilitySalaryHistory>();
            UtilitySalaries = new HashSet<UtilitySalary>();
            EmployeeUtilitySalaries = new HashSet<EmployeeUtilitySalary>();
        }

        #endregion Constractor

        #region Scalar

        public string Id { get; set; }
        public string Code { get; set; }

        /// <summary>
        /// For employee manual ordering.
        /// </summary>
        public int LineNo { get; set; }

        /// <summary>
        /// Employee Title Mr, Mis
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Employee first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Employee middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Employee last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Employee nick name.
        /// </summary>
        public string NickName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public DateTime? SpouseDOB { get; set; }
        public string Nationality { get; set; }
        public string NationalId { get; set; }
        public string PassportNo { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public string TIN { get; set; }
        public byte[] Image { get; set; }
        public string WorkingStatus { get; set; }
        public string JobStatus { get; set; }
        public int? ProbationPeriod { get; set; }
        public int? ExtendedProbationPeriod { get; set; }
        public int? IncrementPeriod { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public DateTime? IncrementDate { get; set; }
        public string EmergencyContactPerson { get; set; }
        public string RelationWithEmployee { get; set; }
        public string EmergencyContactPersonPhone { get; set; }
        public string EmergencyContactPersonEmail { get; set; }
        public string EmergencyContactPersonAddress { get; set; }
        public bool SameAsPresentAddress { get; set; }
        public bool DepartmentHead { get; set; }
        public bool TaxExempted { get; set; }
        public bool EmailOff { get; set; }
        public bool IsSupervisor { get; set; }
        public bool Smoker { get; set; }
        public string Comments { get; set; }
        public bool Active { get; set; }
        public bool Archive { get; set; }

        #endregion Scalar

        #region Navigation

        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string UnitId { get; set; }
        public string DepartmentId { get; set; }
        public string SectionId { get; set; }
        public string DesignationId { get; set; }
        public string PresentAddressMasterId { get; set; }
        public string PermanentAddressMasterId { get; set; }
        public string UserId { get; set; }
        public string UserGroupId { get; set; }
        public string BankId { get; set; }
        public string BankBranchId { get; set; }
        public string BankAccountNo { get; set; }
        public string EmployeeStatusId { get; set; }
        public string AbsentPolicyId { get; set; }
        public string LatePolicyId { get; set; }
        public string OvertimePolicyId { get; set; }
        public string ShiftId { get; set; }
        public string PFMemberId { get; set; }
        public string LeaveCategoryId { get; set; }
        public string SalaryStructureId { get; set; }
        public string PFPolicyId { get; set; }
        public string GradeId { get; set; }
        public string LevelId { get; set; }
        public string CollarId { get; set; }
        public string SupervisorId { get; set; }
        public Company Company { get; set; }
        public Branch Branch { get; set; }
        public Unit Unit { get; set; }
        public Department Department { get; set; }
        public Designation Designation { get; set; }
        public LeaveCategory LeaveCategory { get; set; }

        #endregion Navigation

        #region Collections

        /// <summary>
        /// IncomeTax
        /// </summary>
        public virtual ICollection<IncomeTax> IncomeTaxes { get; set; }

        /// <summary>
        /// ProvidentFund
        /// </summary>
        public virtual ICollection<ProvidentFund> ProvidentFunds { get; set; }

        /// <summary>
        /// SalaryDonation
        /// </summary>
        public virtual ICollection<SalaryDonation> SalaryDonations { get; set; }

        /// <summary>
        /// SalaryDetail
        /// </summary>
        public virtual ICollection<SalaryDetail> SalaryDetails { get; set; }

        /// <summary>
        /// SalaryAdditionalInfo
        /// </summary>
        public virtual ICollection<SalaryAdditionalInfo> SalaryAdditionalInfoes { get; set; }

        /// <summary>
        /// Salary
        /// </summary>
        public virtual ICollection<Salary> Salaries { get; set; }

        /// <summary>
        /// EmployeeBonus
        /// </summary>
        public virtual ICollection<EmployeeBonus> EmployeeBonuses { get; set; }

        /// <summary>
        /// LoanResheduleApplication
        /// </summary>
        public virtual ICollection<LoanResheduleApplication> LoanResheduleApplications { get; set; }

        /// <summary>
        /// LoanApprover
        /// </summary>
        public virtual ICollection<LoanApprover> LoanApprovers { get; set; }

        /// <summary>
        /// LoanApprovalHistory
        /// </summary>
        public virtual ICollection<LoanApprovalHistory> LoanApprovalHistories { get; set; }

        /// <summary>
        /// LoanApplications
        /// </summary>
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }

        /// <summary>
        /// Loan
        /// </summary>
        public virtual ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// LeaveBalance
        /// </summary>
        public virtual ICollection<LeaveBalance> LeaveBalances { get; set; }

        /// <summary>
        /// LeaveApplicationHistory
        /// </summary>
        public virtual ICollection<LeaveApplicationHistory> LeaveApplicationHistories { get; set; }

        /// <summary>
        /// LeaveApplicationDetail
        /// </summary>
        public virtual ICollection<LeaveApplicationDetail> LeaveApplicationDetails { get; set; }

        /// <summary>
        /// LeaveApplication
        /// </summary>
        public virtual ICollection<LeaveApplication> LeaveApplications { get; set; }

        /// <summary>
        /// EmployeeDocument
        /// </summary>
        public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; }

        /// <summary>
        /// EmployeeAttendanceBonus
        /// </summary>
        public virtual ICollection<EmployeeAttendanceBonus> EmployeeAttendanceBonuses { get; set; }

        /// <summary>
        /// EmployeeAbsentPolicy
        /// </summary>
        public virtual ICollection<EmployeeAbsentPolicy> EmployeeAbsentPolicies { get; set; }

        /// <summary>
        /// AttendanceSummary
        /// </summary>
        public virtual ICollection<AttendanceSummary> AttendanceSummaries { get; set; }

        /// <summary>
        /// Employee daily attendance AttendanceLog
        /// </summary>
        public virtual ICollection<AttendanceLog> AttendanceLogs { get; set; }

        /// <summary>
        /// AttendanceDaily collections.
        /// </summary>
        public virtual ICollection<AttendanceDaily> AttendanceDailies { get; set; }

        /// <summary>
        /// EmployeeLatePolicy
        /// </summary>
        public virtual ICollection<EmployeeLatePolicy> EmployeeLatePolicies { get; set; }

        /// <summary>
        /// EmployeeOvertimePolicy
        /// </summary>
        public virtual ICollection<EmployeeOvertimePolicy> EmployeeOvertimePolicies { get; set; }

        /// <summary>
        /// EmployeeShift
        /// </summary>
        public virtual ICollection<EmployeeShift> EmployeeShifts { get; set; }

        /// <summary>
        /// EmployeeAcademicInfo
        /// </summary>
        public virtual ICollection<EmployeeAcademicInfo> EmployeeAcademicInfoes { get; set; }

        /// <summary>
        /// EmployeeAsset
        /// </summary>
        public virtual ICollection<EmployeeAsset> EmployeeAssets { get; set; }

        /// <summary>
        /// EmployeeBank
        /// </summary>
        public virtual ICollection<EmployeeBank> EmployeeBanks { get; set; }

        /// <summary>
        /// EmployeeBranch
        /// </summary>
        public virtual ICollection<EmployeeBranch> EmployeeBranches { get; set; }

        /// <summary>
        ///
        /// </summary>
        public virtual ICollection<EmployeeUnit> EmployeeSubBranches { get; set; }

        /// <summary>
        /// EmployeeChildren
        /// </summary>
        public virtual ICollection<EmployeeChildren> EmployeeChildrens { get; set; }

        /// <summary>
        /// EmployeeCompany
        /// </summary>
        public virtual ICollection<EmployeeCompany> EmployeeCompanies { get; set; }

        /// <summary>
        /// EmployeeDepartment
        /// </summary>
        public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; }

        /// <summary>
        /// EmployeeDesignation
        /// </summary>
        public virtual ICollection<EmployeeDesignation> EmployeeDesignations { get; set; }

        /// <summary>
        /// EmployeeProfesionalInfo
        /// </summary>
        public virtual ICollection<EmployeeProfesionalInfo> EmployeeProfesionalInfoes { get; set; }

        /// <summary>
        /// EmployeeTrainingInfo
        /// </summary>
        public virtual ICollection<EmployeeTrainingInfo> EmployeeTrainingInfoes { get; set; }

        /// <summary>
        /// EmployeeStatus
        /// </summary>
        public virtual ICollection<EmployeeStatus> EmployeeStatuses { get; set; }

        /// <summary>
        /// EmployeeGratuityPolicy
        /// </summary>
        public virtual ICollection<EmployeeGratuityPolicy> EmployeeGratuityPolicies { get; set; }

        /// <summary>
        /// EmployeeLeaveCategory
        /// </summary>
        public virtual ICollection<EmployeeLeaveCategory> EmployeeLeaveCategories { get; set; }

        /// <summary>
        /// EmployeeSalaryStructure
        /// </summary>
        public virtual ICollection<EmployeeSalaryStructure> EmployeeSalaryStructures { get; set; }

        /// <summary>
        /// EmployeeSalaryStructure
        /// </summary>
        public virtual ICollection<EmployeePFPolicy> EmployeePFPolicies { get; set; }

        /// <summary>
        /// EmployeeCharityFund
        /// </summary>
        public virtual ICollection<EmployeeCharityFund> EmployeeCharityFunds { get; set; }

        /// <summary>
        /// EmployeeFoodSubsidy
        /// </summary>
        public virtual ICollection<EmployeeFoodSubsidy> EmployeeFoodSubsidies { get; set; }

        /// <summary>
        /// EmployeeServicePeriod
        /// </summary>
        public virtual ICollection<EmployeeServicePeriod> EmployeeServicePeriods { get; set; }

        /// <summary>
        /// EmployeeHardship
        /// </summary>
        public virtual ICollection<EmployeeHardship> EmployeeHardships { get; set; }

        /// <summary>
        /// MiscellAllowanceDeduction
        /// </summary>
        public virtual ICollection<MiscellAllowanceDeduction> MiscellAllowanceDeductions { get; set; }

        public virtual ICollection<UtilitySalaryHistory> UtilitySalaryHistories { get; set; }

        public virtual ICollection<UtilitySalary> UtilitySalaries { get; set; }

        public virtual ICollection<EmployeeUtilitySalary> EmployeeUtilitySalaries { get; set; }
        #endregion Collections

        #region Audit

        public string AddedBy { get; set; }

        public DateTime AddedDate { get; set; }

        public string AddedFromIP { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedFromIP { get; set; }

        #endregion Audit

        #region Extra

        /// <summary>
        /// Employee full name.
        /// </summary>
        public string FullName
        {
            get
            {
                return Title + " " + FirstName + " " + MiddleName + " " + LastName + " " + NickName;
            }
        }

        /// <summary>
        /// Employee title + first name + last name combine.
        /// </summary>
        public string TitleFullName
        {
            get
            {
                return Title + " " + FirstName + " " + LastName;
            }
        }

        #endregion Extra
    }
}
