using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Model;
using Bussiness;


namespace Bookstore_Shop
{
    public partial class Order : Form
    {
        private void UpdateListBox()        
        {
            for (int i = 0; i < ProductsForm.basket.Count; i++)
            {
               Product product = ProductsForm.basket[i];
               int quantity = ProductsForm.quantities[i];
               string item = string.Format("{0}, {1}, {2}, {3} - {4}",product.Barcode,  product.Name , product.Description, product.Price, quantity);
               orderListBox.Items.Add(item);
            }
        }
        private decimal GetPrice()
        {
            decimal price = 0;
            for (int i = 0; i < ProductsForm.basket.Count; i++)
            {
                Product product = ProductsForm.basket[i];
                int quantity = ProductsForm.quantities[i];
                price += product.Price * quantity;
                
            }
            return price;
        }
        
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            UpdateListBox();
           
            showPriceLabel.Text = GetPrice().ToString();
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            Data.Model.Order order = new Data.Model.Order();
            order.Customer = Login.currentCustomer;
            List<Product> productsForOrder = ProductsForm.basket;

            order.Quantities = new List<QuantitiesForProduct>();

            for (int i = 0; i < productsForOrder.Count; i++)
            {
                QuantitiesForProduct QuantityForProduct = new QuantitiesForProduct()
                {
                    Order = order,
                    Product = productsForOrder[i],
                    Quantity = ProductsForm.quantities[i]
                };
                order.Quantities.Add(QuantityForProduct);
            }

            order.Price = GetPrice();
            order.Comment = commentTextBox.Text ?? "";
            order.Created = DateTime.Now;
            order.Status = OrderStatus.Processing;
            OrderBussiness manager = new OrderBussiness();
            //manager.Create(order);
            orderListBox.Items.Clear();
            showPriceLabel.Text = "";
            MessageBox.Show("The order was made successfully!", "Ïnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        

        private void goToProductsButton_Click(object sender, EventArgs e)
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
