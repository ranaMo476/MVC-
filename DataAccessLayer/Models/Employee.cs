using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50, ErrorMessage="Max Length is 50 Characters")]
        [MinLength (5, ErrorMessage="Min Length is 5 Characters")]
        public string Name { get; set; }

        [Range(22,35 , ErrorMessage="Age must be In Range From 22 To 35")]
        public int?  Age { get; set; }

        [RegularExpression("^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$", ErrorMessage=" Address must Be Like 123-Streete-City-Country")]

        public string Address  { get; set; } //nvarchar -allaow null

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
        [ForeignKey("Department")]
        public int? DepartmentId  { get; set; }

        [InverseProperty("Employees")]
        public Department Department { get; set; }
    }
}
