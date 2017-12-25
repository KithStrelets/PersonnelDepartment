namespace PersonnelDepartment
{
    partial class OperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadData = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.plusPersonBtn = new System.Windows.Forms.Button();
            this.minusPersonBtn = new System.Windows.Forms.Button();
            this.jobBtn = new System.Windows.Forms.Button();
            this.editPersonBtn = new System.Windows.Forms.Button();
            this.DeptBtn = new System.Windows.Forms.Button();
            this.infTable = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.personList = new System.Windows.Forms.GroupBox();

            this.postgreData = new PersonnelDepartment.PostgreData();
            this.postgreDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter1 = new PersonnelDepartment.PostgreDataTableAdapters.personTableAdapter();
            this.idpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marriedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkdepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkjobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isfiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkworkerscheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();

            this.personList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgreDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.reloadData);
            this.panel1.Controls.Add(this.reportBtn);
            this.panel1.Controls.Add(this.plusPersonBtn);
            this.panel1.Controls.Add(this.minusPersonBtn);
            this.panel1.Controls.Add(this.jobBtn);
            this.panel1.Controls.Add(this.editPersonBtn);
            this.panel1.Controls.Add(this.DeptBtn);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 42);
            this.panel1.TabIndex = 5;
            // 
            // reloadData
            // 
            this.reloadData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reloadData.BackgroundImage")));
            this.reloadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reloadData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reloadData.Location = new System.Drawing.Point(322, -2);
            this.reloadData.Name = "reloadData";
            this.reloadData.Size = new System.Drawing.Size(50, 40);
            this.reloadData.TabIndex = 5;
            this.reloadData.UseVisualStyleBackColor = true;
            this.reloadData.Click += new System.EventHandler(this.OperationsForm_Load);
            // 
            // reportBtn
            // 
            this.reportBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportBtn.BackgroundImage")));
            this.reportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportBtn.Location = new System.Drawing.Point(266, -2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(50, 40);
            this.reportBtn.TabIndex = 5;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // plusPersonBtn
            // 
            this.plusPersonBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusPersonBtn.BackgroundImage")));
            this.plusPersonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plusPersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusPersonBtn.Location = new System.Drawing.Point(0, -2);
            this.plusPersonBtn.Name = "plusPersonBtn";
            this.plusPersonBtn.Size = new System.Drawing.Size(50, 40);
            this.plusPersonBtn.TabIndex = 0;
            this.plusPersonBtn.UseVisualStyleBackColor = true;
            this.plusPersonBtn.Click += new System.EventHandler(this.plusPersonBtn_Click);
            // 
            // minusPersonBtn
            // 
            this.minusPersonBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusPersonBtn.BackgroundImage")));
            this.minusPersonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minusPersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusPersonBtn.Location = new System.Drawing.Point(49, -2);
            this.minusPersonBtn.Name = "minusPersonBtn";
            this.minusPersonBtn.Size = new System.Drawing.Size(50, 40);
            this.minusPersonBtn.TabIndex = 1;
            this.minusPersonBtn.UseVisualStyleBackColor = true;
            this.minusPersonBtn.Click += new System.EventHandler(this.minusPersonBtn_Click);
            // 
            // jobBtn
            // 
            this.jobBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jobBtn.BackgroundImage")));
            this.jobBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jobBtn.Location = new System.Drawing.Point(210, -2);
            this.jobBtn.Name = "jobBtn";
            this.jobBtn.Size = new System.Drawing.Size(50, 40);
            this.jobBtn.TabIndex = 3;
            this.jobBtn.UseVisualStyleBackColor = true;
            this.jobBtn.Click += new System.EventHandler(this.jobBtn_Click);
            // 
            // editPersonBtn
            // 
            this.editPersonBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editPersonBtn.BackgroundImage")));
            this.editPersonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editPersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editPersonBtn.Location = new System.Drawing.Point(98, -2);
            this.editPersonBtn.Name = "editPersonBtn";
            this.editPersonBtn.Size = new System.Drawing.Size(50, 40);
            this.editPersonBtn.TabIndex = 1;
            this.editPersonBtn.UseVisualStyleBackColor = true;
            this.editPersonBtn.Click += new System.EventHandler(this.editPersonBtn_Click);
            // 
            // DeptBtn
            // 
            this.DeptBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeptBtn.BackgroundImage")));
            this.DeptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeptBtn.Location = new System.Drawing.Point(154, -2);
            this.DeptBtn.Name = "DeptBtn";
            this.DeptBtn.Size = new System.Drawing.Size(50, 40);
            this.DeptBtn.TabIndex = 2;
            this.DeptBtn.UseVisualStyleBackColor = true;
            this.DeptBtn.Click += new System.EventHandler(this.DeptBtn_Click);
            // 
            // infTable
            // 
            this.infTable.AutoGenerateColumns = false;
            this.infTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpersonDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.marriedDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.fkdepartmentDataGridViewTextBoxColumn,
            this.fkjobDataGridViewTextBoxColumn,
            this.isfiredDataGridViewTextBoxColumn,
            this.archiveDataGridViewTextBoxColumn,
            this.fkworkerscheduleDataGridViewTextBoxColumn});
            this.infTable.DataSource = this.personBindingSource1;
            this.infTable.Location = new System.Drawing.Point(2, 19);
            this.infTable.Name = "infTable";
            this.infTable.ReadOnly = true;
            this.infTable.Size = new System.Drawing.Size(1346, 483);
            this.infTable.TabIndex = 6;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "person";
            // 
            // appData
            // 

            // 
            // personList
            // 
            this.personList.Controls.Add(this.infTable);
            this.personList.Location = new System.Drawing.Point(-2, 42);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(1357, 511);
            this.personList.TabIndex = 7;
            this.personList.TabStop = false;
            this.personList.Text = "Список сотрудников";
            // 
            // personTableAdapter
            // 

            // 
            // postgreData
            // 
            this.postgreData.DataSetName = "PostgreData";
            this.postgreData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postgreDataBindingSource
            // 
            this.postgreDataBindingSource.DataSource = this.postgreData;
            this.postgreDataBindingSource.Position = 0;
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataMember = "person";
            this.personBindingSource1.DataSource = this.postgreData;
            // 
            // personTableAdapter1
            // 
            this.personTableAdapter1.ClearBeforeFill = true;
            // 
            // idpersonDataGridViewTextBoxColumn
            // 
            this.idpersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idpersonDataGridViewTextBoxColumn.DataPropertyName = "idperson";
            this.idpersonDataGridViewTextBoxColumn.HeaderText = "id";
            this.idpersonDataGridViewTextBoxColumn.Name = "idpersonDataGridViewTextBoxColumn";
            this.idpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersonDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Full name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 77;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marriedDataGridViewTextBoxColumn
            // 
            this.marriedDataGridViewTextBoxColumn.DataPropertyName = "married";
            this.marriedDataGridViewTextBoxColumn.HeaderText = "Married";
            this.marriedDataGridViewTextBoxColumn.Name = "marriedDataGridViewTextBoxColumn";
            this.marriedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkdepartmentDataGridViewTextBoxColumn
            // 
            this.fkdepartmentDataGridViewTextBoxColumn.DataPropertyName = "fk_department";
            this.fkdepartmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.fkdepartmentDataGridViewTextBoxColumn.Name = "fkdepartmentDataGridViewTextBoxColumn";
            this.fkdepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkdepartmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // fkjobDataGridViewTextBoxColumn
            // 
            this.fkjobDataGridViewTextBoxColumn.DataPropertyName = "fk_job";
            this.fkjobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.fkjobDataGridViewTextBoxColumn.Name = "fkjobDataGridViewTextBoxColumn";
            this.fkjobDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkjobDataGridViewTextBoxColumn.Width = 150;
            // 
            // isfiredDataGridViewTextBoxColumn
            // 
            this.isfiredDataGridViewTextBoxColumn.DataPropertyName = "isfired";
            this.isfiredDataGridViewTextBoxColumn.HeaderText = "Is fired";
            this.isfiredDataGridViewTextBoxColumn.Name = "isfiredDataGridViewTextBoxColumn";
            this.isfiredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // archiveDataGridViewTextBoxColumn
            // 
            this.archiveDataGridViewTextBoxColumn.DataPropertyName = "archive";
            this.archiveDataGridViewTextBoxColumn.HeaderText = "Archive";
            this.archiveDataGridViewTextBoxColumn.Name = "archiveDataGridViewTextBoxColumn";
            this.archiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.archiveDataGridViewTextBoxColumn.Width = 200;
            // 
            // fkworkerscheduleDataGridViewTextBoxColumn
            // 
            this.fkworkerscheduleDataGridViewTextBoxColumn.DataPropertyName = "fk_workerschedule";
            this.fkworkerscheduleDataGridViewTextBoxColumn.HeaderText = "Schedule";
            this.fkworkerscheduleDataGridViewTextBoxColumn.Name = "fkworkerscheduleDataGridViewTextBoxColumn";
            this.fkworkerscheduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkworkerscheduleDataGridViewTextBoxColumn.Width = 184;
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.OperationsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();

            this.personList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgreDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plusPersonBtn;
        private System.Windows.Forms.Button minusPersonBtn;
        private System.Windows.Forms.Button editPersonBtn;
        private System.Windows.Forms.Button jobBtn;
        private System.Windows.Forms.Button DeptBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView infTable;
        private System.Windows.Forms.GroupBox personList;
        private System.Windows.Forms.Button reportBtn;

        private System.Windows.Forms.BindingSource personBindingSource;

        private System.Windows.Forms.Button reloadData;
        private System.Windows.Forms.BindingSource postgreDataBindingSource;
        private PostgreData postgreData;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private PostgreDataTableAdapters.personTableAdapter personTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marriedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkdepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkjobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isfiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkworkerscheduleDataGridViewTextBoxColumn;
    }
}