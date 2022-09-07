using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class Branch : BaseEntity
    {
        #region Scalar

        /// <summary>
        /// Primary key.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Code name.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Get or set the Branch Name.
        /// </summary>
        public string Name { get; set; }

        #region Address Properties

        /// <summary>
        /// First address line.
        /// </summary>
        public string Address_Address1 { get; set; }

        /// <summary>
        /// Second address line.
        /// </summary>
        public string Address_Address2 { get; set; }

        /// <summary>
        /// Country name.
        /// </summary>
        public string Address_Country { get; set; }

        /// <summary>
        /// Division name.
        /// </summary>
        public string Address_Division { get; set; }

        /// <summary>
        /// District name.
        /// </summary>
        public string Address_District { get; set; }

        /// <summary>
        /// PostalCode number.
        /// </summary>
        public string Address_PostalCode { get; set; }

        /// <summary>
        /// Record active status.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Record delete status.
        /// Default is false.
        /// </summary>
        public bool Archive { get; set; }

        #endregion Address Properties

        #region Contact Properties

        /// <summary>
        /// Phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Mobile number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Fax number,
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Web site address.
        /// </summary>
        public string Website { get; set; }

        public string Email { get; set; }
        public string ContactPersonMobile { get; set; }
        public string ContactPersonName { get; set; }
        public string EntityType { get; set; }
        public bool IsHoldingCompany { get; set; }
        public string VATCircleCode { get; set; }
        public DateTime? VATRegistrationDate { get; set; }
        public string VATRegistrationNo { get; set; }
        public bool HasUnit { get; set; }
        public string CompanyGroupId { get; set; }

        #endregion Contact Properties

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

        public virtual Company Company { get; set; }

        /// <summary>
        /// References with Company.
        /// </summary>
        public string CompanyId { get; set; }

        #endregion Navigation
    }
}
