using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeRegistration.Models.AppEntities
{
    public class EmployeeQualification
    {
        //[ForeignKey("Employee")]
        [Key]
        [Column(Order = 0)]
        public int Employee_Id { get; set; }

        //[ForeignKey("Qualification")]
        [Key]
        [Column(Order = 1)]
        public int Q_Id { get; set; }
        public float Marks { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
