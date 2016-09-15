using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using EntityTest2.Dal;
using EntityTest2.Interfaces;
using EntityTest2.Models;

namespace EntityTest2.Controllers.Api
{
    public class StudentController : ApiController
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController()
        {
            _studentRepository = new StudentRepository(new SchoolContext());
        }

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetStudents()
        {
            return _studentRepository.GetStudents().ToList();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public void InsertStudent(Student student)
        {
            _studentRepository.InsertStudent(student);
            _studentRepository.Save();
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
            _studentRepository.Save();
        }
    }
}

