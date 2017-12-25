namespace PersonnelDepartment
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.depName = new System.Windows.Forms.TextBox();
            this.numberOfJob = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jobsName = new System.Windows.Forms.ComboBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.listJobs = new System.Windows.Forms.ListBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobAddBtn = new System.Windows.Forms.Button();
            this.saveDepBtn = new System.Windows.Forms.Button();
            this.jobClearBtn = new System.Windows.Forms.Button();
            this.deleteDepBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseDept = new System.Windows.Forms.ComboBox();
            this.addDepBtn = new System.Windows.Forms.Button();
            this.postgreData = new PersonnelDepartment.PostgreData();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter1 = new PersonnelDepartment.PostgreDataTableAdapters.departmentTableAdapter();
            this.jobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter1 = new PersonnelDepartment.PostgreDataTableAdapters.jobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // depName
            // 
            this.depName.Location = new System.Drawing.Point(165, 35);
            this.depName.Name = "depName";
            this.depName.Size = new System.Drawing.Size(257, 20);
            this.depName.TabIndex = 0;
            // 
            // numberOfJob
            // 
            this.numberOfJob.Location = new System.Drawing.Point(165, 88);
            this.numberOfJob.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberOfJob.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfJob.Name = "numberOfJob";
            this.numberOfJob.Size = new System.Drawing.Size(41, 20);
            this.numberOfJob.TabIndex = 2;
            this.numberOfJob.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Новое название отдела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Единиц должности";
            // 
            // jobsName
            // 
            this.jobsName.DataSource = this.jobBindingSource1;
            this.jobsName.DisplayMember = "name";
            this.jobsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobsName.FormattingEnabled = true;
            this.jobsName.Location = new System.Drawing.Point(165, 61);
            this.jobsName.Name = "jobsName";
            this.jobsName.Size = new System.Drawing.Size(257, 21);
            this.jobsName.TabIndex = 4;
            this.jobsName.ValueMember = "idjob";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";

            // 
            // appData
            // 

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Должность";
            // 
            // listJobs
            // 
            this.listJobs.FormattingEnabled = true;
            this.listJobs.Location = new System.Drawing.Point(12, 114);
            this.listJobs.Name = "listJobs";
            this.listJobs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listJobs.Size = new System.Drawing.Size(410, 186);
            this.listJobs.TabIndex = 6;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";

            // 
            // jobAddBtn
            // 
            this.jobAddBtn.Location = new System.Drawing.Point(212, 88);
            this.jobAddBtn.Name = "jobAddBtn";
            this.jobAddBtn.Size = new System.Drawing.Size(124, 23);
            this.jobAddBtn.TabIndex = 7;
            this.jobAddBtn.Text = "Добавить должность";
            this.jobAddBtn.UseVisualStyleBackColor = true;
            this.jobAddBtn.Click += new System.EventHandler(this.jobAddBtn_Click);
            // 
            // saveDepBtn
            // 
            this.saveDepBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveDepBtn.BackgroundImage")));
            this.saveDepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveDepBtn.Location = new System.Drawing.Point(194, 306);
            this.saveDepBtn.Name = "saveDepBtn";
            this.saveDepBtn.Size = new System.Drawing.Size(49, 48);
            this.saveDepBtn.TabIndex = 8;
            this.saveDepBtn.UseVisualStyleBackColor = true;
            this.saveDepBtn.Click += new System.EventHandler(this.saveDepBtn_Click);
            // 
            // jobClearBtn
            // 
            this.jobClearBtn.Location = new System.Drawing.Point(342, 88);
            this.jobClearBtn.Name = "jobClearBtn";
            this.jobClearBtn.Size = new System.Drawing.Size(75, 23);
            this.jobClearBtn.TabIndex = 9;
            this.jobClearBtn.Text = "Очистить";
            this.jobClearBtn.UseVisualStyleBackColor = true;
            this.jobClearBtn.Click += new System.EventHandler(this.jobClearBtn_Click);
            // 
            // deleteDepBtn
            // 
            this.deleteDepBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteDepBtn.BackgroundImage")));
            this.deleteDepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteDepBtn.Location = new System.Drawing.Point(264, 306);
            this.deleteDepBtn.Name = "deleteDepBtn";
            this.deleteDepBtn.Size = new System.Drawing.Size(49, 48);
            this.deleteDepBtn.TabIndex = 10;
            this.deleteDepBtn.UseVisualStyleBackColor = true;
            this.deleteDepBtn.Click += new System.EventHandler(this.deleteDepBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Название отдела";
            // 
            // chooseDept
            // 
            this.chooseDept.DataSource = this.departmentBindingSource1;
            this.chooseDept.DisplayMember = "name";
            this.chooseDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseDept.FormattingEnabled = true;
            this.chooseDept.Location = new System.Drawing.Point(165, 8);
            this.chooseDept.Name = "chooseDept";
            this.chooseDept.Size = new System.Drawing.Size(257, 21);
            this.chooseDept.TabIndex = 11;
            this.chooseDept.ValueMember = "iddept";
            this.chooseDept.DropDownClosed += new System.EventHandler(this.chooseDept_DropDownClosed);
            // 
            // addDepBtn
            // 
            this.addDepBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addDepBtn.BackgroundImage")));
            this.addDepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDepBtn.Location = new System.Drawing.Point(123, 306);
            this.addDepBtn.Name = "addDepBtn";
            this.addDepBtn.Size = new System.Drawing.Size(49, 48);
            this.addDepBtn.TabIndex = 13;
            this.addDepBtn.UseVisualStyleBackColor = true;
            this.addDepBtn.Click += new System.EventHandler(this.addDepBtn_Click);
            // 
            // jobTableAdapter
            // 

            // 
            // departmentTableAdapter
            // 

            // 
            // postgreData
            // 
            this.postgreData.DataSetName = "PostgreData";
            this.postgreData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "department";
            this.departmentBindingSource1.DataSource = this.postgreData;
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // jobBindingSource1
            // 
            this.jobBindingSource1.DataMember = "job";
            this.jobBindingSource1.DataSource = this.postgreData;
            // 
            // jobTableAdapter1
            // 
            this.jobTableAdapter1.ClearBeforeFill = true;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 366);
            this.Controls.Add(this.addDepBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chooseDept);
            this.Controls.Add(this.deleteDepBtn);
            this.Controls.Add(this.jobClearBtn);
            this.Controls.Add(this.saveDepBtn);
            this.Controls.Add(this.jobAddBtn);
            this.Controls.Add(this.listJobs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobsName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfJob);
            this.Controls.Add(this.depName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox depName;
        private System.Windows.Forms.NumericUpDown numberOfJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jobsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listJobs;
        private System.Windows.Forms.Button jobAddBtn;
        private System.Windows.Forms.Button saveDepBtn;
        private System.Windows.Forms.Button jobClearBtn;
        private System.Windows.Forms.Button deleteDepBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox chooseDept;
        private System.Windows.Forms.Button addDepBtn;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private PostgreData postgreData;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private PostgreDataTableAdapters.departmentTableAdapter departmentTableAdapter1;
        private System.Windows.Forms.BindingSource jobBindingSource1;
        private PostgreDataTableAdapters.jobTableAdapter jobTableAdapter1;
    }
}