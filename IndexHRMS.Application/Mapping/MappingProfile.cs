using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Application.CommandQuery.Accounts.Command.CreateAccounts;
using IndexHRMS.Entity.Dtos;
using IndexHRMS.Entity.Entities;
using IndexHRMS.Application.CommandQuery.TravelOnDuty.Command.InsertTravelOnDutyInfo;

namespace IndexHRMS.Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserAccountCommand>().ReverseMap();
			CreateMap<byte[], string>().ReverseMap();
            CreateMap<TravelOnDuty, TravelOnDutyDto>().ReverseMap();
            CreateMap<TravelOnDutyInfo, TravelOnDutyInfoCommand>().ReverseMap();
        }
    }
}
