using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Model;
using Data;
using Bussiness;

namespace Bookstore_Shop
{
    public partial class ProductsForm : Form
    {
        public static List<Product> basket = new List<Product>();
        public static List<int> quantities = new List<int>();

        private void UpdateGrid()
        {
            using (BookStoreDbContext context = new BookStoreDbContext())
            {
                List<Product> products = new List<Product>();
                if (penRadioButton.Checked)
                {
                    products = context.Products.Where(c => c as Pen != null)
                               .Select(c => c).ToList();
                }
                else if (pencilRadioButton.Checked)
                {
                    products = context.Products.Where(c => c as Pencil != null)
                               .Select(c => c).ToList();

                }
                else if (notebookRadioButton.Checked)
                {
                    products = context.Products.Where(c => c as Notebook != null)
                               .Select(c => c).ToList();
                }
                else if(eraserRadioButton.Checked)
                {
                    products = context.Products.Where(c => c as Eraser != null)
                               .Select(c => c).ToList();
                }
                dataGridView1.DataSource = products;
                dataGridView1.ReadOnly = true;
            }
        }

        public ProductsForm()
        {
            InitializeComponent();
        }
        
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataSet6.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter2.Fill(this.bookStoreDataSet6.Products);
            
            UpdateGrid();

        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            if (Login.currentCustomer.IsAdmin)
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

        private void basketButton_Click(object sender, EventArgs e)
        {
            ProductBussiness manager = new ProductBussiness();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int quantity = (int)quantityNumericUpDown.Value;
                var item = dataGridView1.SelectedRows[0].Cells[0].Value;
                string id = item.ToString();
                Product product = manager.Read(id);
                if (quantity <= product.Quantity)
                {
                    basket.Add(product);
                    quantities.Add(quantity);
                    MessageBox.Show("The products are added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The product is not available in this quantity!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please, select product!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void penRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void pencilRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void notebookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void eraserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void goToOrderButton_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }
    }
}
