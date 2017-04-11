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
    public partial class AllAttendanceSwipes : Form
    {
        public AllAttendanceSwipes()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void AllAttendanceSwipes_Load(object sender, EventArgs e)
        {
            RefreshAttendance();
            cbxTeacher.DataSource = EduManagement.Instance.Teachers;
            cbxTeacher.DisplayMember = "FullName";
            cbxGroup.DataSource = EduManagement.Instance.Classes;
        }

        public void RefreshAttendance()
        {
            dgvAttendance.SuspendLayout();
            attandanceControlBindingSource.SuspendBinding();
            attandanceControlBindingSource.DataSource = EduManagement.Instance.AttandanceControlling;
            dgvAttendance.DataSource = null;
            dgvAttendance.DataSource = attandanceControlBindingSource;
            attandanceControlBindingSource.ResumeBinding();
            dgvAttendance.ResumeLayout();
            ColorRows();
        }

        private void AllAttendanceSwipes_Activated(object sender, EventArgs e)
        {
            RefreshAttendance();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(string.Empty, string.Empty, DateTime.Now);
            Classes group = EduManagement.Instance.Classes.ElementAt(0);
            Student student = new Student(string.Empty, string.Empty, DateTime.Now, group);
            NewAttendance NewAttendanceForm = new NewAttendance(teacher, student, true);
            NewAttendanceForm.Show();
            NewAttendanceForm.FormClosed += NewAttendanceForm_FormClosed;
        }

        private void NewAttendanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshAttendance();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAttendance();
        }

        //changes attendance status of in selected row
        //also changes the teacher id which make a student attended
        //as well as this date time when student was checked changes
        //THERE IS NO NEED TO OPEN EDIT FORM AS STUDENT MAY ASK TO CHANGE
        //ATTENDANCE STATUS ONLY IF HE WAS ABSENT
        //THUS WHEN CLICKING BUTTON IT WILL JUST CHANGE STATUS TO ATTENDED
        private void btnAttended_Click(object sender, EventArgs e)
        {
            dgvAttendance.SelectedCells[7].Value = cbxTeacher.SelectedItem;
            dgvAttendance.SelectedCells[5].Value = AttendanceStatus.Attended;
            dgvAttendance.SelectedCells[6].Value = DateTime.Now;
            RefreshAttendance();
        }

        //filters datagridview by parameters chosen
        //BEFORE FILTERING ALL PARAMETERS HAVE TO BE PROVIDED
        private void btnFilter_Click(object sender, EventArgs e)
        {
            Teacher teacher = (Teacher)cbxTeacher.SelectedItem;
            Classes group = (Classes)cbxGroup.SelectedItem;
            DateTime date = dtpDate.Value.Date;
            int time = int.Parse(cbxTime.Text);
            dgvAttendance.SuspendLayout();
            attandanceControlBindingSource.SuspendBinding();
            attandanceControlBindingSource.DataSource = EduManagement.Instance.FilterAttendance(teacher, group, date, time);
            dgvAttendance.DataSource = null;
            dgvAttendance.DataSource = attandanceControlBindingSource;
            attandanceControlBindingSource.ResumeBinding();
            dgvAttendance.ResumeLayout();
            ColorRows();
        }

        public void ColorRows()
        {
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                AttendanceStatus aStatus = (AttendanceStatus)row.Cells[5].Value;

                if (aStatus == AttendanceStatus.Attended)
                {
                    row.DefaultCellStyle.BackColor = Color.LawnGreen;
                }
                else if (aStatus == AttendanceStatus.Absent)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

    }
}
