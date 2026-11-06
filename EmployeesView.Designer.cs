namespace EMS
{
    partial class EmployeesView
    {
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboDeptFilter = new System.Windows.Forms.ComboBox();
            this.cboPosFilter = new System.Windows.Forms.ComboBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // btnAdd
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabIndex = 0;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(24, 20);
            this.btnAdd.Size = new System.Drawing.Size(150, 38);
            this.btnAdd.Text = "+ Add Employee";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // txtSearch
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TabIndex = 1;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(190, 25);
            this.txtSearch.Size = new System.Drawing.Size(250, 27);
            this.txtSearch.PlaceholderText = "Search by name...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // cboDeptFilter
            this.cboDeptFilter.Name = "cboDeptFilter";
            this.cboDeptFilter.TabIndex = 2;
            this.cboDeptFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptFilter.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDeptFilter.Location = new System.Drawing.Point(452, 24);
            this.cboDeptFilter.Size = new System.Drawing.Size(200, 28);
            this.cboDeptFilter.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
            // cboPosFilter
            this.cboPosFilter.Name = "cboPosFilter";
            this.cboPosFilter.TabIndex = 3;
            this.cboPosFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosFilter.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPosFilter.Location = new System.Drawing.Point(662, 24);
            this.cboPosFilter.Size = new System.Drawing.Size(207, 28);
            this.cboPosFilter.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
            // dgvEmployees
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.TabIndex = 4;
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvEmployees.Location = new System.Drawing.Point(24, 72);
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(845, 452);
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colId, this.colName, this.colDept, this.colPos, this.colEdit, this.colDelete });
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // colId
            this.colId.Name = "colId";
            this.colId.DataPropertyName = "emp_id";
            this.colId.FillWeight = 10F;
            this.colId.HeaderText = "ID";
            this.colId.ReadOnly = true;
            // colName
            this.colName.Name = "colName";
            this.colName.DataPropertyName = "full_name";
            this.colName.FillWeight = 34F;
            this.colName.HeaderText = "FULL NAME";
            this.colName.ReadOnly = true;
            // colDept
            this.colDept.Name = "colDept";
            this.colDept.DataPropertyName = "dept_name";
            this.colDept.FillWeight = 26F;
            this.colDept.HeaderText = "DEPARTMENT";
            this.colDept.ReadOnly = true;
            // colPos
            this.colPos.Name = "colPos";
            this.colPos.DataPropertyName = "position";
            this.colPos.FillWeight = 26F;
            this.colPos.HeaderText = "POSITION";
            this.colPos.ReadOnly = true;
            // colEdit
            this.colEdit.Name = "colEdit";
            this.colEdit.FillWeight = 10F;
            this.colEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEdit.HeaderText = "ACTIONS";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // colDelete
            this.colDelete.Name = "colDelete";
            this.colDelete.FillWeight = 10F;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            // EmployeesView
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // EmployeesView
            this.Name = "EmployeesView";
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.Size = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboDeptFilter);
            this.Controls.Add(this.cboPosFilter);
            this.Controls.Add(this.dgvEmployees);
            this.Load += new System.EventHandler(this.EmployeesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboDeptFilter;
        private System.Windows.Forms.ComboBox cboPosFilter;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPos;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}