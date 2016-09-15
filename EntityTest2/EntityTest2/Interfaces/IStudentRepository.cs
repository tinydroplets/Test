using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTest2.Models;

namespace EntityTest2.Interfaces
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int studentId);
        void InsertStudent(Student student);
        void DeleteStudent(int studentId);
        void UpdateStudent(Student student);
        void Save();
    }
}
