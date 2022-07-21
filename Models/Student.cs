using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        
        public string Name { get; set; }

     
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string EnrollmentDate { get; set; }

        public double Phone { get; set; }

        public string country { get; set; }
     
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
