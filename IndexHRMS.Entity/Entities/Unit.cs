using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class Unit : BaseEntity
    {
        #region Scalar
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonMobile { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CountryId { get; set; }
        public string DivisionId { get; set; }
        public string DistrictId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
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
        public virtual CompanyGroup CompanyGroup { get; set; }
        public string CompanyGroupId { get; set; }
        public virtual Company Company { get; set; }
        public string CompanyId { get; set; }
        public virtual Branch Branch { get; set; }
        public string BranchId { get; set; }
        #endregion
    }
}
