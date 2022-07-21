using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Models
{
    public class Department
    {
        public int Id { get; set; }
     
        public String Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
