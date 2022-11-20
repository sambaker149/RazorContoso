using RazorContoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

            var collins = new Student
            {
                FirstMidName = "Joe",
                LastName = "Collins",
                EnrollmentDate = DateTime.Parse("2020-02-10")
            };

            var wickham = new Student
            {
                FirstMidName = "Katy",
                LastName = "Wickham",
                EnrollmentDate = DateTime.Parse("2020-02-10")
            };

            var hardy = new Student
            {
                FirstMidName = "James",
                LastName = "Hardy",
                EnrollmentDate = DateTime.Parse("2020-09-29")
            };

            var percy = new Student
            {
                FirstMidName = "Luca",
                LastName = "Percy",
                EnrollmentDate = DateTime.Parse("2020-09-29")
            };

            var stevenson = new Student
            {
                FirstMidName = "Natalie",
                LastName = "Stevenson",
                EnrollmentDate = DateTime.Parse("2021-02-08")
            };

            var higgins = new Student
            {
                FirstMidName = "Alexandra",
                LastName = "Higgins",
                EnrollmentDate = DateTime.Parse("2021-02-08")
            };

            var davies = new Student
            {
                FirstMidName = "Richard",
                LastName = "Davies",
                EnrollmentDate = DateTime.Parse("2021-09-27")
            };

            var ashcroft = new Student
            {
                FirstMidName = "Jessica",
                LastName = "Ashcroft",
                EnrollmentDate = DateTime.Parse("2021-09-27")
            };

            var roberts = new Instructor
            {
                FirstMidName = "Joseph",
                LastName = "Roberts",
                HireDate = DateTime.Parse("2005-08-31")
            };

            var millett = new Instructor
            {
                FirstMidName = "Lauren",
                LastName = "Millett",
                HireDate = DateTime.Parse("2000-04-01")
            };

            var howard = new Instructor
            {
                FirstMidName = "Michael",
                LastName = "Howard",
                HireDate = DateTime.Parse("1995-07-21")
            };

            var edwards = new Instructor
            {
                FirstMidName = "Emily",
                LastName = "Edwards",
                HireDate = DateTime.Parse("2010-05-05")
            };

            var matheson = new Instructor
            {
                FirstMidName = "Roger",
                LastName = "Matheson",
                HireDate = DateTime.Parse("2004-12-12")
            };

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment
                {
                    Instructor = millett,
                    Location = "N2.12"
                },
                new OfficeAssignment
                {
                    Instructor = edwards,
                    Location = "N2.20"
                }
            };

            context.AddRange(officeAssignments);

            var webdevelopment = new Department
            {
                Name = "Web Development",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = roberts
            };

            var computerscience = new Department
            {
                Name = "Computer Science",
                Budget = 100000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = edwards
            };

            var webapplications = new Module
            {
                ModuleID = 550,
                Title = "Web Applications",
                Credits = 15,
                Department = webdevelopment,
                Instructors = new List<Instructor> { millett }

            };
            var opensourcesystems = new Module
            {
                ModuleID = 551,
                Title = "Open Source Systems",
                Credits = 15,
                Department = computerscience,
                Instructors = new List<Instructor> { edwards }
            };

            var networksystems = new Module
            {
                ModuleID = 556,
                Title = "Network Systems",
                Credits = 15,
                Department = computerscience,
                Instructors = new List<Instructor> { millett }
            };

            var softwareengineering = new Module
            {
                ModuleID = 557,
                Title = "Software Engineering",
                Credits = 15,
                Department = computerscience,
                Instructors = new List<Instructor> { roberts }
            };

            var databasedesign = new Module
            {
                ModuleID = 558,
                Title = "Database Design",
                Credits = 15,
                Department = webdevelopment,
                Instructors = new List<Instructor> { howard }
            };

            var webservices = new Module
            {
                ModuleID = 565,
                Title = "Web Services",
                Credits = 15,
                Department = webdevelopment,
                Instructors = new List<Instructor> { edwards }
            };

            var mobilesystems = new Module
            {
                ModuleID = 566,
                Title = "Mobile Systems",
                Credits = 15,
                Department = webdevelopment,
                Instructors = new List<Instructor> { millett }
            };

            var oosystemsdev = new Module
            {
                ModuleID = 567,
                Title = "OO Systems Development",
                Credits = 15,
                Department = webdevelopment,
                Instructors = new List<Instructor> { matheson }
            };

            var enrollments = new Enrollment[]
            {
                new Enrollment
                {
                    Student = collins,
                    Module = webapplications,
                    Grade = Grade.A
                },
                new Enrollment
                {
                    Student = collins,
                    Module = webservices,
                    Grade = Grade.C
                },
                new Enrollment
                {
                    Student = collins,
                    Module = mobilesystems,
                    Grade = Grade.B
                },
                new Enrollment
                {
                    Student = wickham,
                    Module = opensourcesystems,
                    Grade = Grade.B
                },
                new Enrollment
                {
                    Student = wickham,
                    Module = networksystems,
                    Grade = Grade.F
                },
                new Enrollment
                {
                    Student = wickham,
                    Module = webservices,
                    Grade = Grade.F
                },
                new Enrollment
                {
                    Student = hardy,
                    Module = databasedesign
                },
                new Enrollment
                {
                    Student = percy,
                    Module = webapplications
                },
                new Enrollment
                {
                    Student = percy,
                    Module = databasedesign,
                    Grade = Grade.F
                },
                new Enrollment
                {
                    Student = stevenson,
                    Module = networksystems,
                    Grade = Grade.C
                },
                new Enrollment
                {
                    Student = higgins,
                    Module = mobilesystems
                },
                new Enrollment
                {
                    Student = davies,
                    Module = databasedesign,
                    Grade = Grade.A
                },
                new Enrollment
                {
                    Student = ashcroft,
                    Module = webapplications,
                    Grade = Grade.B
                }
            };

            context.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}