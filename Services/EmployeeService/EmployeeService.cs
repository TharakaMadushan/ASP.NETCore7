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
            var createEmp = _mapper.Map<Employee>(newEmployee);
            createEmp.Id = employees.Max(c => c.Id) + 1;

            employees.Add(createEmp);
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

        public async Task<ServiceResponse<GetEmployeeDTO>> UpdateEmployee(UpdateEmployeeDTO updateEmployee)
        {
            var serviceResponse = new ServiceResponse<GetEmployeeDTO>();

            try
            {
               
                var emp = employees.FirstOrDefault(c => c.Id == updateEmployee.Id);
                if (emp is null)
                    throw new Exception($"Employee with Id '{updateEmployee.Id}' not Found!");

                emp.FirstName = updateEmployee.FirstName;
                emp.LastName = updateEmployee.LastName;
                emp.ContactNo = updateEmployee.ContactNo;
                emp.Age = updateEmployee.Age;
                emp.BasicSalary = updateEmployee.BasicSalary;
                emp.Class = updateEmployee.Class;

                serviceResponse.Data = _mapper.Map<GetEmployeeDTO>(emp);
               
            }
            catch (Exception ex)
            {              
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;

        }
    }
}