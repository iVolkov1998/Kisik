﻿using Albina.BusinessLogic.Core.Models;
using AutoMapper;
using Kisik.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace Albina.BusinessLogic.AutpMapperProfiles
{
     public class BusinessLogicProfile : Profile
    {
        public BusinessLogicProfile()
        {
            CreateMap<userRto, UserInformationBlo>()
                .ForMember(x => x.Name, x => x.MapFrom(m => m.Name))
                .ForMember(x => x.Surname, x => x.MapFrom(m => m.Surname))
                .ForMember(x => x.PhoneNumberPrefix, x => x.MapFrom(m => m.PhoneNumberPrefix))
                .ForMember(x => x.PhoneNumber, x => x.MapFrom(m => m.PhoneNumber))
                .ForMember(x => x.ImageUrl, x => x.MapFrom(m => m.ImageUrl));

            CreateMap<userRto, UserIdentityBlo>()
                  .ForMember(x => x.Id, x => x.MapFrom(m => m.Id))
                  .ForMember(x => x.NumberPrefix, x => x.MapFrom(m => m.PhoneNumberPrefix))
                  .ForMember(x => x.Number, x => x.MapFrom(m => m.PhoneNumber))
                  .ForMember(x => x.Password, x => x.MapFrom(m => m.Password))
                  .ForMember(x => x.ConfirmPassword,m => m.Ignore());

            CreateMap<userRto, UserUpdateBlo>()
                .ForMember(x => x.Name, x => x.MapFrom(m => m.Name))
                .ForMember(x => x.FirstName, x => x.MapFrom(m => m.Surname))
                .ForMember(x => x.Password, x => x.MapFrom(m => m.Password))
                .ForMember(x => x.ImageUrl, x => x.MapFrom(m => m.ImageUrl));
        }
    }
}
