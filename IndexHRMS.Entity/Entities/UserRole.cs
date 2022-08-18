using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTracking.Entity.Entities
{
    public class UserRole : BaseEntity
    {

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
        /// Foreign key.
        /// </summary>
        public string BranchId { get; set; }

        public string UnitId { get; set; }

        /// <summary>
        /// Foreign key.
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// User
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Foreign key.
        /// </summary>
        public string UserId { get; set; }

        public string UserGroupId { get; set; }
    }
}
