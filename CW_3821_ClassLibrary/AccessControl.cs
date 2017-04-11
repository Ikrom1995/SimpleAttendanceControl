using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3821_ClassLibrary
{
    //extending Controlling class and inherits its parameters and methods
    public class AccessControl : Controlling
    {
        //additional parameter for the access control
        //used to change user access status
        public InOutStatus Status { get; set; }      

        public AccessControl(Users user, InOutStatus status)
        {
            User = user;
            //userID = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Status = status;
            SwipeTime = DateTime.Now;
            swipeType = SwipeType.Access;
            userType = user.UserType;
        }
    }

}
