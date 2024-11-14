using System.ComponentModel.DataAnnotations;

namespace ImportExport.DataAccess.DTO
{
    public class EmployeeReadDTO
    {
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please give the department")]
        public string Departement { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please give the date of birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please give age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please give the phone number")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
