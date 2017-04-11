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
    public partial class NewTeacher : Form
    {

        private Teacher _teacher { get; set; }

        private bool isNew { get; set; }

        public NewTeacher(Teacher teacher, Users user, bool New)
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];

            isNew = New;
            _teacher = teacher;

            //set form text
            if (isNew)
            {
                this.Text = "New Teacher";
            }
            else
            {
                this.Text = "Edit Teacher";
            }

            //display object
            if (!isNew)
            {
                //ShowDefaultValues();
                ShowDataFromForm();
            }
        }

        private void GetDataFromForm()
        {
            _teacher.FirstName = tbxName.Text;
            _teacher.LastName = tbxLastName.Text;
            _teacher.DoB = dtpDoB.Value.Date;
        }

        private void ShowDataFromForm()
        {
            tbxName.Text = _teacher.FirstName;
            tbxLastName.Text = _teacher.LastName;
            dtpDoB.Value = _teacher.DoB.Date;
        }

        private void Save()
        {
            //gets data from the form
            GetDataFromForm();
            //if boolean passed is true than adds a new
            //if not just edits and saves
            if (isNew)
            {
                EduManagement.Instance.AddUser(_teacher);
                EduManagement.Instance.AddTeacher(_teacher);
            }
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
