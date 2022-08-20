using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Entity.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public DateTime LastPwdChangedDay { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte? Image { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? PasswordFailCount { get; set; }
        public bool? UserLocked { get; set; }
        public DateTime UserLockedDate { get; set; }
        public DateTime UserUnlockDate { get; set; }
        [Column, NotNull]
        public string AuthToken { get; set; }
        [Column, NotNull]
        public string Remarks { get; set; }
        [Column, NotNull]
        public bool PwdChangeOnFirstLogin { get; set; }
        [Column, NotNull]
        public bool PasswordNeverExpired { get; set; }
        [Column, NotNull]
        public bool SysAdmin { get; set; }
        [Column, NotNull]
        public bool IsPowerUser { get; set; }
        [Column, NotNull]
        public bool IsManagement { get; set; }
        [Column, NotNull]
        public bool IsAdmin { get; set; }
        [Column, NotNull]
        public bool IsEss { get; set; }
        [Column, NotNull]
        public bool Active { get; set; }
        [Column, NotNull]
        public bool Archive { get; set; }
        [Column, NotNull]
        public string UserGroupId { get; set; }
        [Column, NotNull]
        public string SupervisorId { get; set; }
        [Column, NotNull]
        public string EmployeeId { get; set; }
	}
}
