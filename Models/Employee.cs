using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCore7.Models
{
    public class Employee
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string? FirstName {get;set;} = "Tharaka";
        [Required]
        public string? LastName {get; set;} = "Madushan";
        [Required]
        [Phone]
        [MaxLength(10)]
        public string? ContactNo {get; set;} = "0776330567";
        [Required]
        public int Age {get; set;} = 27;
        [Required]
        public decimal BasicSalary {get; set;} = 100000;
        public Enum IsActive {get; set;} = Enums.Active;
        
    }
}