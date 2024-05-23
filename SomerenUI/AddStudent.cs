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
    public partial class AddStudent : Form
    {
        StudentService studentService;
        public AddStudent()
        {
            InitializeComponent();
            studentService = new StudentService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
                

                studentService.AddStudents(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            txtFirstName.Clear();
            txtLastName.Clear();
            txtStudentNumber.Clear();
            txtTelephone.Clear();
            txtRoomNumber.Clear();
            txtClass.Clear();

            StudentAdded studentAdded = new StudentAdded();
            studentAdded.Show();
        }
    }
}
