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

        public List<Employee> CreateEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
            return employees;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = employees.FirstOrDefault(c => c.Id == id);
            if(emp is not null)
                return emp;
            throw new Exception("Employee Not Found!");
           
        }
    }
}