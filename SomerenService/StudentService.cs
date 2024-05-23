using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAllStudents();
            return students;
        }
        private readonly StudentDao studentDao = new StudentDao();

        public void AddStudents(Student student)
        {
            studentdb.AddStudent(student);
        }
        public void RemoveStudents(Student student)
        {
            studentdb.RemoveStudent(student);
        }
        public void EditStudents(Student student, int id)
        {
            studentdb.EditStudent(student, id);
        }
        
    }
}