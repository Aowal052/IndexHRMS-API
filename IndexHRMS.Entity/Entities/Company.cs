using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class Company : BaseEntity
    {
        #region Constractor

        public Company()
        {
            UserRoles = new HashSet<UserRole>();
            Branches = new HashSet<Branch>();
        }

        #endregion Constractor

        #region Scalar

        /// <summary>
        /// Primary key.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// CompanyGroupId FK
        /// </summary>
        public string CompanyGroupId { get; set; }

        public string BusinessTypeId { get; set; }
        public string CurrencyId { get; set; }

        /// <summary>
        /// Code name.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Manufecturing/Trading/Service
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// Company VAT number.
        /// </summary>
        public string VATRegistrationNo { get; set; }

        public DateTime? VATRegistrationDate { get; set; }

        /// <summary>
        /// Company image name only save in database. Actual Image will be saved in local forder.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Record active status.
        /// </summary>
        public bool Active { get; set; }

        #endregion Scalar

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
        public string AreaCode { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonMobile { get; set; }
        public byte[] Logo { get; set; }

        #endregion Contact Properties

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
        /// CompanyGroup
        /// </summary>
        public virtual CompanyGroup CompanyGroup { get; set; }

        /// <summary>
        /// Branch Collection
        /// </summary>
        public virtual ICollection<Branch> Branches { get; set; }

        /// <summary>
        /// UserRoles
        /// </summary>
        public virtual ICollection<UserRole> UserRoles { get; set; }

        #endregion Navigation

        #region Public Method

        /// <summary>
        /// Email address validation.
        /// </summary>
        /// <param name="emailaddress">string</param>
        /// <returns>Boolean</returns>
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion Public Method
    }
}
