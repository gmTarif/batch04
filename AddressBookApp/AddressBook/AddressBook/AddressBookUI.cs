using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class AddressBookUI : Form
    {
        public AddressBookUI()
        {
            
            InitializeComponent();
            persons = new List<Person>();
        }
        Person person;
        List<Person> persons;
        
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                infoLabel2.Text = "";
                infoLabel1.Text = "";
                person = new Person();
                if (SaveButton.Text == "Save")
                {

                    person.FirstName = firstNameTextBox.Text;
                    person.LastName = lastNameTextBox.Text;
                    if (string.IsNullOrEmpty(lastNameTextBox.Text))
                    {
                        infoLabel2.Text = "Last name required!";
                        return;
                    }

                    foreach (Person aPerson in persons)
                    {
                        if (mailTextBox.Text == aPerson.Email)
                        {
                            infoLabel1.Text = "Email already exists! Give an uniqe email.";
                            return;
                        }
                    }


                    person.Email = mailTextBox.Text;

                    if (!(person.Email).Contains("@") || !(person.Email).Contains("."))
                    {
                        MessageBox.Show("Plz give a valid Id.");
                        return;
                    }

                    if (String.IsNullOrEmpty(phoneTextBox.Text))
                    {
                        MessageBox.Show("Phone feild cannot be empty!");
                        return;
                    }
                    else
                    {
                        person.PhoneNo = Convert.ToInt64(phoneTextBox.Text);
                    }

                    //person.PhoneNo = (long)Convert.ToDouble(phoneTextBox.Text);


                    persons.Add(person);

                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    mailTextBox.Text = "";
                    phoneTextBox.Text = "";
                }
            

                if (SaveButton.Text == "Update")
                {
                    foreach (Person person in persons)
                    {
                        if (person.Email == editMailTextBox.Text)
                        {
                            person.FirstName = firstNameTextBox.Text;
                            person.LastName = lastNameTextBox.Text;
                            person.Email = mailTextBox.Text;
                            person.PhoneNo = Convert.ToInt64(phoneTextBox.Text);
                        }
                    }
                   
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    mailTextBox.Text = "";
                    phoneTextBox.Text = "";
                    SaveButton.Text = "Save";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter only digits.");
                return;
            }


        }


        List<Person> personList;
        private void FullScarchButton_Click(object sender, EventArgs e)
        {

            personList = new List<Person>();

            if(!String.IsNullOrEmpty(scearchLNameTextBox.Text) & String.IsNullOrEmpty(scearchMailTextBox.Text) & String.IsNullOrEmpty(scearchPhoneTextBox.Text))
            {
                foreach (Person person1 in persons)
                {
                    if (person1.LastName == scearchLNameTextBox.Text)
                    {
                        personList.Add(person1);
                    }
                }

                
            }
            
            if (!String.IsNullOrEmpty(scearchLNameTextBox.Text) & !String.IsNullOrEmpty(scearchMailTextBox.Text) & !String.IsNullOrEmpty(scearchPhoneTextBox.Text))
            {
                foreach (Person person in persons)
                {
                    if ((person.LastName == scearchLNameTextBox.Text) && (person.Email == scearchMailTextBox.Text) && (person.PhoneNo == Convert.ToInt64(scearchPhoneTextBox.Text)))
                    {
                        personList.Add(person);
                    }
                }
            }

            if (personList.Count == 0)
            {
                MessageBox.Show("Data not found!");
            }

            displayDataGridView.DataSource = null;
            displayDataGridView.DataSource = personList;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = null;
            displayDataGridView.DataSource = persons;
        }




        List<Person> peoples = new List<Person>();
        private void FindButton_Click(object sender, EventArgs e)
        {
            peoples = new List<Person>();
            
                foreach (Person person in persons)
                {
                    if (person.Email == editMailTextBox.Text)
                    {
                        //firstNameTextBox.Text = person.FirstName;
                        //lastNameTextBox.Text = person.LastName;
                        //mailTextBox.Text = person.Email;
                        //phoneTextBox.Text = person.PhoneNo.ToString();

                    peoples.Add(person);
                    }
                }
            

            if (peoples.Count == 0)
            {
                MessageBox.Show("Data not found!");
                SaveButton.Text = "Save";

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                mailTextBox.Text = "";
                phoneTextBox.Text = "";

            }
            //else
            //{
            //    SaveButton.Text = "Update";
            //}

            displayDataGridView.DataSource = null;
            displayDataGridView.DataSource = peoples;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //peoples = new List<Person>();

            foreach (Person person in peoples)
            {
                //if (person.Email == editMailTextBox.Text)
                //{
                    firstNameTextBox.Text = person.FirstName;
                    lastNameTextBox.Text = person.LastName;
                    mailTextBox.Text = person.Email;
                    phoneTextBox.Text = person.PhoneNo.ToString();

                    //peoples.Add(person);
                //}
            }


            if (peoples.Count == 0)
            {
                MessageBox.Show("Search first by email what you want to edit.");
                SaveButton.Text = "Save";

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                mailTextBox.Text = "";
                phoneTextBox.Text = "";

            }
            else
            {
                SaveButton.Text = "Update";
            }

            displayDataGridView.DataSource = null;
            displayDataGridView.DataSource = peoples;
        }
    }
}