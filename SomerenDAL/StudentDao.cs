using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT studentNumber, roomNumber, firstName, lastName, telephone, class FROM [student]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentNumber = (int)dr["studentNumber"],
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    RoomNumber = (int)dr["roomNumber"],
                    Telephone = (int)dr["telephone"],
                    Class = dr["class"].ToString()
                };
                students.Add(student);
            }
            return students;
        }

        public void AddStudent(Student student)
        {
            string query = @"
            INSERT INTO Student(studentNumber, roomNumber, firstName, lastName, telephone, class)
            VALUES(@studentNr, @roomNumber, @firstName, @lastName, @telephone, @class);
            ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentNr", SqlDbType.Int) {Value = student.StudentNumber},
                new SqlParameter("@roomNumber", SqlDbType.Int) {Value = student.RoomNumber},
                new SqlParameter("@firstName", SqlDbType.VarChar, 15) {Value = student.FirstName},
                new SqlParameter("@lastName", SqlDbType.VarChar, 15) {Value = student.LastName},
                new SqlParameter("@telephone", SqlDbType.Int) {Value = student.Telephone},
                new SqlParameter("@class", SqlDbType.VarChar, 15) {Value = student.Class}
            };
            ExecuteEditQuery(query, parameters);
        }
        public void RemoveStudent(Student student)
        {
            string query = @"DELETE FROM student WHERE studentNumber = @studentNr";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentNr", SqlDbType.Int) {Value = student.StudentNumber}
            };
            ExecuteEditQuery(query, parameters);
        }
        public void EditStudent(Student student, int id)
        {
            string query = @"UPDATE student 
                            SET firstName = @firstName, lastName = @lastName, telephone = @telephone, class = @class, roomNumber = @roomNumber 
                            where studentNumber = @Id;";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentNr", SqlDbType.Int) {Value = student.StudentNumber},
                new SqlParameter("@Id", SqlDbType.Int) {Value = id},
                new SqlParameter("@roomNumber", SqlDbType.Int) {Value = student.RoomNumber},
                new SqlParameter("@firstName", SqlDbType.VarChar, 15) {Value = student.FirstName},
                new SqlParameter("@lastName", SqlDbType.VarChar, 15) {Value = student.LastName},
                new SqlParameter("@telephone", SqlDbType.Int) {Value = student.Telephone},
                new SqlParameter("@class", SqlDbType.VarChar, 15) {Value = student.Class}
            };
            ExecuteEditQuery(query, parameters);
        }
    }
}