using CW_3821_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagement
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            //calling method that populates edumanagement
            EduManagement.Instance.PopulateEduManagementTest();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allSwipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSwipes form = new AllSwipes();
            form.Show();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers form = new AllUsers();
            form.Show();
        }

        private void allClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllClasses form = new AllClasses();
            form.Show();
        }


        private void addStudentMenu_Click(object sender, EventArgs e)
        {
            //add student form requires specil parameters to be called
            //NewStudent form constructor requires Student, User and boolean variable
            //As a student is a subclass of the User, it might be used instead of the user
            //student class requires a Classes class
            //thus Classes is also created here
            Classes group = EduManagement.Instance.Classes.ElementAt(0);
            Student newStudent = new Student(string.Empty, string.Empty, DateTime.Now, group);
            NewStudent form = new NewStudent(newStudent, newStudent, true);
            form.Show();
        }

        private void AllStudents(object sender, EventArgs e)
        {
            AllStudents form = new AllStudents();
            form.Show();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllAttendanceSwipes form = new AllAttendanceSwipes();
            form.Show();
        }

        private void checkAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(string.Empty, string.Empty, DateTime.Now);
            Classes group = EduManagement.Instance.Classes.ElementAt(0);
            Student student = new Student(string.Empty, string.Empty, DateTime.Now, group);
            NewAttendance form = new NewAttendance(teacher, student, true);
            form.Show();
        }

        private void viewSwipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllAccessSwipes form = new AllAccessSwipes();
            form.Show();
        }

        private void addTeacherMenu_Click(object sender, EventArgs e)
        {
            Teacher newTeacher = new Teacher(string.Empty, string.Empty, DateTime.Now);
            NewTeacher form = new NewTeacher(newTeacher, newTeacher, true);
            form.Show();
        }

        private void allTeachersMenu_Click(object sender, EventArgs e)
        {
            AllTeachers form = new AllTeachers();
            form.Show();
        }

        private void newAccessSwipeMenu_Click(object sender, EventArgs e)
        {
            NewSwipe form = new NewSwipe();
            form.Show();
        }

        private void newClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClass form = new NewClass(new Classes(string.Empty), true);
            form.Show();
        }
    }
}
