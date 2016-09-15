using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityTest2.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Grade? Grade {get; set; }
        public Student Student { get; set; }
        public Course  Course { get; set; }
    }
}