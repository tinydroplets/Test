
using System.Collections;
using System.Collections.Generic;

namespace EntityTest2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public ICollection<Enrollment> Enrollments {get; set; }
    }
}