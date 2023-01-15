using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.Models;
using ASP.NETCore7.Services.EmployeeService;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAllEmployees")]
        public ActionResult<List<Employee>> GetAllEmployees()
        {
            return (_employeeService.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return Ok(_employeeService.GetEmployeeById(id));
        }

        [HttpPost]
        public ActionResult<List<Employee>> CreateEmployee(Employee newEmployee)
        {
            return Ok(_employeeService.CreateEmployee(newEmployee));
        }
    }
}