using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.DTOs;
using ASP.NETCore7.Models;
using AutoMapper;

namespace ASP.NETCore7
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee,GetEmployeeDTO>();
            CreateMap<CreateEmployeeDTO, Employee>();
        }
    }
}