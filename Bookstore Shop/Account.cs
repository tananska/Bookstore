using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness;
using Data.Model;
using Data;

namespace Bookstore_Shop
{
    public partial class Account : Form
    {
        

        public Account()
        {
            InitializeComponent();
        }
        public void UpdateGrid()
        {
            using (BookStoreDbContext context = new BookStoreDbContext())
            {
                List<Data.Model.Order> orders = context.Orders
                    .Where(c => c.Customer.Id == Login.currentCustomer.Id)
                    .Select(c => c)
                    .ToList();
                dataGridView1.DataSource = orders;
                dataGridView1.ReadOnly = true;
            }
        }
        private void Account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataSet2.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.bookStoreDataSet2.Orders);
            nameTextBox.Text = Login.currentCustomer.Name;
            emailTextBox.Text = Login.currentCustomer.Email;
            addressTextBox.Text = Login.currentCustomer.Address;
            phoneTextBox.Text = Login.currentCustomer.Phonenumber;

            updateButton.Visible = false;
            changeButton.Visible = false;
            deleteButton.Visible = false;

            newPasswordLabel.Visible = false;
            passwordTextBox.Visible = false;
            confirmPasswordLabel.Visible = false;
            confirmPasswordTextBox.Visible = false;

            UpdateGrid();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login.currentCustomer = new Customer();
            new Login().Show();
            this.Hide();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
                CustomerBussiness manager = new CustomerBussiness();
                manager.Delete(Login.currentCustomer.Id);
                new Login().Show();
                this.Hide();
            
        }

        private void changeButton_Click_1(object sender, EventArgs e)
        {

            string newPassword = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            if (newPassword == confirmPassword && newPassword != null)
            {
                Login.currentCustomer.Password = newPassword;
                CustomerBussiness manager = new CustomerBussiness();
                manager.Update(Login.currentCustomer);
                MessageBox.Show("You changed your password successfully",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Password confirmation failed. Please, enter your password again!", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Login.currentCustomer.Name = nameTextBox.Text;
            Login.currentCustomer.Email = emailTextBox.Text;
            Login.currentCustomer.Address = addressTextBox.Text;
            Login.currentCustomer.Phonenumber = phoneTextBox.Text;

            CustomerBussiness manager = new CustomerBussiness();
            manager.Update(Login.currentCustomer);
        }

        private void updateRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            updateButton.Visible = true;
            changeButton.Visible = false;
            deleteButton.Visible = false;
            newPasswordLabel.Visible = false;
            passwordTextBox.Visible = false;
            confirmPasswordLabel.Visible = false;
            confirmPasswordTextBox.Visible = false;
        }

        private void changePasswordRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            updateButton.Visible = false;
            changeButton.Visible = true;
            deleteButton.Visible = false;
            newPasswordLabel.Visible = true;
            passwordTextBox.Visible = true;
            confirmPasswordLabel.Visible = true;
            confirmPasswordTextBox.Visible = true;
        }

        private void deleteRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            updateButton.Visible = false;
            changeButton.Visible = false;
            deleteButton.Visible = true;
            newPasswordLabel.Visible = false;
            passwordTextBox.Visible = false;
            confirmPasswordLabel.Visible = false;
            confirmPasswordTextBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.currentCustomer.IsAdmin)
            {
                new Administration().Show();
                this.Hide();
            }
            else
            {
                new ProductsForm().Show();
                this.Hide();
            }
        }
    }
}
