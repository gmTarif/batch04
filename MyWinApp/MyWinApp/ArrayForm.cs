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
    public partial class ArrayForm : Form
    {
        const int size = 3;
        int [] number = new int[size];
        
        int index = 0;

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //const int size = 10;
            //int[] number = new int[size];
            //number[0] = 4;
            //number[3] = 6;
            //number[8] = 15;

            string message="";

            for (int index=0; index<number.Length; index++)
            {
                if(number[index]!=0)
                message = message + "Eliment at index[" + index +"] is: "+ number[index].ToString()+"\n\n";
            }
            showRichTextBox.Text = message+"\n\n";
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            number[index]= Convert.ToInt32(numberTextBox.Text);
            index ++;

            numberTextBox.Clear();
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            

            string message = "";

            for (int index = size-1; index >= 0; index--)
            {
                if (number[index] != 0)
                    message = message + number[index].ToString() + "\n";
            }
            showRichTextBox.Text = message;

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int index = 0; index <number.Length; index++)
            {
                if (number[index] != 0)
                    sum = sum + number[index];
            }
            showRichTextBox.Text = "The summetion of array is: "+ sum.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int[] number2 = new int[size];
            for (int index = 0; index < number.Length; index++)
            {
                number2[index] = number[index];
            }
            
            string message = "";
            string message2 = "";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + number[index].ToString() + "\n";
            }
          
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message2 = message2 + number2[index].ToString() + "\n";
            }
            showRichTextBox.Text = "The elements stored in the first array are : \n" + message + "\n" + "The elements copied into the second array are : \n" + message2;
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            int duplicate = number[0];
            

            for (int index = 0; index < size; index++)
            {
                for (int index2 = 0; index2 < size; index2++)
                {
                    if (duplicate == number[index2])
                    {
                        duplicate = number[index2];
                    }
                }
                    
            }
            showRichTextBox.Text = "The duplicate number are: " + duplicate.ToString();
        }

        private void MaxMinButton_Click(object sender, EventArgs e)
        {
            int max = number[0];
            int min = number[0];

            for (int index=1; index<size; index++)
            {
                if (number[index] > max)
                {
                    max = number[index];
                }

                if (number[index] < min)
                {
                    min = number[index];
                }
            }
            showRichTextBox.Text = "The maximum number is: " + max.ToString() + "\n" + "The minimum number is: " + min.ToString();
        }
    }
}
    













// "Eliment at index[" + index + "] is: " + 