using RazorContoso.Models;

namespace RazorContoso.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Joe",LastName="Collins",EnrollmentDate=DateTime.Parse("2020-02-10")},
                new Student{FirstMidName="Katy",LastName="Wickham",EnrollmentDate=DateTime.Parse("2020-02-10")},
                new Student{FirstMidName="James",LastName="Hardy",EnrollmentDate=DateTime.Parse("2020-09-28")},
                new Student{FirstMidName="Luca",LastName="Percy",EnrollmentDate=DateTime.Parse("2020-09-28")},
                new Student{FirstMidName="Natalie",LastName="Stevenson",EnrollmentDate=DateTime.Parse("2021-02-08")},
                new Student{FirstMidName="Alexandra",LastName="Higgins",EnrollmentDate=DateTime.Parse("2021-02-08")},
                new Student{FirstMidName="Richard",LastName="Davies",EnrollmentDate=DateTime.Parse("2021-09-27")},
                new Student{FirstMidName="Jessica",LastName="Ashcroft",EnrollmentDate=DateTime.Parse("2021-09-27")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var modules = new Module[]
            {
                new Module{ModuleID=550,Title="Web Applications",Credits=15},
                new Module{ModuleID=551,Title="Open Source Systems",Credits=15},
                new Module{ModuleID=556,Title="Network Systems",Credits=15},
                new Module{ModuleID=557,Title="Software Engineering",Credits=15},
                new Module{ModuleID=558,Title="Database Design",Credits=15},
                new Module{ModuleID=565,Title="Web Services",Credits=15},
                new Module{ModuleID=566,Title="Mobile Systems",Credits=15},
                new Module{ModuleID=567,Title="OO Systems Development",Credits=15}
            };

            context.Modules.AddRange(modules);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,ModuleID=550,Grade=Grade.A},
                new Enrollment{StudentID=1,ModuleID=565,Grade=Grade.C},
                new Enrollment{StudentID=1,ModuleID=566,Grade=Grade.B},
                new Enrollment{StudentID=2,ModuleID=551,Grade=Grade.B},
                new Enrollment{StudentID=2,ModuleID=556,Grade=Grade.F},
                new Enrollment{StudentID=2,ModuleID=565,Grade=Grade.F},
                new Enrollment{StudentID=3,ModuleID=558},
                new Enrollment{StudentID=4,ModuleID=550},
                new Enrollment{StudentID=4,ModuleID=558,Grade=Grade.F},
                new Enrollment{StudentID=5,ModuleID=556,Grade=Grade.C},
                new Enrollment{StudentID=6,ModuleID=566},
                new Enrollment{StudentID=7,ModuleID=558,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}