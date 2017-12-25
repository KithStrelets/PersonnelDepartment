namespace PersonnelDepartment
{
    partial class JobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobForm));
            this.addJobBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseJob = new System.Windows.Forms.ComboBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteJobBtn = new System.Windows.Forms.Button();
            this.saveJobBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salaryRank = new System.Windows.Forms.NumericUpDown();
            this.jobName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rankCB = new System.Windows.Forms.ComboBox();
            this.postgreData = new PersonnelDepartment.PostgreData();
            this.jobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter1 = new PersonnelDepartment.PostgreDataTableAdapters.jobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addJobBtn
            // 
            this.addJobBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addJobBtn.BackgroundImage")));
            this.addJobBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addJobBtn.Location = new System.Drawing.Point(141, 123);
            this.addJobBtn.Name = "addJobBtn";
            this.addJobBtn.Size = new System.Drawing.Size(44, 39);
            this.addJobBtn.TabIndex = 27;
            this.addJobBtn.UseVisualStyleBackColor = true;
            this.addJobBtn.Click += new System.EventHandler(this.addJobBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Название должности";
            // 
            // chooseJob
            // 
            this.chooseJob.DataSource = this.jobBindingSource1;
            this.chooseJob.DisplayMember = "name";
            this.chooseJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseJob.FormattingEnabled = true;
            this.chooseJob.Location = new System.Drawing.Point(206, 16);
            this.chooseJob.Name = "chooseJob";
            this.chooseJob.Size = new System.Drawing.Size(216, 21);
            this.chooseJob.TabIndex = 25;
            this.chooseJob.ValueMember = "idjob";
            this.chooseJob.DropDownClosed += new System.EventHandler(this.chooseJob_DropDownClosed);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";
            // 
            // appData
            // 

            // 
            // deleteJobBtn
            // 
            this.deleteJobBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteJobBtn.BackgroundImage")));
            this.deleteJobBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteJobBtn.Location = new System.Drawing.Point(268, 123);
            this.deleteJobBtn.Name = "deleteJobBtn";
            this.deleteJobBtn.Size = new System.Drawing.Size(44, 39);
            this.deleteJobBtn.TabIndex = 24;
            this.deleteJobBtn.UseVisualStyleBackColor = true;
            this.deleteJobBtn.Click += new System.EventHandler(this.deleteJobBtn_Click);
            // 
            // saveJobBtn
            // 
            this.saveJobBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveJobBtn.BackgroundImage")));
            this.saveJobBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveJobBtn.Location = new System.Drawing.Point(205, 123);
            this.saveJobBtn.Name = "saveJobBtn";
            this.saveJobBtn.Size = new System.Drawing.Size(44, 39);
            this.saveJobBtn.TabIndex = 22;
            this.saveJobBtn.UseVisualStyleBackColor = true;
            this.saveJobBtn.Click += new System.EventHandler(this.saveJobBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ставка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Новое название должности";
            // 
            // salaryRank
            // 
            this.salaryRank.Location = new System.Drawing.Point(80, 96);
            this.salaryRank.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryRank.Name = "salaryRank";
            this.salaryRank.Size = new System.Drawing.Size(81, 20);
            this.salaryRank.TabIndex = 15;
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(206, 43);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(216, 20);
            this.jobName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Разряд";
            // 
            // rankCB
            // 
            this.rankCB.FormattingEnabled = true;
            this.rankCB.Items.AddRange(new object[] {
            "Junior",
            "Senior"});
            this.rankCB.Location = new System.Drawing.Point(206, 69);
            this.rankCB.Name = "rankCB";
            this.rankCB.Size = new System.Drawing.Size(216, 21);
            this.rankCB.TabIndex = 31;
            // 
            // jobTableAdapter
            // 
            // 
            // postgreData
            // 
            this.postgreData.DataSetName = "PostgreData";
            this.postgreData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 166);
            this.Controls.Add(this.rankCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addJobBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chooseJob);
            this.Controls.Add(this.deleteJobBtn);
            this.Controls.Add(this.saveJobBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaryRank);
            this.Controls.Add(this.jobName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Должность";
            this.Load += new System.EventHandler(this.JobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addJobBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox chooseJob;
        private System.Windows.Forms.Button deleteJobBtn;
        private System.Windows.Forms.Button saveJobBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown salaryRank;
        private System.Windows.Forms.TextBox jobName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rankCB;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private PostgreData postgreData;
        private System.Windows.Forms.BindingSource jobBindingSource1;
        private PostgreDataTableAdapters.jobTableAdapter jobTableAdapter1;
    }
}