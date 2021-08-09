using StudentPortalSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalSPA.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{Name="Furkan",Surname="Çalık",StudentNumber="201901020304",Department="Computer Enginerring"},
            new Student{Name="Ata",Surname="Coşkun",StudentNumber="201804030201",Department="Electronic Enginerring"},
            new Student{Name="Umer",Surname="Shamaan",StudentNumber="201909080706",Department="Software Enginerring"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1000,LessonName="Linear Algebra"},
            new Course{CourseID=1001,LessonName="Introduction to Software Engineering"},
            new Course{CourseID=1002,LessonName="Differential Equations"},
            new Course{CourseID=1003,LessonName="Electronic Circuit Design"},
            new Course{CourseID=1004,LessonName="Embedded Systems"},
            new Course{CourseID=1005,LessonName="Web Programming"},
            new Course{CourseID=1006,LessonName="Artificial Neural Networks"},
            new Course{CourseID=1007,LessonName="Object Oriented Programming"}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1000,FirstExam="65",FinalExam="70",Average="68.5",LetterGrade="BC"},
            new Enrollment{StudentID=1,CourseID=1001,FirstExam="80",FinalExam="82",Average="81.4",LetterGrade="BC"},
            new Enrollment{StudentID=1,CourseID=1002,FirstExam="55",FinalExam="69",Average="64.8",LetterGrade="CC"},
            new Enrollment{StudentID=2,CourseID=1000,FirstExam="65",FinalExam="70",Average="68.5",LetterGrade="BC"},
            new Enrollment{StudentID=2,CourseID=1003,FirstExam="80",FinalExam="82",Average="81.4",LetterGrade="BC"},
            new Enrollment{StudentID=2,CourseID=1004,FirstExam="55",FinalExam="69",Average="64.8",LetterGrade="CC"},
             new Enrollment{StudentID=3,CourseID=1005,FirstExam="65",FinalExam="70",Average="68.5",LetterGrade="BC"},
            new Enrollment{StudentID=3,CourseID=1006,FirstExam="80",FinalExam="82",Average="81.4",LetterGrade="BC"},
            new Enrollment{StudentID=3,CourseID=1007,FirstExam="55",FinalExam="69",Average="64.8",LetterGrade="CC"},

            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
