using System.ComponentModel.DataAnnotations;


namespace InstructorCRUD.Models
{
    public class Instructor
    {


        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Instructor Name")]
        public string Name { get; set; }
        public string Designation { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public DateTime? RecordCreatedOn { get; set; }

        public int Salary { get; set; }
    }
}
