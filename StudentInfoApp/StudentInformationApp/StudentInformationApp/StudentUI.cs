using StudentInformationApp.BLL.BLL;
using StudentInformationApp.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentUI : Form
    {
        Student aStudent;
        StudentManager _studentManager = new StudentManager();

        public StudentUI()
        {
            InitializeComponent();

            aStudent = new Student();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            idLabel.Text = "";
            nameLabel.Text = "";
            rollLabel.Text = "";
            conLabel.Text = "";
            emailLabel.Text = "";

            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                idLabel.Text = "ID field cannot be empty!";
                return;
            }
            if (!Int32.TryParse(idTextBox.Text, out int result))
            {
                //MessageBox.Show("Input only digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idLabel.Text = "Input only digits!";
                return;
            }
            aStudent.ID = Convert.ToInt32(idTextBox.Text);
            if (_studentManager.IdValidation(aStudent))
            {
                idLabel.Text = "ID already exists!";
                return;
            }


            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameLabel.Text = "Name must be needed!";
                return;
            }
            aStudent.Name = nameTextBox.Text;


            if (string.IsNullOrEmpty(rollTextBox.Text))
            {
                rollLabel.Text = "Roll No must be needed!";
                return;
            }
            aStudent.Roll = rollTextBox.Text;
            if (_studentManager.RollValidation(aStudent))
            {
                rollLabel.Text = "This roll already exists!";
                return;
            }


            if (string.IsNullOrEmpty(contactTextBox.Text))
            {
                conLabel.Text = "Contact field cannot be empty!";
                return;
            }
            if (!Int32.TryParse(contactTextBox.Text, out int result2))
            {
                MessageBox.Show("Input only digits not more\nthan 11 character.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            aStudent.Contact = Convert.ToInt32(contactTextBox.Text);


            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailLabel.Text = "Email Id needed!";
                return;
            }
            aStudent.Email = emailTextBox.Text;
            if (_studentManager.EmailValidation(aStudent))
            {
                emailLabel.Text = "Email already exists!";
                return;
            }
            if(!(emailTextBox.Text).Contains("@") || !(emailTextBox.Text).Contains("."))
            {
                MessageBox.Show("Plz give a valid email Id.", "Message");
                return;
            }
            
            int isExecuted;
            isExecuted = _studentManager.InsertStudent(aStudent);
            if (isExecuted > 0)
            {
                idTextBox.Text = "";
                nameTextBox.Text = "";
                rollTextBox.Text = "";
                contactTextBox.Text = "";
                emailTextBox.Text = "";
                MessageBox.Show("Added Successfully.", "Message");
            }
            else
            {
                MessageBox.Show("Add failed!");
            }

            displayDataGridView.DataSource = _studentManager.DisplayStudent();
        }

        private void StudentUI_Load(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _studentManager.DisplayStudent();

            displayDataGridView.Columns[0].DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            displayDataGridView.Columns[1].DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            displayDataGridView.Columns[2].DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            displayDataGridView.Columns[3].DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            displayDataGridView.Columns[4].DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            displayDataGridView.Columns[5].DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            displayDataGridView.Columns[6].DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);

            //Header text size,style,font...
            displayDataGridView.Columns[0].HeaderCell.Style.Font = new Font("Sitka Heading", 14, FontStyle.Bold);
            displayDataGridView.Columns[1].HeaderCell.Style.Font = new Font("Sitka Heading", 14, FontStyle.Bold);
            displayDataGridView.Columns[2].HeaderCell.Style.Font = new Font("Sitka Heading", 14, FontStyle.Bold);
            displayDataGridView.Columns[3].HeaderCell.Style.Font = new Font("Sitka Heading", 14, FontStyle.Bold);
            displayDataGridView.Columns[4].HeaderCell.Style.Font = new Font("Sitka Heading", 14, FontStyle.Bold);
            displayDataGridView.Columns[5].HeaderCell.Style.Font = new Font("Sitka Heading", 14, FontStyle.Bold);
            displayDataGridView.Columns[6].HeaderCell.Style.Font = new Font("Sitka Heading", 14, FontStyle.Bold);

            //Header backColor...
            displayDataGridView.Columns[0].HeaderCell.Style.BackColor = Color.Turquoise;
            displayDataGridView.Columns[1].HeaderCell.Style.BackColor = Color.Turquoise;
            displayDataGridView.Columns[2].HeaderCell.Style.BackColor = Color.Turquoise;
            displayDataGridView.Columns[3].HeaderCell.Style.BackColor = Color.Turquoise;
            displayDataGridView.Columns[4].HeaderCell.Style.BackColor = Color.Turquoise;
            displayDataGridView.Columns[5].HeaderCell.Style.BackColor = Color.Turquoise;
            displayDataGridView.Columns[6].HeaderCell.Style.BackColor = Color.Turquoise;

            displayDataGridView.EnableHeadersVisualStyles = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            aStudent.Roll = searchTextBox.Text;
            aStudent.Name = searchTextBox.Text;

            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                displayDataGridView.DataSource = _studentManager.SearchStudent(aStudent);
            }
            else
            {
                displayDataGridView.DataSource = _studentManager.DisplayStudent();
            }

            idTextBox.Text = "";
            nameTextBox.Text = "";
            rollTextBox.Text = "";
            contactTextBox.Text = "";
            emailTextBox.Text = "";

            idLabel.Text = "";
            nameLabel.Text = "";
            rollLabel.Text = "";
            conLabel.Text = "";
            emailLabel.Text = "";
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int isDeleted;
             isDeleted = _studentManager.DeleteStudent(aStudent);
            if (isDeleted > 0)
            {
                idTextBox.Text = "";
                nameTextBox.Text = "";
                rollTextBox.Text = "";
                contactTextBox.Text = "";
                emailTextBox.Text = "";

                MessageBox.Show("Record Deleted.", "Message");
                SaveButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Record delete failed!", "Message");
            }

            displayDataGridView.DataSource = _studentManager.DisplayStudent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                idLabel.Text = "ID field cannot be empty!";
                return;
            }
            if (!Int32.TryParse(idTextBox.Text, out int result))
            {
                //MessageBox.Show("Input only digits.");
                idLabel.Text = "Input only digits!";
                return;
            }
            aStudent.ID = Convert.ToInt32(idTextBox.Text);
            if (_studentManager.IdValidation(aStudent))
            {
                idLabel.Text = "ID already exists!";
                return;
            }


            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameLabel.Text = "Name must be needed!";
                return;
            }
            aStudent.Name = nameTextBox.Text;


            if (string.IsNullOrEmpty(rollTextBox.Text))
            {
                rollLabel.Text = "Roll No must be needed!";
                return;
            }
            aStudent.Roll = rollTextBox.Text;
            if (_studentManager.RollValidation(aStudent))
            {
                rollLabel.Text = "This roll already exists!";
                return;
            }


            if (string.IsNullOrEmpty(contactTextBox.Text))
            {
                conLabel.Text = "Contact field cannot be empty!";
                return;
            }
            if (!Int32.TryParse(contactTextBox.Text, out int result2))
            {
                MessageBox.Show("Input only digits not more\nthan 11 character.");
                return;
            }
            aStudent.Contact = Convert.ToInt32(contactTextBox.Text);


            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailLabel.Text = "Email Id needed!";
                return;
            }
            aStudent.Email = emailTextBox.Text;
            if (_studentManager.EmailValidation(aStudent))
            {
                emailLabel.Text = "Email already exists!";
                return;
            }
            if(!(emailTextBox.Text).Contains("@") || !(emailTextBox.Text).Contains("."))
            {
                MessageBox.Show("Plz give a valid email Id.");
                return;
            }

            int isExecuted;
            isExecuted = _studentManager.UpdateStudent(aStudent);
            if (isExecuted > 0)
            {
                idTextBox.Text = "";
                nameTextBox.Text = "";
                rollTextBox.Text = "";
                contactTextBox.Text = "";
                emailTextBox.Text = "";
                MessageBox.Show("Update Successfully.", "Message");
                SaveButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Update failed!", "Message");
            }
            
            displayDataGridView.DataSource = _studentManager.DisplayStudent();
        }

        private void displayDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (displayDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    displayDataGridView.CurrentRow.Selected = true;

                    aStudent.Sl = Convert.ToInt32(displayDataGridView.Rows[e.RowIndex].Cells["slDataGridViewTextBoxColumn"].FormattedValue);

                    idTextBox.Text = displayDataGridView.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    nameTextBox.Text = displayDataGridView.Rows[e.RowIndex].Cells["nameDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    rollTextBox.Text = displayDataGridView.Rows[e.RowIndex].Cells["rollDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    contactTextBox.Text = displayDataGridView.Rows[e.RowIndex].Cells["contactDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    emailTextBox.Text = displayDataGridView.Rows[e.RowIndex].Cells["emailDataGridViewTextBoxColumn"].FormattedValue.ToString();
                    
                    SaveButton.Visible = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Please select only row contents.");
            }
            
        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.displayDataGridView.Rows[e.RowIndex].Cells["SerialNo"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
