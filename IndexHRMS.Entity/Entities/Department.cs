using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Entities
{
    public class Department : BaseEntity
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
        /// Department template name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Department template description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Record active status.
        /// </summary>
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
    }
}
