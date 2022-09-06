using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Domain.Dtos
{
    public class RequestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<IFormFile> Attachments { get; set; }
    }
}
