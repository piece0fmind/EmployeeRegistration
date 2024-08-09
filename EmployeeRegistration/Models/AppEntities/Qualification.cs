using System.ComponentModel.DataAnnotations;

namespace EmployeeRegistration.Models.AppEntities
{
    public class Qualification
    {
        [Key]
        public int Q_Id { get; set; }
        [Required,MaxLength(100)]
        public string Q_Name { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualifications { get; set; }

    }
}
