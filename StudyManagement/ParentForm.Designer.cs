namespace StudyManagement
{
    partial class ParentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.allStudentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.allTeachersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSwipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSwipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.swipesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentMenu,
            this.addTeacherMenu,
            this.allStudentsMenu,
            this.allTeachersMenu,
            this.allUsersMenu});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addStudentMenu
            // 
            this.addStudentMenu.Name = "addStudentMenu";
            this.addStudentMenu.Size = new System.Drawing.Size(140, 22);
            this.addStudentMenu.Text = "Add Student";
            this.addStudentMenu.Click += new System.EventHandler(this.addStudentMenu_Click);
            // 
            // addTeacherMenu
            // 
            this.addTeacherMenu.Name = "addTeacherMenu";
            this.addTeacherMenu.Size = new System.Drawing.Size(140, 22);
            this.addTeacherMenu.Text = "Add Teacher";
            this.addTeacherMenu.Click += new System.EventHandler(this.addTeacherMenu_Click);
            // 
            // allStudentsMenu
            // 
            this.allStudentsMenu.Name = "allStudentsMenu";
            this.allStudentsMenu.Size = new System.Drawing.Size(140, 22);
            this.allStudentsMenu.Text = "All Students";
            this.allStudentsMenu.Click += new System.EventHandler(this.AllStudents);
            // 
            // allTeachersMenu
            // 
            this.allTeachersMenu.Name = "allTeachersMenu";
            this.allTeachersMenu.Size = new System.Drawing.Size(140, 22);
            this.allTeachersMenu.Text = "All Teachers";
            this.allTeachersMenu.Click += new System.EventHandler(this.allTeachersMenu_Click);
            // 
            // allUsersMenu
            // 
            this.allUsersMenu.Name = "allUsersMenu";
            this.allUsersMenu.Size = new System.Drawing.Size(140, 22);
            this.allUsersMenu.Text = "All Users";
            this.allUsersMenu.Click += new System.EventHandler(this.allUsersToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClassToolStripMenuItem,
            this.allClassesToolStripMenuItem});
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // newClassToolStripMenuItem
            // 
            this.newClassToolStripMenuItem.Name = "newClassToolStripMenuItem";
            this.newClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newClassToolStripMenuItem.Text = "New Class";
            this.newClassToolStripMenuItem.Click += new System.EventHandler(this.newClassToolStripMenuItem_Click);
            // 
            // allClassesToolStripMenuItem
            // 
            this.allClassesToolStripMenuItem.Name = "allClassesToolStripMenuItem";
            this.allClassesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allClassesToolStripMenuItem.Text = "All Classes";
            this.allClassesToolStripMenuItem.Click += new System.EventHandler(this.allClassesToolStripMenuItem_Click);
            // 
            // swipesToolStripMenuItem
            // 
            this.swipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inOutToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.allSwipesToolStripMenuItem});
            this.swipesToolStripMenuItem.Name = "swipesToolStripMenuItem";
            this.swipesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.swipesToolStripMenuItem.Text = "Swipes";
            // 
            // inOutToolStripMenuItem
            // 
            this.inOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.viewSwipesToolStripMenuItem});
            this.inOutToolStripMenuItem.Name = "inOutToolStripMenuItem";
            this.inOutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.inOutToolStripMenuItem.Text = "In/Out";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newToolStripMenuItem.Text = "New Swipe";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newAccessSwipeMenu_Click);
            // 
            // viewSwipesToolStripMenuItem
            // 
            this.viewSwipesToolStripMenuItem.Name = "viewSwipesToolStripMenuItem";
            this.viewSwipesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.viewSwipesToolStripMenuItem.Text = "View Swipes";
            this.viewSwipesToolStripMenuItem.Click += new System.EventHandler(this.viewSwipesToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAttendanceToolStripMenuItem,
            this.viewAttendanceToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // checkAttendanceToolStripMenuItem
            // 
            this.checkAttendanceToolStripMenuItem.Name = "checkAttendanceToolStripMenuItem";
            this.checkAttendanceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkAttendanceToolStripMenuItem.Text = "Check Attendance";
            this.checkAttendanceToolStripMenuItem.Click += new System.EventHandler(this.checkAttendanceToolStripMenuItem_Click);
            // 
            // viewAttendanceToolStripMenuItem
            // 
            this.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem";
            this.viewAttendanceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewAttendanceToolStripMenuItem.Text = "View Attendance";
            this.viewAttendanceToolStripMenuItem.Click += new System.EventHandler(this.viewAttendanceToolStripMenuItem_Click);
            // 
            // allSwipesToolStripMenuItem
            // 
            this.allSwipesToolStripMenuItem.Name = "allSwipesToolStripMenuItem";
            this.allSwipesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.allSwipesToolStripMenuItem.Text = "All Swipes";
            this.allSwipesToolStripMenuItem.Click += new System.EventHandler(this.allSwipesToolStripMenuItem_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(CW_3821_ClassLibrary.AccessControl);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 421);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ParentForm";
            this.Text = "EduManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSwipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeacherMenu;
        private System.Windows.Forms.ToolStripMenuItem allStudentsMenu;
        private System.Windows.Forms.ToolStripMenuItem allTeachersMenu;
        private System.Windows.Forms.ToolStripMenuItem allUsersMenu;
        private System.Windows.Forms.ToolStripMenuItem newClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSwipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentMenu;
    }
}

