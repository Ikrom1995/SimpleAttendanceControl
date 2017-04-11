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
    public partial class NewClass : Form
    {

        private Classes _groupName { get; set; }

        private bool isNew { get; set; }

        public NewClass(Classes group, bool New)
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];

            isNew = New;
            _groupName = group;

            if (isNew)
            {
                this.Text = "New Class";
            }
            else
            {
                this.Text = "Edit Class";
            }

            //display object
            if (!isNew)
            {
                ShowDataFromForm();
            }
        }

        private void GetDataFromForm()
        {
            _groupName.ClassName = tbxClassName.Text;
        }

        private void ShowDataFromForm()
        {
            tbxClassName.Text = _groupName.ClassName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save()
        {
            GetDataFromForm();
            if (isNew)
            {
                EduManagement.Instance.AddClass(_groupName);
            }
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
