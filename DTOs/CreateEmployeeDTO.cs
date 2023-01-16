using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCore7.Models;

namespace ASP.NETCore7.DTOs
{
    public class CreateEmployeeDTO
    {
        public string? FirstName { get; set; } = "Tharaka";
        public string? LastName { get; set; } = "Madushan";
        public string? ContactNo { get; set; } = "0776330567";
        public int Age { get; set; } = 27;
        public decimal BasicSalary { get; set; } = 100000;
        public Enum IsActive { get; set; } = Enums.Active;
    }
}