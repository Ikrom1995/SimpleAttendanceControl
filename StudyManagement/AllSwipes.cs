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
    public partial class AllSwipes : Form
    {
        public AllSwipes()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void AllSwipes_Load(object sender, EventArgs e)
        {
            RefreshData();
            ColorRows();

        }
        //method which will show the attendance of the user by the date
        //of selected accesscontrol swipe of the user
        //for example
        //LETS ASSUNE THAT USER1 ENTRED A UBIVERSITY IN 02.02.2017 AND ATTNDED 2 SUBJECTS AND WAS ABSENT IN 1
        //IF THE USER IN THIS CASE WILL SELECT USER1 ACCESS SWIPE IN 02.02.2017 IT WILL SHOW ATTENDANCE OF THE USER
        // IN THIS PARTICULAR DATE
        private void dgvAllAccesses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Users student = (Users)dgvAllAccesses.SelectedCells[0].Value;
            AccessControl ac = (AccessControl)dgvAllAccesses.SelectedRows[0].DataBoundItem;
            dgvAllAttendance.SuspendLayout();
            attandanceControlBindingSource.SuspendBinding();
            attandanceControlBindingSource.DataSource = EduManagement.Instance.GetUserAttendance(student, ac);
            dgvAllAttendance.DataSource = null;
            dgvAllAttendance.DataSource = attandanceControlBindingSource;
            attandanceControlBindingSource.ResumeBinding();
            dgvAllAttendance.ResumeLayout();
        }

        public void ColorRows()
        {
            foreach (DataGridViewRow row in dgvAllSwipes.Rows)
            {
                SwipeType type = (SwipeType)row.Cells[5].Value;

                if (type == SwipeType.Access)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (type == SwipeType.Attendance)
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                }
            }
        }

        public void RefreshData()
        {
            dgvAllSwipes.SuspendLayout();
            controllingBindingSource.SuspendBinding();
            controllingBindingSource.DataSource = EduManagement.Instance.Controlling;
            dgvAllSwipes.DataSource = null;
            dgvAllSwipes.DataSource = controllingBindingSource;
            controllingBindingSource.ResumeBinding();
            dgvAllSwipes.ResumeLayout();
            ColorRows();

            dgvAllAccesses.SuspendLayout();
            accessControlBindingSource.SuspendBinding();
            accessControlBindingSource.DataSource = EduManagement.Instance.AccessControlling;
            dgvAllAccesses.DataSource = null;
            dgvAllAccesses.DataSource = accessControlBindingSource;
            accessControlBindingSource.ResumeBinding();
            dgvAllAccesses.ResumeLayout();

            dgvAllAttendance.SuspendLayout();
            attandanceControlBindingSource.SuspendBinding();
            attandanceControlBindingSource.DataSource = EduManagement.Instance.AttandanceControlling;
            dgvAllAttendance.DataSource = null;
            dgvAllAttendance.DataSource = attandanceControlBindingSource;
            attandanceControlBindingSource.ResumeBinding();
            dgvAllAttendance.ResumeLayout();
        }

        private void AllSwipes_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
