using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesApplication.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public string JobDescription { get; set; }

        //public byte[] Photo { get; set; }
    }
}
