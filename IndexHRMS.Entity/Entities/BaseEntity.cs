using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Entity.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public string AddedFromIP { get; set; }

        public string UpdatedFromIP { get; set; }
    }
}
