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
    public partial class DrinkOrderForm : Form
    {
        public DrinkOrderForm()
        {
            InitializeComponent();
            drinkService = new DrinkService();
            studentService = new StudentService();
            RefreshDrinks();
            RefreshStudentNr();
        }

        private readonly DrinkService drinkService;
        private readonly StudentService studentService;
        private Student student;



        void RefreshDrinks()
        {
            drinkNameComboBox.Items.Clear();
            drinkNameComboBox.ResetText();

            List<Drink> drinks = drinkService.GetDrinks();

            foreach (Drink drink in drinks)
            {
                drinkNameComboBox.Items.Add(drink);
            }
            drinkNameComboBox.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (drinkNameComboBox.SelectedIndex == null)
            {
                MessageBox.Show("Please enter a drink");
                return;
            }
            try
            {
                Drink selectedDrink = drinkNameComboBox.SelectedItem as Drink;
                Student selectedStudent = studentNrComboBox.SelectedItem as Student;
                int quantity = int.Parse(amountTextBox.Text);
                decimal totalPrice = selectedDrink.Price * quantity;
                OrderService orderService = new OrderService();

                orderService.OrderDrink(selectedStudent.StudentNumber,selectedDrink.DrinkId, quantity);
                label5.Text = totalPrice.ToString();
                label6.Text = "Order placed successfully!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
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

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(amountTextBox.Text);
                Drink selectedDrink = drinkNameComboBox.SelectedItem as Drink;
                decimal totalPrice = selectedDrink.Price * quantity;
                label5.Text = totalPrice.ToString();
            }
            catch
            {
                label5.ResetText();
            }
        }
    }
}
