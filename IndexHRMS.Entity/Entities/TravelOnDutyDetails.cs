using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Entity.Entities
{
	public class TravelOnDutyInfo:BaseEntity
	{
		public string TravelOnDutyId { get; set; }
		public string FileUrl { get; set; }
		public string Comment { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string Address { get; set; }
		public bool Active { get; set; }
		public bool Archive { get; set; }
	}
}
