using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3821_ClassLibrary
{
    public class Controlling
    {

        public DateTime SwipeTime { get; set; }

        public SwipeType swipeType { get; set; }

        public Users User { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public UserType userType { get; set; }

        //method that changes User access status from IN to OUT and vice versa
        //helps to make the access swipes more automdated
        public void Swipe(Users user)
        {
            if (user.In_Out_Status == InOutStatus.Out)
            {
                user.In_Out_Status = InOutStatus.In;
            }
            else if (user.In_Out_Status == InOutStatus.In)
            {
                user.In_Out_Status = InOutStatus.Out;
            }

        }

    }
    //enum for type of swipe
    public enum SwipeType
    {
        Access = 1,
        Attendance = 2
    }
}
