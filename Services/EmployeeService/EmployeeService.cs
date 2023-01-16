using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.DTOs;
using ASP.NETCore7.Models;
using AutoMapper;

namespace ASP.NETCore7.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {

        private static List<Employee> employees = new List<Employee>
        {
            new Employee(),
            new Employee {Id= 1, FirstName="Ridmi", LastName="Pavinthika"}
        };

        private readonly IMapper _mapper;
        public EmployeeService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetEmployeeDTO>>> CreateEmployee(CreateEmployeeDTO newEmployee)
        {
            var ServiceResponse = new ServiceResponse<List<GetEmployeeDTO>>();
            employees.Add(_mapper.Map<Employee>(newEmployee));
            ServiceResponse.Data = employees.Select(c => _mapper.Map<GetEmployeeDTO>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetEmployeeDTO>>> GetAllEmployees()
        {
            var ServiceResponse = new ServiceResponse<List<GetEmployeeDTO>>();
            ServiceResponse.Data = employees.Select(c => _mapper.Map<GetEmployeeDTO>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<GetEmployeeDTO>> GetEmployeeById(int id)
        {
            var ServiceResponse = new ServiceResponse<GetEmployeeDTO>();
            var emp = employees.FirstOrDefault(c => c.Id == id);
            ServiceResponse.Data = _mapper.Map<GetEmployeeDTO>(emp);
            return ServiceResponse;

        }
    }
}