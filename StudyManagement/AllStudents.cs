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
    public partial class AllStudents : Form
    {
        public AllStudents()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void AllStudents_Load(object sender, EventArgs e)
        {
            RefreshStudents();
        }

        public void RefreshStudents()
        {
            dgvAllStudents.SuspendLayout();
            studentBindingSource.SuspendBinding();
            studentBindingSource.DataSource = EduManagement.Instance.Students;
            dgvAllStudents.DataSource = null;
            dgvAllStudents.DataSource = studentBindingSource;
            studentBindingSource.ResumeBinding();
            dgvAllStudents.ResumeLayout();
            ColorRows();
        }

        private void AllStudents_Activated(object sender, EventArgs e)
        {
            RefreshStudents();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Classes group = EduManagement.Instance.Classes.ElementAt(0);
            Student newStudent = new Student(string.Empty, string.Empty, DateTime.Now, group);
            NewStudent NewStudentForm = new NewStudent(newStudent, newStudent, true);
            NewStudentForm.Show();
            NewStudentForm.FormClosed += NewStudentForm_FormClosed;
        }

        private void NewStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAllStudents.SelectedRows.Count > 0)
            {
                // first, ask for confirmation
                DialogResult result = MessageBox.Show("Do you really want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //grab selected object
                    Student currentStudent = (Student)dgvAllStudents.SelectedRows[0].DataBoundItem;
                    //remove from collection
                    EduManagement.Instance.Students.Remove(currentStudent);
                    EduManagement.Instance.Users.Remove(currentStudent);
                    RefreshStudents();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAllStudents.SelectedRows.Count > 0)
            {
                //grab selected object
                Student currentStudent = (Student)dgvAllStudents.SelectedRows[0].DataBoundItem;
                NewStudent NewStudentForm = new NewStudent(currentStudent, currentStudent, false);
                NewStudentForm.Show();
            }
        }

        public void ColorRows()
        {
            foreach (DataGridViewRow row in dgvAllStudents.Rows)
            {
                UserType aStatus = (UserType)row.Cells[6].Value;

                if (aStatus == UserType.Student)
                {
                    row.DefaultCellStyle.BackColor = Color.LawnGreen;
                }
            }
        }
    }
}
