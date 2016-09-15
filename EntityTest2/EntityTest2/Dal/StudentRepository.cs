using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EntityTest2.Interfaces;
using EntityTest2.Models;

namespace EntityTest2.Dal
{
    public class StudentRepository : IStudentRepository 
    {
        private readonly SchoolContext _context;

        public StudentRepository(SchoolContext context)
        {
            this._context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
        }

        public void DeleteStudent(int studentId)
        {
            Student student = _context.Students.Find(studentId);
            _context.Students.Remove(student);
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}