using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Application.Helper
{
	public static class StringHelper
	{
		public static int SuccessStatusCode { get; set; } = 200;
		public static string LogedInSuccessMessage { get; set; } = "You Have Successfully Logged In";
		public static string ApprovedTODListMessage { get; set; } = "Approved Travel On Duty List";
		public static string InsertTODInfoMessage { get; set; } = "Data saved successfully";
	}
}
