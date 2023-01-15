using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.Models;

namespace ASP.NETCore7.Services.EmployeeService
{
    public interface IEmployeeService
    {
        public Task<ServiceResponse<List<Employee>>> GetAllEmployees();
        public Task<ServiceResponse<Employee>> GetEmployeeById(int id);
        public Task<ServiceResponse<List<Employee>>> CreateEmployee(Employee newEmployee);
    }
}