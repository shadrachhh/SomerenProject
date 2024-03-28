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

            //
            pnlActivity.Show();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Name);
                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
        }
        private void ShowActvityPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();


            // show students
            pnlStudents.Hide();
            pnlActivity.Show();



            try
            {
                // get and display all students
                List<activity> activities = GetActivity();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<activity> GetActivity()
        {
            ActivityService activityService = new ActivityService();
            List<activity> activities = activityService.GetActivity();
            return activities;
        }

        private void DisplayActivities(List<activity> activities)
        {
            // clear the listview before filling it
            listViewActivity.Clear();

            listViewActivity.Columns.Add("activity ID", 100);
            listViewActivity.Columns.Add("activity Name", 100);
            listViewActivity.Columns.Add("StartTime", 100);
            listViewActivity.Columns.Add("EndTime", 100);


            foreach (activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.ActivityId.ToString());


                li.SubItems.Add(activity.Name.ToString());
                li.SubItems.Add(activity.StartTime.ToString());
                li.SubItems.Add(activity.EndTime.ToString());



                li.Tag = activity;   // link student object to listview item
                listViewActivity.Items.Add(li);
            }
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

        private void SomerenUI_Load(object sender, EventArgs e)
        {

        }

        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActvityPanel();
        }

        private void listViewActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}