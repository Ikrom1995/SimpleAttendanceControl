using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3821_ClassLibrary
{
    public class Student : Users
    {
        //additional parameter for the Student class
        //used for sorting purposes
        //later can be used to assign subjects to groups
        public Classes GroupName { get; set; }

        //constructor for the Student Class
        public Student(string firstName, string lastName, DateTime dob, Classes groupName)
        {
            FirstName = firstName;
            LastName = lastName;
            DoB = dob;
            GroupName = groupName;
            //making student access status OUT when created
            In_Out_Status = InOutStatus.Out;
            //setting usertype to student
            UserType = UserType.Student;
        }

    }

}
