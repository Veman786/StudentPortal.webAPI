using AutoMapper;
using StudentAdminPortalWebAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels = StudentAdminPortalWebAPI.DataModels;

namespace StudentAdminPortalWebAPI.Profiles
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<DataModels.Student, Student>()
                .ReverseMap();
            CreateMap<DataModels.Gender, Gender>()
             .ReverseMap();
            CreateMap<DataModels.Address, Address>()
             .ReverseMap();
        }
    }
}
