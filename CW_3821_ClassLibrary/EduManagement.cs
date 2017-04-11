using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_3821_ClassLibrary
{
    public class EduManagement
    {
        //creating list of all classess that will store data
        public List<Users> Users { get; set; }

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Controlling> Controlling { get; set; }

        public List<Classes> Classes { get; set; }

        public List<AttandanceControl> AttandanceControlling { get; set; }

        public List<AccessControl> AccessControlling { get; set; }

        //creating static instance of the eduManagement class
        private static EduManagement _eduManagement;

        //constructor
        private EduManagement()
        {
            Users = new List<Users>();
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            Controlling = new List<Controlling>();
            Classes = new List<Classes>();
            AttandanceControlling = new List<AttandanceControl>();
            AccessControlling = new List<AccessControl>();
        }

        //static method that is used to access single instance of the eduManagement class
        public static EduManagement Instance
        {
            get
            {
                if (_eduManagement == null)
                    _eduManagement = new EduManagement();
                return _eduManagement;
            }
        }

        
        #region "Add Objects"
        //userID is taken out of the classess, this allows to create ID for all users
        //for example if the first user is teacher his/her id = 1
        //if the second user is student his/her id = 2
        //so ID's of user are unique
        int userID;
        /// <param name="student">new Student object</param>
        public void AddStudent(Student student)
        {
            if (student.Id < 1)
            {
                userID = 0;
                foreach (Student item in Students)
                {
                    if (item.Id > userID)
                        userID = item.Id;
                }
                student.Id = userID + 1; //// +1 to the max existing ID
            }
            Students.Add(student);
        }

        /// <param name="teacher">new Teacher object</param>
        public void AddTeacher(Teacher teacher)
        {
            if (teacher.Id < 1)
            {
                //// the ID to assign to UserType
                //int maxID = 0;
                userID = 0;
                foreach (Teacher item in Teachers)
                {
                    if (item.Id > userID)
                        userID = item.Id;
                }
                teacher.Id = userID + 1; //// +1 to the max existing ID
            }
            Teachers.Add(teacher);
        }

        public void AddUser(Users user)
        {
            if (user.Id < 1)
            {
                userID = 0;
                foreach (Users item in Users)
                {
                    if (item.Id > userID)
                        userID = item.Id;
                }
                user.Id = userID + 1; //// +1 to the max existing ID
            }
            Users.Add(user);
        }

        public void AddClass(Classes newClass)
        {
            int classID;
            if (newClass.Id < 1)
            {
                classID = 0;
                foreach (Classes item in Classes)
                {
                    if (item.Id > classID)
                        classID = item.Id;
                }
                newClass.Id = classID + 1; //// +1 to the max existing ID
            }
            Classes.Add(newClass);
        }

        #endregion

        #region "Adding Methods"
        public void AddSwipe(AccessControl control)
        {
            AccessControlling.Add(control);
        }

        public void AddAttendanceSwipe(AttandanceControl control)
        {
            AttandanceControlling.Add(control);
        }

        public void AddControlling(Controlling control)
        {
            Controlling.Add(control);
        }
        #endregion

        #region "Filter Methods"
        //in this region the return list for the datagridviews will be changed
        //based on the parameters given
        //"Where" is used to filter return list
        //"Sort" is used to sort return list
        public List<Student> GetStudentsInClassNew(Classes group)
        {
            return Students.Where(c => c.GroupName == group).ToList();
        }

        public List<AttandanceControl> FilterAttendance(Teacher teacher, Classes group, DateTime date, int time)
        {
            return AttandanceControlling.Where(c => c.Teacher == teacher && 
                                                    c.Group == group &&
                                                    c.SwipeTime.Date == date.Date &&
                                                    c.SwipeTime.Hour == time).ToList();
        }

        public List<AttandanceControl> GetUserAttendance(Users student, AccessControl ac)
        {
            return AttandanceControlling.Where(c => c.Student.Id == student.Id &&
                                                    c.Student.UserType == UserType.Student &&
                                                    c.SwipeTime.Date == ac.SwipeTime.Date).ToList();
        }

        public List<AccessControl> sortAccessAscending()
        {
            AccessControlling.Sort((x, y) => DateTime.Compare(x.SwipeTime, y.SwipeTime));
            return AccessControlling;
        }

        public List<AccessControl> sortAccessDesc()
        {
            AccessControlling.Sort((x, y) => DateTime.Compare(y.SwipeTime, x.SwipeTime));
            return AccessControlling;
        }

        public List<AccessControl> filterAccess(InOutStatus st)
        {
            return AccessControlling.Where(c => c.Status == st).ToList();
        }

        public List<AccessControl> filterAccessIn()
        {
            List<AccessControl> ls = AccessControlling.Where(c => c.Status == InOutStatus.In).ToList();

            ls.Sort((x, y) => DateTime.Compare(x.SwipeTime, y.SwipeTime));
            return ls;
        }

        public List<AccessControl> filterAccessOut()
        {
            List<AccessControl> ls = AccessControlling.Where(c => c.Status == InOutStatus.Out).ToList();

            ls.Sort((x, y) => DateTime.Compare(x.SwipeTime, y.SwipeTime));
            return ls;
        }

        public List<AccessControl> filterAccessInDesc()
        {
            List<AccessControl> ls = AccessControlling.Where(c => c.Status == InOutStatus.In).ToList();

            ls.Sort((x, y) => DateTime.Compare(y.SwipeTime, x.SwipeTime));
            return ls;
        }

        public List<AccessControl> filterAccessOutDesc()
        {
            List<AccessControl> ls = AccessControlling.Where(c => c.Status == InOutStatus.Out).ToList();

            ls.Sort((x, y) => DateTime.Compare(y.SwipeTime, x.SwipeTime));
            return ls;
        }
        #endregion


        #region "Populate data"
        public void PopulateEduManagementTest()
        {
            //instantiating edumanagement and adding data
            EduManagement lb = EduManagement.Instance;

            Classes class1 = new Classes("Group 1");
            lb.AddClass(class1);

            Classes class2 = new Classes("Group 2");
            lb.AddClass(class2);

            Teacher user1 = new Teacher("Albus", "Dumbledore", new DateTime(1896, 2, 2));
            lb.AddUser(user1);
            lb.AddTeacher(user1);

            Teacher user2 = new Teacher("Severus", "Snape", new DateTime(1986, 2, 2));
            lb.AddUser(user2);
            lb.AddTeacher(user2);

            Student user3 = new Student("Harry", "Potter", new DateTime(1990, 2, 2), class1);
            lb.AddUser(user3);
            lb.AddStudent(user3);

            Student user4 = new Student("Ron", "Weasley", new DateTime(1991, 2, 2), class1);
            lb.AddUser(user4);
            lb.AddStudent(user4);

            Student user5 = new Student("Hermione", "Granger", new DateTime(1992, 2, 2), class1);
            lb.AddUser(user5);
            lb.AddStudent(user5);

            Student user6 = new Student("Fleur", "Delacour", new DateTime(1993, 2, 2), class1);
            lb.AddUser(user6);
            lb.AddStudent(user6);

            Student user7 = new Student("Cornelius", "Fudge", new DateTime(1994, 2, 2), class1);
            lb.AddUser(user7);
            lb.AddStudent(user7);

            Student user8 = new Student("Sirius", "Black", new DateTime(1995, 2, 2), class2);
            lb.AddUser(user8);
            lb.AddStudent(user8);

            Student user9 = new Student("Igor", "Karkaroff", new DateTime(1996, 2, 2), class2);
            lb.AddUser(user9);
            lb.AddStudent(user9);

            Student user10 = new Student("Viktor", "Krum", new DateTime(1997, 2, 2), class2);
            lb.AddUser(user10);
            lb.AddStudent(user10);

            Student user11 = new Student("Bellatrix", "Lestrange", new DateTime(1998, 2, 2), class2);
            lb.AddUser(user11);
            lb.AddStudent(user11);

            Student user12 = new Student("Remus", "Lupin", new DateTime(1999, 2, 2), class2);
            lb.AddUser(user12);
            lb.AddStudent(user12);

            //access control is created
            AccessControl a1 = new AccessControl(user1, user1.In_Out_Status);
            //access control has Swipe method that changes access status of the user
            a1.Swipe(user1);
            //reassigning created access control with th new access status of the user
            a1 = new AccessControl(user1, user1.In_Out_Status);
            a1.SwipeTime = new DateTime(2015, 02, 15);
            lb.AddSwipe(a1);
            lb.AddControlling(a1);

            AccessControl a2 = new AccessControl(user1, user1.In_Out_Status);
            a2.Swipe(user1);
            a2 = new AccessControl(user1, user1.In_Out_Status);
            lb.AddSwipe(a2);
            lb.AddControlling(a2);

            AccessControl a3 = new AccessControl(user2, user2.In_Out_Status);
            a3.Swipe(user2);
            a3 = new AccessControl(user2, user2.In_Out_Status);
            a3.SwipeTime = new DateTime(2017, 02, 27);
            lb.AddSwipe(a3);
            lb.AddControlling(a3);

            AccessControl a4 = new AccessControl(user2, user2.In_Out_Status);
            a4.Swipe(user2);
            a4 = new AccessControl(user2, user2.In_Out_Status);
            lb.AddSwipe(a4);
            lb.AddControlling(a4);

            AccessControl a5 = new AccessControl(user3, user3.In_Out_Status);
            a5.Swipe(user3);
            a5 = new AccessControl(user3, user3.In_Out_Status);
            a5.SwipeTime = new DateTime(2017, 02, 26);
            lb.AddSwipe(a5);
            lb.AddControlling(a5);

            AccessControl a6 = new AccessControl(user3, user3.In_Out_Status);
            a6.Swipe(user3);
            a6 = new AccessControl(user3, user3.In_Out_Status);
            lb.AddSwipe(a6);
            lb.AddControlling(a6);

            AccessControl a7 = new AccessControl(user4, user4.In_Out_Status);
            a7.Swipe(user4);
            a7 = new AccessControl(user4, user4.In_Out_Status);
            a7.SwipeTime = new DateTime(2017, 02, 26);
            lb.AddSwipe(a7);
            lb.AddControlling(a7);

            AccessControl a8 = new AccessControl(user4, user4.In_Out_Status);
            a8.Swipe(user4);
            a8 = new AccessControl(user4, user4.In_Out_Status);
            lb.AddSwipe(a8);
            lb.AddControlling(a8);

            AccessControl a9 = new AccessControl(user5, user5.In_Out_Status);
            a9.Swipe(user5);
            a9 = new AccessControl(user5, user5.In_Out_Status);
            a9.SwipeTime = new DateTime(2017, 02, 27);
            lb.AddSwipe(a9);
            lb.AddControlling(a9);

            AccessControl a10 = new AccessControl(user5, user5.In_Out_Status);
            a10.Swipe(user5);
            a10 = new AccessControl(user5, user5.In_Out_Status);
            lb.AddSwipe(a10);
            lb.AddControlling(a10);

            AccessControl a11 = new AccessControl(user6, user6.In_Out_Status);
            a11.Swipe(user6);
            a11 = new AccessControl(user6, user6.In_Out_Status);
            a11.SwipeTime = new DateTime(2017, 02, 28);
            lb.AddSwipe(a11);
            lb.AddControlling(a11);

            AccessControl a12 = new AccessControl(user6, user6.In_Out_Status);
            a12.Swipe(user6);
            a12 = new AccessControl(user6, user6.In_Out_Status);
            lb.AddSwipe(a12);
            lb.AddControlling(a12);

            AttandanceControl a13 = new AttandanceControl(user1, user3);
            a13.AStatus = AttendanceStatus.Attended;
            lb.AddAttendanceSwipe(a13);
            lb.AddControlling(a13);

            AttandanceControl a14 = new AttandanceControl(user1, user4);
            a14.AStatus = AttendanceStatus.Attended;
            lb.AddAttendanceSwipe(a14);
            lb.AddControlling(a14);

            AttandanceControl a15 = new AttandanceControl(user1, user5);
            a15.AStatus = AttendanceStatus.Attended;
            lb.AddAttendanceSwipe(a15);
            lb.AddControlling(a15);

            AttandanceControl a16 = new AttandanceControl(user2, user5);
            lb.AddAttendanceSwipe(a16);
            lb.AddControlling(a16);

            AttandanceControl a17 = new AttandanceControl(user1, user5);
            lb.AddAttendanceSwipe(a17);
            lb.AddControlling(a17);

            AttandanceControl a18 = new AttandanceControl(user2, user5);
            a18.AStatus = AttendanceStatus.Attended;
            lb.AddAttendanceSwipe(a18);
            lb.AddControlling(a18);

            AttandanceControl a19 = new AttandanceControl(user1, user6);
            lb.AddAttendanceSwipe(a19);
            lb.AddControlling(a19);

            AttandanceControl a20 = new AttandanceControl(user1, user6);
            a20.AStatus = AttendanceStatus.Attended;
            lb.AddAttendanceSwipe(a20);
            lb.AddControlling(a20);

        }
        #endregion

    }
}
