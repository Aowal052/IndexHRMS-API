using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class CompanyGroup : BaseEntity
    {
        #region Constractor
        public CompanyGroup()
        {
            Companies = new HashSet<Company>();
        }
        #endregion

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
        /// Group name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Company VAT number.
        /// </summary>
        public string VAT { get; set; }

        /// <summary>
        /// Group Contact person.
        /// </summary>
        public string ContactPersonName { get; set; }

        /// <summary>
        /// Group Contact person designation.
        /// </summary>
        public string ContactPersonDesignation { get; set; }

        /// <summary>
        /// Company Group currency.
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        public DateTime? PayScheduleStartDate { get; set; }

        public DateTime? LeavePeriodStartDate { get; set; }
        /// <summary>
        /// Record active status.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Record delete status.
        /// Default is false.
        /// </summary>
        public bool Archive { get; set; }
        #endregion

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
        #endregion

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
        /// Fax number
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Web site address.
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// Email address.
        /// </summary>
        public string Email { get; set; }
        #endregion

        #region Audit
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedFromIP { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedFromIP { get; set; }
        #endregion

        #region Navigation
        /// <summary>
        /// Company Collection
        /// </summary>
        public virtual ICollection<Company> Companies { get; set; }
        #endregion
    }
}
