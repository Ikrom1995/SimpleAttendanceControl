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
    public partial class AllAccessSwipes : Form
    {
        public AllAccessSwipes()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void AllAccessSwipes_Load(object sender, EventArgs e)
        {
            RefreshSwipes();
        }

        public void RefreshSwipes()
        {
            dgvAllAccessSwipes.SuspendLayout();
            accessControlBindingSource.SuspendBinding();
            accessControlBindingSource.DataSource = EduManagement.Instance.AccessControlling;
            dgvAllAccessSwipes.DataSource = null;
            dgvAllAccessSwipes.DataSource = accessControlBindingSource;
            accessControlBindingSource.ResumeBinding();
            dgvAllAccessSwipes.ResumeLayout();
            ColorRows();
        }

        private void AllAccessSwipes_Activated(object sender, EventArgs e)
        {
            RefreshSwipes();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshSwipes();
            rdbAll.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewSwipe form = new NewSwipe();
            form.Show();
        }

        //method that is used to filter datagridview
        public void filterByStatus()
        {
            if (rdbAll.Checked)
            {
                RefreshSwipes();
            }
            else if (rdbIn.Checked)
            {
                dgvAllAccessSwipes.SuspendLayout();
                accessControlBindingSource.SuspendBinding();
                accessControlBindingSource.DataSource = EduManagement.Instance.filterAccess(InOutStatus.In);
                dgvAllAccessSwipes.DataSource = null;
                dgvAllAccessSwipes.DataSource = accessControlBindingSource;
                accessControlBindingSource.ResumeBinding();
                dgvAllAccessSwipes.ResumeLayout();
                ColorRows();
            }
            else if (rdbOut.Checked)
            {
                dgvAllAccessSwipes.SuspendLayout();
                accessControlBindingSource.SuspendBinding();
                accessControlBindingSource.DataSource = EduManagement.Instance.filterAccess(InOutStatus.Out);
                dgvAllAccessSwipes.DataSource = null;
                dgvAllAccessSwipes.DataSource = accessControlBindingSource;
                accessControlBindingSource.ResumeBinding();
                dgvAllAccessSwipes.ResumeLayout();
                ColorRows();
            }
        }

        private void rdbIn_CheckedChanged(object sender, EventArgs e)
        {
            filterByStatus();
            ColorRows();
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            filterByStatus();
            ColorRows();
        }

        private void rdbOut_CheckedChanged(object sender, EventArgs e)
        {
            filterByStatus();
            ColorRows();
        }

        //method that sorts datagridview
        //can be applied with filtering as well
        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSort.Text == "Ascending")
            {
                if (rdbAll.Checked)
                {
                    dgvAllAccessSwipes.SuspendLayout();
                    accessControlBindingSource.SuspendBinding();
                    accessControlBindingSource.DataSource = EduManagement.Instance.sortAccessAscending();
                    dgvAllAccessSwipes.DataSource = null;
                    dgvAllAccessSwipes.DataSource = accessControlBindingSource;
                    accessControlBindingSource.ResumeBinding();
                    dgvAllAccessSwipes.ResumeLayout();
                    ColorRows();
                }
                else if (rdbIn.Checked)
                {
                    dgvAllAccessSwipes.SuspendLayout();
                    accessControlBindingSource.SuspendBinding();
                    accessControlBindingSource.DataSource = EduManagement.Instance.filterAccessIn();
                    dgvAllAccessSwipes.DataSource = null;
                    dgvAllAccessSwipes.DataSource = accessControlBindingSource;
                    accessControlBindingSource.ResumeBinding();
                    dgvAllAccessSwipes.ResumeLayout();
                    ColorRows();
                }
                else if (rdbOut.Checked)
                {
                    dgvAllAccessSwipes.SuspendLayout();
                    accessControlBindingSource.SuspendBinding();
                    accessControlBindingSource.DataSource = EduManagement.Instance.filterAccessOut();
                    dgvAllAccessSwipes.DataSource = null;
                    dgvAllAccessSwipes.DataSource = accessControlBindingSource;
                    accessControlBindingSource.ResumeBinding();
                    dgvAllAccessSwipes.ResumeLayout();
                    ColorRows();
                }

            }
            else if (cbxSort.Text == "Descending")
            {
                if (rdbAll.Checked)
                {
                    dgvAllAccessSwipes.SuspendLayout();
                    accessControlBindingSource.SuspendBinding();
                    accessControlBindingSource.DataSource = EduManagement.Instance.sortAccessDesc();
                    dgvAllAccessSwipes.DataSource = null;
                    dgvAllAccessSwipes.DataSource = accessControlBindingSource;
                    accessControlBindingSource.ResumeBinding();
                    dgvAllAccessSwipes.ResumeLayout();
                    ColorRows();
                }
                else if (rdbIn.Checked)
                {
                    dgvAllAccessSwipes.SuspendLayout();
                    accessControlBindingSource.SuspendBinding();
                    accessControlBindingSource.DataSource = EduManagement.Instance.filterAccessInDesc();
                    dgvAllAccessSwipes.DataSource = null;
                    dgvAllAccessSwipes.DataSource = accessControlBindingSource;
                    accessControlBindingSource.ResumeBinding();
                    dgvAllAccessSwipes.ResumeLayout();
                    ColorRows();
                }
                else if (rdbOut.Checked)
                {
                    dgvAllAccessSwipes.SuspendLayout();
                    accessControlBindingSource.SuspendBinding();
                    accessControlBindingSource.DataSource = EduManagement.Instance.filterAccessOutDesc();
                    dgvAllAccessSwipes.DataSource = null;
                    dgvAllAccessSwipes.DataSource = accessControlBindingSource;
                    accessControlBindingSource.ResumeBinding();
                    dgvAllAccessSwipes.ResumeLayout();
                    ColorRows();
                }
            }
        }

        public void ColorRows()
        {
            foreach (DataGridViewRow row in dgvAllAccessSwipes.Rows)
            {
                InOutStatus status = (InOutStatus)row.Cells[3].Value;

                if (status == InOutStatus.In)
                {
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                else if (status == InOutStatus.Out)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }
    }
}
