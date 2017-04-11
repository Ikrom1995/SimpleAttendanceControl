using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3821_ClassLibrary
{
    //extending Users Class, thus inheriting parameters and methods
    public class Teacher : Users
    {
        //following method created in order to display ID, firstname and lastname in comboboxes for attendance
        public string FullName
        {
            get
            {
                return $"{Id}. {FirstName} {LastName}";
            }
        }

        //construtor for the Teacher Class
        public Teacher(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DoB = dob;
            //when created teacher will have Out (out of the university/school) status
            In_Out_Status = InOutStatus.Out;
            //setting type of the user in teacher
            UserType = UserType.Teacher;
        }

    }

}
