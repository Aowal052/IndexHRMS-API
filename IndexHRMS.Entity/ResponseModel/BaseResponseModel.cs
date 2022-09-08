using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.ResponseModel
{
	public class BaseResponseModel
	{
		public int StatusCode { get; set; }
		public string Message { get; set; }
		public Object Data { get; set; }
	}
}
