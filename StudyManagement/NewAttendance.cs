using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CW_3821_ClassLibrary;

namespace StudyManagement
{
    public partial class NewAttendance : Form
    {
        private AttandanceControl _attendance { get; set; }

        private Teacher _teacher { get; set; }

        private Student _student { get; set; }

        private bool isNew { get; set; }

        public NewAttendance(Teacher teacher, Student student, bool New)
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];

            isNew = New;
            _attendance = new AttandanceControl(teacher, student);
            _teacher = teacher;
            _student = student;

            //set form text
            if (isNew)
            {
                this.Text = "New Attendance";
            }
            else
            {
                this.Text = "Edit Attendance";
            }

        }

        private void NewAttendance_Load(object sender, EventArgs e)
        {
            //assigning data to datagridview and comboboxes
            RefreshStudents();
            cbxGroups.DataSource = EduManagement.Instance.Classes;
            //setting the displaymember of combobox to display ID + Fullname
            cbxTeachers.DisplayMember = "FullName";
            cbxTeachers.DataSource = EduManagement.Instance.Teachers;
        }

        //gets data from form
        //takes selected row as a studet object
        //takes combobox selected item as a teacher object
        public AttandanceControl GetDataFromForm()
        {
            Student student = (Student)dgvStudents.SelectedRows[0].DataBoundItem;
            Teacher teacher = (Teacher)cbxTeachers.SelectedItem;
            AttandanceControl t = new AttandanceControl(teacher, student);
            return t;
        }
        //refreshes datagridview
        public void RefreshStudents()
        {
            dgvStudents.SuspendLayout();
            studentBindingSource.SuspendBinding();
            //EduManagement.Instance. => the class indicated here will be displayed in the datagridview
            //datagridview GUI also have to be setted up properly 
            studentBindingSource.DataSource = EduManagement.Instance.Students;
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = studentBindingSource;
            studentBindingSource.ResumeBinding();
            dgvStudents.ResumeLayout();
        }

        private void NewAttendance_Activated(object sender, EventArgs e)
        {
            RefreshStudents();
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                AttandanceControl t = GetDataFromForm();
                t.AStatus = AttendanceStatus.Attended;
                EduManagement.Instance.AddAttendanceSwipe(t);
                EduManagement.Instance.AddControlling(t);
            }
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                AttandanceControl t = GetDataFromForm();
                t.AStatus = AttendanceStatus.Absent;
                EduManagement.Instance.AddAttendanceSwipe(t);
                EduManagement.Instance.AddControlling(t);
            }
        }

        //filtering by groups
        private void cbxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStudents.SuspendLayout();
            studentBindingSource.SuspendBinding();
            studentBindingSource.DataSource = EduManagement.Instance.GetStudentsInClassNew((Classes)cbxGroups.SelectedItem);
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = studentBindingSource;
            studentBindingSource.ResumeBinding();
            dgvStudents.ResumeLayout();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStudents();
        }

    }
}
