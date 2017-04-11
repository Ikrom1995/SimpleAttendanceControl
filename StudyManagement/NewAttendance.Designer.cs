namespace StudyManagement
{
    partial class NewAttendance
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOutStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAttend = new System.Windows.Forms.Button();
            this.btnAbsent = new System.Windows.Forms.Button();
            this.cbxGroups = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTeachers = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.inOutStatusDataGridViewTextBoxColumn,
            this.doBDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn});
            this.dgvStudents.DataSource = this.studentBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(12, 39);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(606, 352);
            this.dgvStudents.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inOutStatusDataGridViewTextBoxColumn
            // 
            this.inOutStatusDataGridViewTextBoxColumn.DataPropertyName = "In_Out_Status";
            this.inOutStatusDataGridViewTextBoxColumn.HeaderText = "Access";
            this.inOutStatusDataGridViewTextBoxColumn.Name = "inOutStatusDataGridViewTextBoxColumn";
            this.inOutStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.inOutStatusDataGridViewTextBoxColumn.Width = 80;
            // 
            // doBDataGridViewTextBoxColumn
            // 
            this.doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            this.doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            this.doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            this.doBDataGridViewTextBoxColumn.ReadOnly = true;
            this.doBDataGridViewTextBoxColumn.Visible = false;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(CW_3821_ClassLibrary.Student);
            // 
            // btnAttend
            // 
            this.btnAttend.Location = new System.Drawing.Point(448, 397);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Size = new System.Drawing.Size(75, 23);
            this.btnAttend.TabIndex = 1;
            this.btnAttend.Text = "Attend";
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // btnAbsent
            // 
            this.btnAbsent.Location = new System.Drawing.Point(543, 397);
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.Size = new System.Drawing.Size(75, 23);
            this.btnAbsent.TabIndex = 2;
            this.btnAbsent.Text = "Absent";
            this.btnAbsent.UseVisualStyleBackColor = true;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // 
            // cbxGroups
            // 
            this.cbxGroups.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classesBindingSource, "Id", true));
            this.cbxGroups.DataSource = this.classesBindingSource;
            this.cbxGroups.DisplayMember = "ClassName";
            this.cbxGroups.FormattingEnabled = true;
            this.cbxGroups.Location = new System.Drawing.Point(277, 12);
            this.cbxGroups.Name = "cbxGroups";
            this.cbxGroups.Size = new System.Drawing.Size(121, 21);
            this.cbxGroups.TabIndex = 3;
            this.cbxGroups.SelectedIndexChanged += new System.EventHandler(this.cbxGroups_SelectedIndexChanged);
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataSource = typeof(CW_3821_ClassLibrary.Classes);
            // 
            // cbxTeachers
            // 
            this.cbxTeachers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teacherBindingSource, "Id", true));
            this.cbxTeachers.DataSource = this.teacherBindingSource;
            this.cbxTeachers.FormattingEnabled = true;
            this.cbxTeachers.Location = new System.Drawing.Point(68, 12);
            this.cbxTeachers.Name = "cbxTeachers";
            this.cbxTeachers.Size = new System.Drawing.Size(146, 21);
            this.cbxTeachers.TabIndex = 4;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(CW_3821_ClassLibrary.Teacher);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(543, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(12, 15);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(50, 13);
            this.lblTeacher.TabIndex = 6;
            this.lblTeacher.Text = "Teacher:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(232, 15);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 7;
            this.lblGroup.Text = "Group:";
            // 
            // NewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 432);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxTeachers);
            this.Controls.Add(this.cbxGroups);
            this.Controls.Add(this.btnAbsent);
            this.Controls.Add(this.btnAttend);
            this.Controls.Add(this.dgvStudents);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 471);
            this.MinimumSize = new System.Drawing.Size(647, 471);
            this.Name = "NewAttendance";
            this.Text = "NewAttendance";
            this.Activated += new System.EventHandler(this.NewAttendance_Activated);
            this.Load += new System.EventHandler(this.NewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button btnAttend;
        private System.Windows.Forms.Button btnAbsent;
        private System.Windows.Forms.ComboBox cbxGroups;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.ComboBox cbxTeachers;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inOutStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblGroup;
    }
}