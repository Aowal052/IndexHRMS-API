using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Entity.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }
		public byte[] Password { get; set; }
		public DateTime? LastPwdChangedDay { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte? Image { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? PasswordFailCount { get; set; }
        public bool? UserLocked { get; set; }
        public DateTime? UserLockedDate { get; set; }
        public DateTime? UserUnlockDate { get; set; }
        public string AuthToken { get; set; }
        public string Remarks { get; set; }
        public bool PwdChangeOnFirstLogin { get; set; }
        public bool PasswordNeverExpired { get; set; }
        public bool SysAdmin { get; set; }
        public bool IsPowerUser { get; set; }
        public bool IsManagement { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsEss { get; set; }
        public bool Active { get; set; }
        public bool Archive { get; set; }
        public string UserGroupId { get; set; }
        public string SupervisorId { get; set; }
        public string EmployeeId { get; set; }
    }
}
