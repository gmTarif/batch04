using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopApp
{
    public partial class BookShop : Form
    {
        List<string> customerNames = new List<string>();
        List<string> contactNumbers = new List<string>();
        List<string> addresses = new List<string>();
        List<string> orders = new List<string>();
        List<int> quantities = new List<int>();
        List<double> totalAmounts = new List<double>();

        public BookShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerNames.Add(customerNameTextBox.Text);
            contactNumbers.Add(phoneNoTextBox.Text);
            addresses.Add(addressTextBox.Text);
            orders.Add(orderComboBox.Text);
            quantities.Add(Convert.ToInt32(quantityTextBox.Text));
            
            if (orderComboBox.Text == "Math-120")
            {
                totalAmounts.Add(Convert.ToInt32(quantityTextBox.Text) * 120);
            }
            if (orderComboBox.Text == "English-100")
            {
                totalAmounts.Add(Convert.ToInt32(quantityTextBox.Text) * 100);
            }
            if (orderComboBox.Text == "Bangla-90")
            {
                totalAmounts.Add(Convert.ToInt32(quantityTextBox.Text) * 90);
            }
            if (orderComboBox.Text == "Art-80")
            {
                totalAmounts.Add(Convert.ToInt32(quantityTextBox.Text) * 80);
            }

            string message = "";
            int index = 0;
            int index1 = 1;
            foreach (string customerName in customerNames)
            {
                message = message +"  "+"   ...Customer no "+index1+" information...\n"+ "Name\t\t: " + customerName+"\nContact No\t: "+contactNumbers[index]+"\nAddress\t: "+addresses[index]+"\nOrdered book: "+orders[index]+"\nQuantity\t: "+quantities[index]+ "\nTotal prices\t: "+ totalAmounts[index]+  "\n\n";
                index++;
                index1++;
            }
            showInfoRichTextBox.Text = message;
            Clear();
        }

        private void Clear()
        {
            customerNameTextBox.Clear();
            phoneNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.Text = string.Empty;
            quantityTextBox.Clear();
        }

        private void BookShop_Load(object sender, EventArgs e)
        {
            orderComboBox.Items.Add("Math-120");
            orderComboBox.Items.Add("English-100");
            orderComboBox.Items.Add("Bangla-90");
            orderComboBox.Items.Add("Art-80");
        }
    }
}
