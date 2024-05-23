using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class EditStudent : Form
    {
        private readonly StudentService studentService;
        private Student student;

        public EditStudent()
        {
            InitializeComponent();
            studentService = new StudentService();
            RefreshStudentNr();
        }

        void RefreshStudentNr()
        {
            studentNrComboBox.Items.Clear();
            studentNrComboBox.ResetText();

            List<Student> students = studentService.GetStudents();

            foreach (Student student in students)
            {
                studentNrComboBox.Items.Add(student);
            }
            studentNrComboBox.DisplayMember = "StudentNumber";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                if (studentNrComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a student to edit.");
                    return;
                }

                Student oldId = studentNrComboBox.SelectedItem as Student;
                int id = oldId.StudentNumber;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                int studentNumber = int.Parse(txtStudentNumber.Text);
                int telephone = int.Parse(txtTelephone.Text);
                int roomNumber = int.Parse(txtRoomNumber.Text);
                string _class = txtClass.Text;

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    StudentNumber = studentNumber,
                    Telephone = telephone,
                    RoomNumber = roomNumber,
                    Class = _class
                };
                try
                {
                    studentService.EditStudents(student, id);
                    MessageBox.Show("Student successfully edited!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
        }
    }
}
