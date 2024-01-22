// Andrew Russo
// CPT-206-A80S
// Lab-14

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russo_Andrew_CPT_206_Chapter_14
{
    public partial class Form1 : Form
    {
        // Create the data context object.
        public ProductDataContext db = new ProductDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            // Get all the Procust objects from the Products collection.
            var results = from prod in db.Products
                          select prod;
            */
            
            var results = db.Products;

            // Assign the results of the query to the DataGridView control.
            productDataGridView.DataSource = results;
        } // end form_load

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Exits the program
            MessageBox.Show("Thank you for running the program!");
            this.Close();
        } //end exit button

        private void numSearchButton_Click(object sender, EventArgs e)
        {
            //var results = db.Where(pro => pro.Product_Number == numSearchInputTextBox.Text);
            // Where doesn't exist? not sure what is happening here TBH

            // Get input string then get objects from products collection.
            string prodNum = numSearchInputTextBox.Text;
            

            if (prodNum.Length == 5)
            {
                var results = from prod in db.Products
                              where prod.Product_Number == prodNum
                              select prod;

                // Load the results in to the grid.
                productDataGridView.DataSource = results;

            }
            else
            {
                MessageBox.Show(prodNum + " is not a valid item number. Please try again.");
            }
        }

        private void resetListButton_Click(object sender, EventArgs e)
        {
            // Get all the Product objects from the Products collection.

            /*
            var results = from prod in db.Products
                          select prod;
            */

            var results = db.Products;

            // Assign the results of the query to the DataGridView control.
            productDataGridView.DataSource = results;
        }

        private void descSearchButton_Click(object sender, EventArgs e)
        {
            // Get input and validate
            string prodDesc = descSearchInputTextBox.Text;
            if (prodDesc.Length != 0)
            {
            
            // Get objects from products collection.
            var results = from prod in db.Products
                          where prod.Description.Contains(prodDesc)
                          orderby prod.Product_Number
                          select prod;
            

             //var results = db.Products.Contains(prodDesc);

            // Load the results in to the grid.
                productDataGridView.DataSource = results;
            }
            else
            {
                MessageBox.Show("Please enter at least a partial description of the item (one (1) or more characters).");
            }
        }

        private void orderByAscOnHandButton_Click(object sender, EventArgs e)
        {
            // Order by number of items on hand in ascending

            /*
            var results = from prod in db.Products
                          orderby prod.Units_On_Hand ascending
                          select prod;
            */

            var results = db.Products.OrderBy(p => p.Units_On_Hand);

            // Load the results in to the grid.
            productDataGridView.DataSource = results;
        }

        private void orderByDescOnHandButton_Click(object sender, EventArgs e)
        {
            // Order by number of items on hand in descending

            /*
            var results = from prod in db.Products
                          orderby prod.Units_On_Hand descending
                          select prod;
            */

            var results = db.Products.OrderByDescending(p => p.Units_On_Hand);

            // Load the results in to the grid.
            productDataGridView.DataSource = results;
        }

        private void orderByAscPriceButton_Click(object sender, EventArgs e)
        {
            // Order by price of items on hand in ascending

            /*
            var results = from prod in db.Products
                          orderby prod.Price ascending
                          select prod;
            */
            
            var results = db.Products.OrderBy(p => p.Price);
            
            // Load the results in to the grid.
            productDataGridView.DataSource = results;
        }

        private void orderByDescPriceButton_Click(object sender, EventArgs e)
        {
            // Order by value of items on hand in descending

            /*
            var results = from prod in db.Products
                          orderby prod.Price descending
                          select prod;
            */

            var results = db.Products.OrderByDescending(p => p.Price);

            // Load the results in to the grid.
            productDataGridView.DataSource = results;
        }

        private void onHandMoreThanButton_Click(object sender, EventArgs e)
        {
            // Confirm input is an int
            int onHandSearchVal;

            if (int.TryParse(onHandSerachValueInputTextBox.Text, out onHandSearchVal))
            {
                // Find items that you have more than the number entered on hand

                /*
                var results = from prod in db.Products
                              where prod.Units_On_Hand > onHandSearchVal
                              select prod;
                */

                var results = db.Products.Where(p => p.Units_On_Hand > onHandSearchVal).OrderBy(p => p.Units_On_Hand);

                // Load the results in to the grid.
                productDataGridView.DataSource = results;
            }
            else
            {
                MessageBox.Show("Please ender a valid whole number.");
            }
            
        }

        private void onHandLessThanButton_Click(object sender, EventArgs e)
        {
            // Confirm input is an int
            int onHandSearchVal;

            if (int.TryParse(onHandSerachValueInputTextBox.Text, out onHandSearchVal))
            {
                // Find items that you have less than the number entered on hand
                
                /*
                var results = from prod in db.Products
                              where prod.Units_On_Hand < onHandSearchVal
                              select prod;
                */

                var results = db.Products.Where(p => p.Units_On_Hand < onHandSearchVal).OrderByDescending(p => p.Units_On_Hand);

                // Load the results in to the grid.
                productDataGridView.DataSource = results;
            }
            else
            {
                MessageBox.Show("Please ender a valid whole number.");
            }
        }

        private void priceBetweenButton_Click(object sender, EventArgs e)
        {
            // Confirm inputs are int
            decimal minVal, maxVal;

            if (decimal.TryParse(minPriceInputTextBox.Text, out minVal) && decimal.TryParse(maxPriceInputTextBox.Text, out maxVal))
            {
                // Find values between minVal and maxVal

                /*
                var results = from prod in db.Products
                              where prod.Price >= minVal
                              where prod.Price <= maxVal
                              select prod;
                */

                var results = db.Products.Where(p => p.Price >= minVal).Where(p => p.Price <= maxVal);

                // Load the results in to the grid.
                productDataGridView.DataSource = results;
            }
        }
    }
}
