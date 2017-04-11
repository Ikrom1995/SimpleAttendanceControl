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
    public partial class NewSwipe : Form
    {
        public NewSwipe()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void btnAddSwipe_Click_1(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                //creates user object and assigns datagridview selected row as a value
                //by casting gridview row to user object
                Users currentUser = (Users)dgvUsers.SelectedRows[0].DataBoundItem;
                //creates accesscontrol (access swipe) object
                AccessControl t = new AccessControl(currentUser, currentUser.In_Out_Status);
                //changing user access swipe status
                t.Swipe(currentUser);
                //reassigning already created accesscontrol object
                t = new AccessControl(currentUser, currentUser.In_Out_Status);
                //adding it to list of access control swipes and all swipes
                EduManagement.Instance.AddSwipe(t);
                EduManagement.Instance.AddControlling(t);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewSwipe_Load(object sender, EventArgs e)
        {
            //loading datasource to the datagridview and combobox
            cbxUsers.DataSource = EduManagement.Instance.Users;
            dgvUsers.DataSource = EduManagement.Instance.Users;
        }
    }
}
