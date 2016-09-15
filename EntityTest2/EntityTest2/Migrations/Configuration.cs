using System.Collections.Generic;
using EntityTest2.Models;

namespace EntityTest2.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityTest2.Dal.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntityTest2.Dal.SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstName = "Carson",   LastName = "Alexander", MiddleName = "Jonny"},
                new Student { FirstName = "Meredith", LastName = "Alonso", MiddleName = "Skinny"},
                new Student { FirstName = "Arturo",   LastName = "Anand", MiddleName = "Bridges"},
                new Student { FirstName = "Gytis",    LastName = "Barzdukas"},
                new Student { FirstName = "Yan",      LastName = "Li"},
                new Student { FirstName = "Peggy",    LastName = "Justice"},
                new Student { FirstName = "Laura",    LastName = "Norman"},
                new Student { FirstName = "Nino",     LastName = "Olivetto", MiddleName = "Taher"},
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseId=1050,Title="Chemistry",Credits=3,},
            new Course{CourseId=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseId=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseId=1045,Title="Calculus",Credits=4,},
            new Course{CourseId=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseId=2021,Title="Composition",Credits=3,},
            new Course{CourseId=2042,Title="Literature",Credits=4,}
            };
            //courses.ForEach(s => context.Courses.Add(s));
            courses.ForEach(c=> context.Courses.AddOrUpdate(p=>p.CourseId));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentId=1,CourseId=1050,Grade=Grade.A},
            new Enrollment{StudentId=1,CourseId=4022,Grade=Grade.C},
            new Enrollment{StudentId=1,CourseId=4041,Grade=Grade.B},
            new Enrollment{StudentId=2,CourseId=1045,Grade=Grade.B},
            new Enrollment{StudentId=2,CourseId=3141,Grade=Grade.F},
            new Enrollment{StudentId=2,CourseId=2021,Grade=Grade.F},
            new Enrollment{StudentId=3,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=4022,Grade=Grade.F},
            new Enrollment{StudentId=5,CourseId=4041,Grade=Grade.C},
            new Enrollment{StudentId=6,CourseId=1045},
            new Enrollment{StudentId=7,CourseId=3141,Grade=Grade.A},
            };
            //enrollments.ForEach(s => context.Enrollments.Add(s));
            enrollments.ForEach(s=> context.Enrollments.AddOrUpdate(p=>p.EnrollmentId));
            context.SaveChanges();
        }
    }
}
