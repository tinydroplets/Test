using System;
using System.Linq;
using EntityTest2.Controllers.Api;
using EntityTest2.Dal;
using EntityTest2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class StudentControllerTests
    {
        private StudentController _studentController;
        private UnitOfWork _unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
           _studentController = new StudentController(); 
            _unitOfWork = new UnitOfWork();
        }

        [TestMethod]
        public void TestGetStudents()
        {
            var actual = _studentController.GetStudents();
            if(actual.Count == 0)
                Assert.Fail();
        }

        [TestMethod]
        public void TestInsertStudent()
        {
            var student = new Student() {FirstName = "Jonny", LastName = "Carson", MiddleName = "Simson"};
           _studentController.InsertStudent(student); 
        }

        [TestMethod]
        public void UpdateStudent()
        {
            var student = _studentController.GetById(4);
            student.MiddleName = "Bluebird";
            _studentController.UpdateStudent(student);
        }

        [TestMethod]
        public void TestGetUow()
        {
            var students = _unitOfWork.StudentRepository.Get(includeProperties: "Enrollments");
            if (!students.Select(x=>x.Enrollments).Any())
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGetUowWithoutInclude()
        {
            var students = _unitOfWork.StudentRepository.Get();
            if (students.Select(x => x.Enrollments).Any())
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestInsertUow()
        {
            var student = new Student() {FirstName = "Joshua", LastName = "Abraham", MiddleName = "Simson"};
            _unitOfWork.StudentRepository.Insert(student);
            _unitOfWork.Save();
        }

        [TestMethod]
        public void TestCourseGet()
        {
            var courses = _unitOfWork.CourseRepository.Get();
            if(!courses.Any())
                Assert.Fail();
        }

        [TestMethod]
        public void OnlyToTestGit()
        {

        }

    }
}
