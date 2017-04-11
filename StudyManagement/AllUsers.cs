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
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        public void RefreshUsers()
        {
            dgvAllUsers.SuspendLayout();
            usersBindingSource.SuspendBinding();
            usersBindingSource.DataSource = EduManagement.Instance.Users;
            dgvAllUsers.DataSource = null;
            dgvAllUsers.DataSource = usersBindingSource;
            usersBindingSource.ResumeBinding();
            dgvAllUsers.ResumeLayout();
            ColorRows();
        }

        private void AllUsers_Activated(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        //colors datagridview row if a given parameter is true
        //called in refresh function, so will be activated everytime refresh is called
        public void ColorRows()
        {
            foreach (DataGridViewRow row in dgvAllUsers.Rows)
            {
                UserType aStatus = (UserType)row.Cells[5].Value;

                if (aStatus == UserType.Student)
                {
                    row.DefaultCellStyle.BackColor = Color.LawnGreen;
                }
                else if (aStatus == UserType.Teacher)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }
    }
}
