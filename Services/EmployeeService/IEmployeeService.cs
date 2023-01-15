using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.Models;

namespace ASP.NETCore7.Services.EmployeeService
{
    public interface IEmployeeService
    {
        public List<Employee> GetAllEmployees();
        public Employee GetEmployeeById(int id);
        public List<Employee> CreateEmployee(Employee newEmployee);
    }
}