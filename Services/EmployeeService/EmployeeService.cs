using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.Models;

namespace ASP.NETCore7.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {

        private static List<Employee> employees = new List<Employee>
        {
            new Employee(),
            new Employee {Id= 1, FirstName="Ridmi", LastName="Pavinthika"}
        };

        public async Task<ServiceResponse<List<Employee>>> CreateEmployee(Employee newEmployee)
        {
            var ServiceResponse = new ServiceResponse<List<Employee>>();
            employees.Add(newEmployee);
            ServiceResponse.Data = employees;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Employee>>> GetAllEmployees()
        {
            var ServiceResponse = new ServiceResponse<List<Employee>>();
            ServiceResponse.Data = employees;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<Employee>> GetEmployeeById(int id)
        {
            var ServiceResponse = new ServiceResponse<Employee>();
            var emp = employees.FirstOrDefault(c => c.Id == id);
            ServiceResponse.Data=emp;
            return ServiceResponse;
           
        }
    }
}