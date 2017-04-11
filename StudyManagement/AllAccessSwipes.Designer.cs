namespace StudyManagement
{
    partial class AllAccessSwipes
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
            this.dgvAllAccessSwipes = new System.Windows.Forms.DataGridView();
            this.accessControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbSort = new System.Windows.Forms.GroupBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbOut = new System.Windows.Forms.RadioButton();
            this.rdbIn = new System.Windows.Forms.RadioButton();
            this.cbxSort = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAccessSwipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlBindingSource)).BeginInit();
            this.grbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllAccessSwipes
            // 
            this.dgvAllAccessSwipes.AllowUserToAddRows = false;
            this.dgvAllAccessSwipes.AllowUserToDeleteRows = false;
            this.dgvAllAccessSwipes.AllowUserToResizeColumns = false;
            this.dgvAllAccessSwipes.AllowUserToResizeRows = false;
            this.dgvAllAccessSwipes.AutoGenerateColumns = false;
            this.dgvAllAccessSwipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllAccessSwipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.swipeTimeDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.swipeTypeDataGridViewTextBoxColumn});
            this.dgvAllAccessSwipes.DataSource = this.accessControlBindingSource;
            this.dgvAllAccessSwipes.Location = new System.Drawing.Point(12, 12);
            this.dgvAllAccessSwipes.MultiSelect = false;
            this.dgvAllAccessSwipes.Name = "dgvAllAccessSwipes";
            this.dgvAllAccessSwipes.ReadOnly = true;
            this.dgvAllAccessSwipes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllAccessSwipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllAccessSwipes.Size = new System.Drawing.Size(689, 367);
            this.dgvAllAccessSwipes.TabIndex = 0;
            // 
            // accessControlBindingSource
            // 
            this.accessControlBindingSource.DataSource = typeof(CW_3821_ClassLibrary.AccessControl);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(595, 392);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(483, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbSort
            // 
            this.grbSort.Controls.Add(this.rdbAll);
            this.grbSort.Controls.Add(this.rdbOut);
            this.grbSort.Controls.Add(this.rdbIn);
            this.grbSort.Location = new System.Drawing.Point(50, 386);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(179, 34);
            this.grbSort.TabIndex = 3;
            this.grbSort.TabStop = false;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Location = new System.Drawing.Point(137, 12);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(36, 17);
            this.rdbAll.TabIndex = 2;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "All";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rdbOut
            // 
            this.rdbOut.AutoSize = true;
            this.rdbOut.Location = new System.Drawing.Point(69, 11);
            this.rdbOut.Name = "rdbOut";
            this.rdbOut.Size = new System.Drawing.Size(42, 17);
            this.rdbOut.TabIndex = 1;
            this.rdbOut.Text = "Out";
            this.rdbOut.UseVisualStyleBackColor = true;
            this.rdbOut.CheckedChanged += new System.EventHandler(this.rdbOut_CheckedChanged);
            // 
            // rdbIn
            // 
            this.rdbIn.AutoSize = true;
            this.rdbIn.Location = new System.Drawing.Point(6, 11);
            this.rdbIn.Name = "rdbIn";
            this.rdbIn.Size = new System.Drawing.Size(34, 17);
            this.rdbIn.TabIndex = 0;
            this.rdbIn.Text = "In";
            this.rdbIn.UseVisualStyleBackColor = true;
            this.rdbIn.CheckedChanged += new System.EventHandler(this.rdbIn_CheckedChanged);
            // 
            // cbxSort
            // 
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbxSort.Location = new System.Drawing.Point(304, 396);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(131, 21);
            this.cbxSort.TabIndex = 6;
            this.cbxSort.SelectedIndexChanged += new System.EventHandler(this.cbxSort_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 400);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter:";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(269, 400);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(29, 13);
            this.lblSort.TabIndex = 8;
            this.lblSort.Text = "Sort:";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User ID";
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 80;
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
            this.userTypeDataGridViewTextBoxColumn.Width = 80;
            // 
            // swipeTypeDataGridViewTextBoxColumn
            // 
            this.swipeTypeDataGridViewTextBoxColumn.DataPropertyName = "swipeType";
            this.swipeTypeDataGridViewTextBoxColumn.HeaderText = "swipeType";
            this.swipeTypeDataGridViewTextBoxColumn.Name = "swipeTypeDataGridViewTextBoxColumn";
            this.swipeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.swipeTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // AllAccessSwipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 432);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbxSort);
            this.Controls.Add(this.grbSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvAllAccessSwipes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(731, 471);
            this.MinimumSize = new System.Drawing.Size(731, 471);
            this.Name = "AllAccessSwipes";
            this.Text = "Access Swipes";
            this.Activated += new System.EventHandler(this.AllAccessSwipes_Activated);
            this.Load += new System.EventHandler(this.AllAccessSwipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAccessSwipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessControlBindingSource)).EndInit();
            this.grbSort.ResumeLayout(false);
            this.grbSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllAccessSwipes;
        private System.Windows.Forms.BindingSource accessControlBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbSort;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbOut;
        private System.Windows.Forms.RadioButton rdbIn;
        private System.Windows.Forms.ComboBox cbxSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSort;
    }
}