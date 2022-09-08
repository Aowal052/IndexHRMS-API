using IndexHRMS.Entity.Dtos;
using IndexHRMS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.ResponseModel
{
	public class LoginResponseModel
	{
		public int StatusCode { get; set; }
		public string Message { get; set; }
		public string Token { get; set; }
		public UserDto UserInfo { get; set; }
	}
}
