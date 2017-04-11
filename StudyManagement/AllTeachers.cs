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
    public partial class AllTeachers : Form
    {
        public AllTeachers()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void AllTeachers_Load(object sender, EventArgs e)
        {
            RefreshTeachers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAllTeachers.SelectedRows.Count > 0)
            {
                //grab selected object
                Teacher currentTeacher = (Teacher)dgvAllTeachers.SelectedRows[0].DataBoundItem;
                //provided parameters will open an edit form for teacher
                //last parameter which is boolean is responsible for opening adding or editing form
                NewTeacher NewTeacherForm = new NewTeacher(currentTeacher, currentTeacher, false);
                NewTeacherForm.Show();
            }
        }

        private void NewTeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshTeachers();
        }

        public void RefreshTeachers()
        {
            dgvAllTeachers.SuspendLayout();
            teacherBindingSource.SuspendBinding();
            teacherBindingSource.DataSource = EduManagement.Instance.Teachers;
            dgvAllTeachers.DataSource = null;
            dgvAllTeachers.DataSource = teacherBindingSource;
            teacherBindingSource.ResumeBinding();
            dgvAllTeachers.ResumeLayout();
            ColorRows();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAllTeachers.SelectedRows.Count > 0)
            {
                // first, ask for confirmation
                DialogResult result = MessageBox.Show("Do you really want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //grab selected object
                    Teacher currentTeacher = (Teacher)dgvAllTeachers.SelectedRows[0].DataBoundItem;
                    //remove from collection
                    EduManagement.Instance.Teachers.Remove(currentTeacher);
                    EduManagement.Instance.Users.Remove(currentTeacher);
                    RefreshTeachers();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTeachers();
        }

        private void AllTeachers_Activated(object sender, EventArgs e)
        {
            RefreshTeachers();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher newTeacher = new Teacher(string.Empty, string.Empty, DateTime.Now);
            NewTeacher NewTeacherForm = new NewTeacher(newTeacher, newTeacher, true);
            NewTeacherForm.Show();
            NewTeacherForm.FormClosed += NewTeacherForm_FormClosed;
        }

        public void ColorRows()
        {
            foreach (DataGridViewRow row in dgvAllTeachers.Rows)
            {
                UserType aStatus = (UserType)row.Cells[5].Value;

                if (aStatus == UserType.Teacher)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }
    }
}
