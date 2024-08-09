using System.ComponentModel.DataAnnotations;

namespace EmployeeRegistration.Models.AppEntities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required,MaxLength(200)]
        public string Emp_Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        [Required]
        [AllowedValues("Male","Female","Third Gender", ErrorMessage ="Invalid Gender")]
        public string Gender { get; set; }
        public decimal? Salary { get; set; }
        public int Entry_By { get; set; }
        public DateTime Entry_Date { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualifications { get; set; }
    }
}
