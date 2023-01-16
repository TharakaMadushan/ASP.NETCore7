using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.DTOs;
using ASP.NETCore7.Models;

namespace ASP.NETCore7.Services.EmployeeService
{
    public interface IEmployeeService
    {
        public Task<ServiceResponse<List<GetEmployeeDTO>>> GetAllEmployees();
        public Task<ServiceResponse<GetEmployeeDTO>> GetEmployeeById(int id);
        public Task<ServiceResponse<List<GetEmployeeDTO>>> CreateEmployee(CreateEmployeeDTO newEmployee);
        public Task<ServiceResponse<GetEmployeeDTO>> UpdateEmployee(UpdateEmployeeDTO updateEmployee);

    }
}