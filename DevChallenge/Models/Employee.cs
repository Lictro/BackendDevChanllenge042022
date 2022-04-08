using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevChallenge.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Required]
        public int id { get; set; }
        [StringLength(50)]
        public string firstname { get; set; }
        [StringLength(50)]
        public string lastname { get; set; }
        [StringLength(50)]
        public string location { get; set; }
        public string dateOfHire { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string firstname, string lastname, string location, string dateOfHire)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.location = location;
            this.dateOfHire = dateOfHire;
        }
    }
}
