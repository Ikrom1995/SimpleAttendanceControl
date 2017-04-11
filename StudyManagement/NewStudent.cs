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
    public partial class NewStudent : Form
    {

        private Student _student { get; set; }

        private bool isNew { get; set; }
        //constructor for the form
        public NewStudent(Student student, Users user, bool New)
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];

            isNew = New;
            _student = student;

            //set form text
            if (isNew)
            {
                this.Text = "New Student";
            }
            else
            {
                this.Text = "Edit Student";
            }

            if (!isNew)
            {
                ShowDataFromForm();
            }
        }

        //gets data from form
        private void GetDataFromForm()
        {
            _student.FirstName = tbxFirstName.Text;
            _student.LastName = tbxLastName.Text;
            _student.DoB = dtpDoB.Value.Date;
            _student.GroupName = (Classes)cbxGroup.SelectedItem;
        }

        //shows data to the form
        //used in editing
        private void ShowDataFromForm()
        {
            tbxFirstName.Text = _student.FirstName;
            tbxLastName.Text = _student.LastName;
            dtpDoB.Value = _student.DoB.Date;
            cbxGroup.DisplayMember = _student.GroupName.ClassName;
        }

        private void Save()
        {
            //adds and saves if boolean is true
            //edits and saves if boolean is false
            GetDataFromForm();
            if (isNew)
            {
                EduManagement.Instance.AddUser(_student);
                EduManagement.Instance.AddStudent(_student);
            }
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            cbxGroup.DataSource = EduManagement.Instance.Classes;
        }
    }
}
