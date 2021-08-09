using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalSPA.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [DisplayName("Student Number")]
        public string StudentNumber { get; set; }
        public string Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
