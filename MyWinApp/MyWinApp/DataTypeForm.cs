using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class DataTypeForm : Form
    {
        public DataTypeForm()
        {
            InitializeComponent();
        }

        private void DataTypeButton_Click(object sender, EventArgs e)
        {
            int firstNumber=10;
            int secondnumber = firstNumber;
            double thirdNumber = secondnumber;
            int fourthNumber = (int)thirdNumber;
            string number = fourthNumber.ToString();

            MessageBox.Show("First number: "+firstNumber+" Second number: "+secondnumber+" Third number: "+thirdNumber + " 4th number: " + fourthNumber);
        }
    }
}
