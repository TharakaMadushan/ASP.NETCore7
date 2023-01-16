using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.DTOs;
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
        public async Task<ActionResult<ServiceResponse<List<GetEmployeeDTO>>>> GetAllEmployees()
        {
            return (await _employeeService.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetEmployeeDTO>>> Get(int id)
        {
            return Ok(await _employeeService.GetEmployeeById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetEmployeeDTO>>>> CreateEmployee(CreateEmployeeDTO newEmployee)
        {
            return Ok(await _employeeService.CreateEmployee(newEmployee));
        }
    }
}