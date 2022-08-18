using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTracking.Application.CommandQuery.Accounts.Command.CreateAccounts;
using VehicleTracking.Entity.Dtos;
using VehicleTracking.Entity.Entities;

namespace VehicleTracking.Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserAccountCommand>().ReverseMap();
            //CreateMap<UserRole, VehicleGeoLocationCommand>().ReverseMap();
            CreateMap<UserRole, VehicleGeoLocationDto>().ReverseMap();
        }
    }
}
