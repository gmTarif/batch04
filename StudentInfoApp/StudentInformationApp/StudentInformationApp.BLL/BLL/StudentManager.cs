using StudentInformationApp.Models.Models;
using StudentInformationApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationApp.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();

        public int InsertStudent(Student student)
        {
            return _studentRepository.InsertStudent(student);
        }

        public DataTable DisplayStudent()
        {
            return _studentRepository.DisplayStudent();
        }

        public DataTable SearchStudent(Student student)
        {
            return _studentRepository.SearchStudent(student);
        }

        public int DeleteStudent(Student student)
        {
            return _studentRepository.DeleteStudent(student);
        }

        public int UpdateStudent(Student student)
        {
            return _studentRepository.UpdateStudent(student);
        }
        
        //Validation...
        public bool IdValidation(Student student)
        {
            return _studentRepository.IdValidation(student);
        }

        public bool RollValidation(Student student)
        {
            return _studentRepository.RollValidation(student);
        }

        public bool EmailValidation(Student student)
        {
            return _studentRepository.EmailValidation(student);
        }
    }
}
