using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalSPA.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public string FirstExam { get; set; }
        public string FinalExam { get; set; }
        public string Average { get; set; }
        public string LetterGrade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
