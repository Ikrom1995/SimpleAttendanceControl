using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3821_ClassLibrary
{
    public class Users
    {
        //creating paraeters for Users Class
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DoB { get; set; }

        public InOutStatus In_Out_Status { get; set; }

        public UserType UserType { get; set; }

        //overriding ToString() in order to return only ID of the user
        //nedded when a Users Class user as a parameter of another class
        public override string ToString()
        {
            return Id.ToString();
        }

        //NO CONSTRUCTOR FOR THIS CLASS IS CREATED AS ONLY TEACHER AND STUDENT WILL BE CREATED
        //THERE IS NO NEED TO CREATE A USERS CLASS

    }
    //enum for access status
    public enum InOutStatus
    {
        In = 1,
        Out = 2
    }
    //enum for type f the user
    public enum UserType
    {
        Student = 1,
        Teacher = 2
    }
}
