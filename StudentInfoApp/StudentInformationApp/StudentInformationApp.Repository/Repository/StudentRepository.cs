using StudentInformationApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationApp.Repository.Repository
{
    public class StudentRepository
    {
        public StudentRepository()
        {
            sqlConnection = new SqlConnection(connectionString);
            //Student student = new Student();
        }

        //Connectivity...
        string connectionString = @"Server=TARIF-PC; Database=StudentMS; Integrated Security=true";
        SqlConnection sqlConnection;

        //Commanding...
        SqlCommand sqlCommand;

        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        private string commandString;

        public int InsertStudent(Student student)
        {
            //SQL Command...
            commandString = @"INSERT INTO Students VALUES(" + student.ID + ",'" + student.Name + "','" + student.Roll + "', " + student.Contact + ",'" + student.Email + "' )";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return isExecuted;
        }

        public DataTable DisplayStudent()
        {
            commandString = @"SELECT * FROM Students";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public DataTable SearchStudent(Student student)
        {
            if (!String.IsNullOrEmpty(student.Roll) || !String.IsNullOrEmpty(student.Name))
                commandString = @"SELECT * FROM Students WHERE Roll LIKE'%" + student.Roll + "%' OR Name LIKE'%" + student.Name + "%' ";

            sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public int DeleteStudent(Student student)
        {
            //SQL Command...
            commandString = @"DELETE FROM Students WHERE Sl =" + student.Sl + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return isExecuted;
        }

        public int UpdateStudent(Student student)
        {
            commandString = @"UPDATE Students SET ID=" + student.ID + ", Name='"+student.Name+"', Roll='"+student.Roll+ "', Contact="+student.Contact+", Email='"+student.Email+"' WHERE Sl="+student.Sl+" ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return isExecuted;
        }



        //Validation...
        public bool IdValidation(Student student)
        {
            bool isExist = false;
            string validationCommand = @"SELECT * FROM Students WHERE ID = " + student.ID + "";
            sqlCommand = new SqlCommand(validationCommand, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                isExist = true;
            }
            sqlConnection.Close();
            return isExist;
        }

        public bool RollValidation(Student student)
        {
            bool isExist = false;
            string validationCommand = @"SELECT * FROM Students WHERE Roll = '" + student.Roll + "'";
            sqlCommand = new SqlCommand(validationCommand, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                isExist = true;
            }
            sqlConnection.Close();
            return isExist;
        }

        public bool EmailValidation(Student student)
        {
            bool isExist = false;
            string validationCommand = @"SELECT * FROM Students WHERE Email = '" + student.Email + "'";
            sqlCommand = new SqlCommand(validationCommand, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                isExist = true;
            }
            sqlConnection.Close();
            return isExist;
        }
    }
}
