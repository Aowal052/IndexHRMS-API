using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Application.CommandQuery.Accounts.Command.CreateAccounts;
using IndexHRMS.Entity.Dtos;
using IndexHRMS.Entity.Entities;

namespace IndexHRMS.Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserAccountCommand>().ReverseMap();
			CreateMap<byte[], string>().ReverseMap();
        }
    }
}
