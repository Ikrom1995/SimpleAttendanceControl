namespace StudyManagement
{
    partial class AllSwipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAllAccesses = new System.Windows.Forms.DataGridView();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAllAttendance = new System.Windows.Forms.DataGridView();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attandanceControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAllSwipes = new System.Windows.Forms.DataGridView();
            this.userDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeTimeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeTypeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controllingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCourseWorkRequirement = new System.Windows.Forms.Label();
            this.lblAccess = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAccesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attandanceControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSwipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllAccesses
            // 
            this.dgvAllAccesses.AllowUserToAddRows = false;
            this.dgvAllAccesses.AllowUserToDeleteRows = false;
            this.dgvAllAccesses.AllowUserToResizeColumns = false;
            this.dgvAllAccesses.AllowUserToResizeRows = false;
            this.dgvAllAccesses.AutoGenerateColumns = false;
            this.dgvAllAccesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAccesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.swipeTimeDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.swipeTypeDataGridViewTextBoxColumn});
            this.dgvAllAccesses.DataSource = this.accessControlBindingSource;
            this.dgvAllAccesses.Location = new System.Drawing.Point(658, 35);
            this.dgvAllAccesses.MultiSelect = false;
            this.dgvAllAccesses.Name = "dgvAllAccesses";
            this.dgvAllAccesses.ReadOnly = true;
            this.dgvAllAccesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllAccesses.Size = new System.Drawing.Size(694, 214);
            this.dgvAllAccesses.TabIndex = 0;
            this.dgvAllAccesses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllAccesses_CellClick);
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Width = 80;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 135;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 135;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeTimeDataGridViewTextBoxColumn
            // 
            this.swipeTimeDataGridViewTextBoxColumn.DataPropertyName = "SwipeTime";
            this.swipeTimeDataGridViewTextBoxColumn.HeaderText = "Swipe Time";
            this.swipeTimeDataGridViewTextBoxColumn.Name = "swipeTimeDataGridViewTextBoxColumn";
            this.swipeTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User Type";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeTypeDataGridViewTextBoxColumn
            // 
            this.swipeTypeDataGridViewTextBoxColumn.DataPropertyName = "swipeType";
            this.swipeTypeDataGridViewTextBoxColumn.HeaderText = "swipeType";
            this.swipeTypeDataGridViewTextBoxColumn.Name = "swipeTypeDataGridViewTextBoxColumn";
            this.swipeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.swipeTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // accessControlBindingSource
            // 
            this.accessControlBindingSource.DataSource = typeof(CW_3821_ClassLibrary.AccessControl);
            // 
            // dgvAllAttendance
            // 
            this.dgvAllAttendance.AllowUserToAddRows = false;
            this.dgvAllAttendance.AllowUserToDeleteRows = false;
            this.dgvAllAttendance.AllowUserToResizeColumns = false;
            this.dgvAllAttendance.AllowUserToResizeRows = false;
            this.dgvAllAttendance.AutoGenerateColumns = false;
            this.dgvAllAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.groupDataGridViewTextBoxColumn,
            this.swipeTimeDataGridViewTextBoxColumn1,
            this.aStatusDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1,
            this.swipeTypeDataGridViewTextBoxColumn1,
            this.userDataGridViewTextBoxColumn1,
            this.userTypeDataGridViewTextBoxColumn1});
            this.dgvAllAttendance.DataSource = this.attandanceControlBindingSource;
            this.dgvAllAttendance.Location = new System.Drawing.Point(658, 297);
            this.dgvAllAttendance.MultiSelect = false;
            this.dgvAllAttendance.Name = "dgvAllAttendance";
            this.dgvAllAttendance.ReadOnly = true;
            this.dgvAllAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllAttendance.Size = new System.Drawing.Size(694, 207);
            this.dgvAllAttendance.TabIndex = 1;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentDataGridViewTextBoxColumn.Width = 90;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupDataGridViewTextBoxColumn.Width = 80;
            // 
            // swipeTimeDataGridViewTextBoxColumn1
            // 
            this.swipeTimeDataGridViewTextBoxColumn1.DataPropertyName = "SwipeTime";
            this.swipeTimeDataGridViewTextBoxColumn1.HeaderText = "Swipe Time";
            this.swipeTimeDataGridViewTextBoxColumn1.Name = "swipeTimeDataGridViewTextBoxColumn1";
            this.swipeTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aStatusDataGridViewTextBoxColumn
            // 
            this.aStatusDataGridViewTextBoxColumn.DataPropertyName = "AStatus";
            this.aStatusDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.aStatusDataGridViewTextBoxColumn.Name = "aStatusDataGridViewTextBoxColumn";
            this.aStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.aStatusDataGridViewTextBoxColumn.Width = 90;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher ID";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherDataGridViewTextBoxColumn.Width = 90;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // swipeTypeDataGridViewTextBoxColumn1
            // 
            this.swipeTypeDataGridViewTextBoxColumn1.DataPropertyName = "swipeType";
            this.swipeTypeDataGridViewTextBoxColumn1.HeaderText = "swipeType";
            this.swipeTypeDataGridViewTextBoxColumn1.Name = "swipeTypeDataGridViewTextBoxColumn1";
            this.swipeTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.swipeTypeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // userDataGridViewTextBoxColumn1
            // 
            this.userDataGridViewTextBoxColumn1.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn1.HeaderText = "User";
            this.userDataGridViewTextBoxColumn1.Name = "userDataGridViewTextBoxColumn1";
            this.userDataGridViewTextBoxColumn1.ReadOnly = true;
            this.userDataGridViewTextBoxColumn1.Visible = false;
            // 
            // userTypeDataGridViewTextBoxColumn1
            // 
            this.userTypeDataGridViewTextBoxColumn1.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn1.HeaderText = "userType";
            this.userTypeDataGridViewTextBoxColumn1.Name = "userTypeDataGridViewTextBoxColumn1";
            this.userTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // attandanceControlBindingSource
            // 
            this.attandanceControlBindingSource.DataSource = typeof(CW_3821_ClassLibrary.AttandanceControl);
            // 
            // dgvAllSwipes
            // 
            this.dgvAllSwipes.AllowUserToAddRows = false;
            this.dgvAllSwipes.AllowUserToDeleteRows = false;
            this.dgvAllSwipes.AllowUserToResizeColumns = false;
            this.dgvAllSwipes.AllowUserToResizeRows = false;
            this.dgvAllSwipes.AutoGenerateColumns = false;
            this.dgvAllSwipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSwipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn2,
            this.userTypeDataGridViewTextBoxColumn2,
            this.swipeTimeDataGridViewTextBoxColumn2,
            this.swipeTypeDataGridViewTextBoxColumn2});
            this.dgvAllSwipes.DataSource = this.controllingBindingSource;
            this.dgvAllSwipes.Location = new System.Drawing.Point(12, 35);
            this.dgvAllSwipes.MultiSelect = false;
            this.dgvAllSwipes.Name = "dgvAllSwipes";
            this.dgvAllSwipes.ReadOnly = true;
            this.dgvAllSwipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllSwipes.Size = new System.Drawing.Size(626, 469);
            this.dgvAllSwipes.TabIndex = 2;
            // 
            // userDataGridViewTextBoxColumn2
            // 
            this.userDataGridViewTextBoxColumn2.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn2.HeaderText = "User";
            this.userDataGridViewTextBoxColumn2.Name = "userDataGridViewTextBoxColumn2";
            this.userDataGridViewTextBoxColumn2.ReadOnly = true;
            this.userDataGridViewTextBoxColumn2.Width = 80;
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            this.firstNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            this.lastNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn2
            // 
            this.userTypeDataGridViewTextBoxColumn2.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn2.HeaderText = "User Type";
            this.userTypeDataGridViewTextBoxColumn2.Name = "userTypeDataGridViewTextBoxColumn2";
            this.userTypeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // swipeTimeDataGridViewTextBoxColumn2
            // 
            this.swipeTimeDataGridViewTextBoxColumn2.DataPropertyName = "SwipeTime";
            this.swipeTimeDataGridViewTextBoxColumn2.HeaderText = "Swipe Time";
            this.swipeTimeDataGridViewTextBoxColumn2.Name = "swipeTimeDataGridViewTextBoxColumn2";
            this.swipeTimeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // swipeTypeDataGridViewTextBoxColumn2
            // 
            this.swipeTypeDataGridViewTextBoxColumn2.DataPropertyName = "swipeType";
            this.swipeTypeDataGridViewTextBoxColumn2.HeaderText = "Swipe Type";
            this.swipeTypeDataGridViewTextBoxColumn2.Name = "swipeTypeDataGridViewTextBoxColumn2";
            this.swipeTypeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // controllingBindingSource
            // 
            this.controllingBindingSource.DataSource = typeof(CW_3821_ClassLibrary.Controlling);
            // 
            // lblCourseWorkRequirement
            // 
            this.lblCourseWorkRequirement.AutoSize = true;
            this.lblCourseWorkRequirement.Location = new System.Drawing.Point(15, 9);
            this.lblCourseWorkRequirement.Name = "lblCourseWorkRequirement";
            this.lblCourseWorkRequirement.Size = new System.Drawing.Size(102, 13);
            this.lblCourseWorkRequirement.TabIndex = 3;
            this.lblCourseWorkRequirement.Text = "All Swipes By Colors";
            // 
            // lblAccess
            // 
            this.lblAccess.AutoSize = true;
            this.lblAccess.Location = new System.Drawing.Point(655, 9);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(79, 13);
            this.lblAccess.TabIndex = 4;
            this.lblAccess.Text = "Access Swipes";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Location = new System.Drawing.Point(655, 271);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(318, 13);
            this.lblAttendance.TabIndex = 5;
            this.lblAttendance.Text = "User Attendance By Date of Access: Select Access Swipe Above";
            // 
            // AllSwipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 527);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.lblAccess);
            this.Controls.Add(this.lblCourseWorkRequirement);
            this.Controls.Add(this.dgvAllSwipes);
            this.Controls.Add(this.dgvAllAttendance);
            this.Controls.Add(this.dgvAllAccesses);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1382, 566);
            this.MinimumSize = new System.Drawing.Size(1382, 566);
            this.Name = "AllSwipes";
            this.Text = "All Swipes";
            this.Activated += new System.EventHandler(this.AllSwipes_Activated);
            this.Load += new System.EventHandler(this.AllSwipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAccesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attandanceControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSwipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllAccesses;
        private System.Windows.Forms.BindingSource accessControlBindingSource;
        private System.Windows.Forms.DataGridView dgvAllAttendance;
        private System.Windows.Forms.BindingSource attandanceControlBindingSource;
        private System.Windows.Forms.DataGridView dgvAllSwipes;
        private System.Windows.Forms.BindingSource controllingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeTimeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeTypeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblCourseWorkRequirement;
        private System.Windows.Forms.Label lblAccess;
        private System.Windows.Forms.Label lblAttendance;
    }
}