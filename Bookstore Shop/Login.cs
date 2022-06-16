using Bussiness;
using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Shop
{
    public partial class Login : Form
    {
        public static Customer currentCustomer;

        private bool CheckAllSignUpTextBoxes(string name, string email, string password, string confirmPassword, string address, string phone)
        {
            return name != null && email != null && password != null && confirmPassword != null && address != null && phone != null;
        }
        private bool CheckIfCustomerExists(string name, string email)
        {
            using (BookStoreDbContext context = new BookStoreDbContext())
            {
               int customerCount = context.Customers
                    .Where(c => c.Name == name && c.Email == email)
                    .ToList().Count;
               return customerCount != 0;
            }
        }
        private bool CheckIfCustomerHasRegistration(string email)
        {
            using (BookStoreDbContext context = new BookStoreDbContext())
            {
                int customerCount = context.Customers
                     .Where(c => c.Email == email)
                     .ToList().Count;
                return customerCount != 0;
            }
        }
        private bool CheckIfPasswordMatches(string email, string password)
        {
            using (BookStoreDbContext context = new BookStoreDbContext())
            {
                int customerCount = context.Customers
                     .Where(c => c.Email == email && c.Password == password)
                     .ToList().Count;
                return customerCount != 0;
            }
        }
        private void GetCustomer(string email, string password)
        {
            using (BookStoreDbContext context = new BookStoreDbContext())
            {
                List<Customer> customer = context.Customers
                     .Where(c => c.Email == email && c.Password == password)
                     .Select(c => c)
                     .ToList();
                currentCustomer = customer[0];

            }
        }
        private void ClearTextBoxes()
        {
            signUpNameTextBox.Clear();
            signUpEmailTextBox.Clear();
            signUpPasswordTextBox.Clear();
            signUpCofirmPasswordTextBox.Clear();
            signUpAddressTextBox.Clear();
            signUpPhoneTextBox.Clear();

        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = loginEmailTextBox.Text;
                string password = loginPasswordTextBox.Text;
                if (email != null && password != null)
                {
                    if (CheckIfCustomerHasRegistration(email))
                    {
                        if (CheckIfPasswordMatches(email, password))
                        {

                            GetCustomer(email, password);
                            if (currentCustomer.IsAdmin)
                            {
                                new Administration().Show();
                                this.Hide();
                            }
                            else
                            {
                                new Account().Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong password. Please, enter your password again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such user has been found. You have to register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fill your email and password!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string name = signUpNameTextBox.Text;
            string email = signUpEmailTextBox.Text;
            string password = signUpPasswordTextBox.Text;
            string confirmPassword = signUpCofirmPasswordTextBox.Text;
            string address = signUpAddressTextBox.Text;
            string phone = signUpPhoneTextBox.Text;
            if (CheckAllSignUpTextBoxes(name, email, password, confirmPassword, address, phone))
            {
                if (password == confirmPassword)
                {
                    if (!CheckIfCustomerExists(name, email))
                    {
                        currentCustomer = new Customer(name, email, password, address, phone);
                        CustomerBussiness manager = new CustomerBussiness();
                        manager.Create(currentCustomer);
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Registration with this data already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Password confirmation failed. Please, enter your password again!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Fill all of the required information!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
