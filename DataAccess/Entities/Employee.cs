using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ImportExport.DataAccess.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Departement { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
