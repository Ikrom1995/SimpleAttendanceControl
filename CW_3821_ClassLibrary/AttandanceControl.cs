using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3821_ClassLibrary
{
    public class AttandanceControl : Controlling
    {
        //additional parameters for attendance control
        public Student Student { get; set; }

        public Teacher Teacher { get; set; }

        public Classes Group { get; set; }

        public InOutStatus Status { get; set; }

        public AttendanceStatus AStatus { get; set; }

        public AttandanceControl(Teacher teacher, Student student)
        {
            //indicates which tecaher made a swipe
            Teacher = teacher;
            //which student is swiped
            Student = student;
            FirstName = student.FirstName;
            LastName = student.LastName;
            //group of the student (used for filtering as well)
            Group = student.GroupName;
            //access status
            Status = student.In_Out_Status;
            //attendance status
            AStatus = AttendanceStatus.Absent;
            SwipeTime = DateTime.Now;
            //type of the swipe
            swipeType = SwipeType.Attendance;
            userType = student.UserType;
            User = student;
        }
        
    }
    
    public enum AttendanceStatus
    {
        Attended = 1,
        Absent = 2
    }
}
