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
    public partial class AllClasses : Form
    {
        public AllClasses()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void AllClasses_Load(object sender, EventArgs e)
        {
            RefreshClasses();
        }

        public void RefreshClasses()
        {
            dgvAllClassess.SuspendLayout();
            classesBindingSource.SuspendBinding();
            classesBindingSource.DataSource = EduManagement.Instance.Classes;
            dgvAllClassess.DataSource = null;
            dgvAllClassess.DataSource = classesBindingSource;
            classesBindingSource.ResumeBinding();
            dgvAllClassess.ResumeLayout();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Classes newClass = new Classes(string.Empty);
            NewClass NewClassForm = new NewClass(newClass, true);
            NewClassForm.Show();
            NewClassForm.FormClosed += NewClassForm_FormClosed;
        }

        private void NewClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshClasses();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAllClassess.SelectedRows.Count > 0)
            {
                //grab selected object
                Classes currentGroup = (Classes)dgvAllClassess.SelectedRows[0].DataBoundItem;
                NewClass NewClassForm = new NewClass(currentGroup, false);
                NewClassForm.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAllClassess.SelectedRows.Count > 0)
            {
                // first, ask for confirmation
                DialogResult result = MessageBox.Show("Do you really want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //grab selected object
                    Classes currentGroup = (Classes)dgvAllClassess.SelectedRows[0].DataBoundItem;
                    //remove from collection
                    EduManagement.Instance.Classes.Remove(currentGroup);
                    RefreshClasses();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshClasses();
        }

        private void AllClasses_Activated(object sender, EventArgs e)
        {
            RefreshClasses();
        }
    }
}
