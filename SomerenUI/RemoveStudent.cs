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
    public partial class RemoveStudent : Form
    {

        public RemoveStudent()
        {
            InitializeComponent();
            studentService = new StudentService();
            RefreshStudentNr();
        }

        private Student student;
        private readonly StudentService studentService;

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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (studentNrComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a student to remove.");
                return;
            }

            Student selectedStudent = studentNrComboBox.SelectedItem as Student;

            
        RemoveConfirmation confirmDialog = new RemoveConfirmation(selectedStudent, studentService);
        DialogResult result = confirmDialog.ShowDialog();

        if (result == DialogResult.Yes)
            {
                try
                {
                    studentService.RemoveStudents(selectedStudent);
                    MessageBox.Show("Student removed successfully.");
                    RefreshStudentNr();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing student: {ex.Message}");
                }
            }
        }
    }
}
