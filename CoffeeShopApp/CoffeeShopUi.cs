using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class CoffeeShopUi : Form
    {
        public CoffeeShopUi()
        {
            InitializeComponent();
        }
        string[] paymentStatus = new string[7];
        int i = 0;
        string data;
        string totalPayment;
        private void saveButton1_Click(object sender, EventArgs e)
        {
            try
            {
            string customerName = customerNameTextBox1.Text;
            int contactNo = Convert.ToInt32(contactTextBox1.Text);
            string address = addressTextBox1.Text;
            string order = orderComboBox1.Text;
            int quantity = Convert.ToInt32(quantityTextBox1.Text);
            int totalPrice = 0;

            
                if (orderComboBox1.Text == "")
                {
                    MessageBox.Show("Please Select an Item");
                    return;
                }

                else
                {

                    if (orderComboBox1.Text == "Black")
                    {
                        totalPrice = quantity * 120;

                    }

                    else if (orderComboBox1.Text == "Cold")
                    {
                        totalPrice = quantity * 100;
                    }

                    else if (orderComboBox1.Text == "Hot")
                    {
                        totalPrice = quantity * 90;
                    }

                    else if (orderComboBox1.Text == "Regular")
                    {
                        totalPrice = quantity * 80;
                    }

                }

                
                data = ("        Payment Status\n\nCustomer Name: " + customerName + "\nContact No.: " + contactNo + "\nAddress: " + address +
                   "\nOrder: " + orderComboBox1.SelectedItem + "\nQuantity: " + quantity + "\nTotal Price: " + totalPrice);

                paymentStatus[i] = data;
                paymentRichTextBox1.Clear();
                for (int j = 0; j < 7; j++)
                {
                    totalPayment += paymentStatus[j] + "\n";
                }

            }
            catch ( Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                paymentRichTextBox1.Text = "display";
                paymentRichTextBox1.Text =totalPayment;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
