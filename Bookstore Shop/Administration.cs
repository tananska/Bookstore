using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness;
using Data.Model;
using Data;

namespace Bookstore_Shop
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private ProductBussiness manager = new ProductBussiness();
        
        private bool CheckAllAdminTextBoxes(string name, string email, string password, string confirmPassword, string address, string phone)
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

        private bool CheckAllProductTextBoxes(string barcode, string name, string description)
        {
            return name.Length != 0 && barcode.Length != 0 && description.Length != 0;
        }
        private void UpdateListView()
        {
            using (BookStoreDbContext context = new BookStoreDbContext())
            {
                List<Customer> admins = context.Customers
                    .Where(c => c.IsAdmin == true)
                    .Select(c => c)
                    .ToList();
                foreach (Customer admin in admins)
                {
                    adminsListView.Items.Add(admin.Name);
                }
            }
        }


        private void Administration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataSet5.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter3.Fill(this.bookStoreDataSet5.Products);
           LoadForm();
           UpdateGrid();
           UpdateListView();

        }
        private void LoadForm()
        {
            // TODO: This line of code loads data into the 'bookstoreDBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.bookstoreDBDataSet.Products);
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = manager.ReadAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        private void addAdminButton_Click(object sender, EventArgs e)
        {
            string name = adminNameTextBox.Text;
            string email = adminEmailTextBox.Text;
            string password = adminPasswordTextBox.Text;
            string confirmPassword = adminCofirmPasswordTextBox.Text;
            string address = adminAddressTextBox.Text;
            string phone = adminPhoneTextBox.Text;

            if (CheckAllAdminTextBoxes(name, email, password, confirmPassword, address, phone))
            {
                if(password == confirmPassword)
                {
                    if (!CheckIfCustomerExists(name, email))
                    {
                        Customer admin = new Customer(name, email, password, address, phone);
                        admin.IsAdmin = true;
                        CustomerBussiness manager = new CustomerBussiness();
                        manager.Create(admin);
                        UpdateListView();
                    }
                    else
                    {
                        MessageBox.Show("User with this data already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void addButton_Click(object sender, EventArgs e)
        {
            string barcode = barcodeTextBox.Text;
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            int quantity = (int)quantityNumericUpDown.Value;
            decimal price = priceNumericUpDown.Value;
            string  productType = typeComboBox.SelectedItem.ToString();
            if (CheckAllProductTextBoxes(barcode, name, description))
            {
                if (productType != null)
	            {
                    Product product;
                    if (productType == "Notebook")
                    {
                        product = new Notebook();
                    }
                    else if (productType == "Pen")
                    {
                        product = new Pen();
                    }
                    else if(productType == "Pencil")
                    {
                        product = new Pencil();
                    }
                    else
                    {
                        product = new Eraser();
                    }
                    product.Barcode = barcode;
                    product.Name = name;
                    product.Quantity = quantity;
                    product.Price = price;
                    product.Description = description;

                    manager.Create(product);
                    UpdateGrid();
                    clearButton_Click(sender, e);
                    
	            }
                else
                {
                    MessageBox.Show("Please, select product type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill all of the required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string barcode = barcodeTextBox.Text;
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            int quantity = (int)quantityNumericUpDown.Value;
            decimal price = priceNumericUpDown.Value;
            string productType = typeComboBox.SelectedItem.ToString();
            if (barcode != null)
            {
                try
                {
                    Product item = manager.Read(barcode);
                    item.Name = name ?? item.Name;
                    item.Description = description ?? item.Description;
                    item.Quantity = quantity;
                    item.Price = price;

                    manager.Update(item);
                    UpdateGrid();
                    clearButton_Click(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("There is no item with that barcode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must enter the barcode of the product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            barcodeTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            quantityNumericUpDown.Value = 1;
            priceNumericUpDown.Value = 1;
            typeComboBox.Text = "";
            dataGridView1.ClearSelection();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                string id = item[0].Value.ToString();
                manager.Delete(id);
                UpdateGrid();
            }
        }


        private void barcodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ProductsForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Account().Show();
            this.Hide();
        }

    }
}
