using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlLecturer.Hide();
            pnlDrinks.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturer.Hide();
            pnlDrinks.Hide();

            pnlStudents.Show();

            try
            {
                // get and display all lecturers
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            listViewStudents.Columns.Add("Student Nr", 100);
            listViewStudents.Columns.Add("First Name", 100);
            listViewStudents.Columns.Add("Last Name", 100);
            listViewStudents.Columns.Add("Telephone", 100);
            listViewStudents.Columns.Add("Room Number", 100);
            listViewStudents.Columns.Add("Class", 100);

            foreach (Student student in students)
            {
                // Create a ListViewItem for the current student
                ListViewItem li = new ListViewItem(student.StudentNumber.ToString());

                // Add subitems for each property
                li.SubItems.Add(student.FirstName);
                li.SubItems.Add(student.LastName);
                li.SubItems.Add(student.Telephone.ToString());
                li.SubItems.Add(student.RoomNumber.ToString());
                li.SubItems.Add(student.Class);

                li.Tag = student;
                listViewStudents.Items.Add(li);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }
        private void ShowLecturersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlDrinks.Hide();
            // show students
            pnlLecturer.Show();
            try
            {
                // get and display all students
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
            }
        }
        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            // clear the listview before filling it
            listViewLecturers.Clear();

            listViewLecturers.Columns.Add("Lecturer ID", 100);
            listViewLecturers.Columns.Add("First Name", 100);
            listViewLecturers.Columns.Add("Last Name", 100);
            listViewLecturers.Columns.Add("Telephone", 100);
            listViewLecturers.Columns.Add("Room Number", 100);
            listViewLecturers.Columns.Add("Class", 100);

            foreach (Lecturer lecturer in lecturers)
            {
                // Create a ListViewItem for the current lecturer
                ListViewItem li = new ListViewItem(lecturer.LecturerId.ToString());

                // Add subitems for each property
                li.SubItems.Add(lecturer.FirstName);
                li.SubItems.Add(lecturer.LastName);
                li.SubItems.Add(lecturer.Telephone.ToString());
                li.SubItems.Add(lecturer.RoomNumber.ToString());
                li.SubItems.Add(lecturer.Class);

                li.Tag = lecturer;
                listViewLecturers.Items.Add(li);
            }
        }

        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetLecturers();
            return lecturers;
        }

        private void ShowDrinksPanel()
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturer.Hide();

            pnlDrinks.Show();
            try
            {
                // get and display all students
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }
        private void DisplayDrinks(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinks.Clear();

            listViewDrinks.Columns.Add("Drink ID", 100);
            listViewDrinks.Columns.Add("Name", 100);
            listViewDrinks.Columns.Add("Stock", 100);
            listViewDrinks.Columns.Add("Price", 100);
            listViewDrinks.Columns.Add("Alcohol Type", 100);

            foreach (Drink drink in drinks)
            {
                // Create a ListViewItem for the current drink
                ListViewItem li = new ListViewItem(drink.DrinkId.ToString());

                // Add subitems for each property
                li.SubItems.Add(drink.Name);
                li.SubItems.Add(drink.Stock.ToString());
                li.SubItems.Add(drink.Price.ToString());
                li.SubItems.Add(drink.AlcoholType.ToString());

                li.Tag = drink;
                listViewDrinks.Items.Add(li);
            }
        }

        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }
        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }
        private void SomerenUI_Load(object sender, EventArgs e)
        {
            pnlDrinks.Hide();
            pnlLecturer.Hide();
            pnlStudents.Hide();
            ShowDashboardPanel();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void orderDrinktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrinkOrderForm drinkOrderForm = new DrinkOrderForm();

            drinkOrderForm.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            RemoveStudent removeStudent = new RemoveStudent();
            removeStudent.Show();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            editStudent.Show();
        }
    }
}