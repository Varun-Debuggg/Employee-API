using System.ComponentModel.DataAnnotations;

namespace Employee_1031API.Model
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
