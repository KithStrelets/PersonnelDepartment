namespace PersonnelDepartment
{
    partial class PersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.persName = new System.Windows.Forms.TextBox();
            this.persSurname = new System.Windows.Forms.TextBox();
            this.persFatherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.persBirthDate = new System.Windows.Forms.DateTimePicker();
            this.persMale = new System.Windows.Forms.RadioButton();
            this.persFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.persMarried = new System.Windows.Forms.CheckBox();
            this.personalInfo = new System.Windows.Forms.GroupBox();
            this.choosePicFile = new System.Windows.Forms.OpenFileDialog();
            this.photobox = new System.Windows.Forms.GroupBox();
            this.persPic = new System.Windows.Forms.PictureBox();
            this.archiveInfo = new System.Windows.Forms.GroupBox();
            this.clearArchiveBtn = new System.Windows.Forms.Button();
            this.addArchiveBtn = new System.Windows.Forms.Button();
            this.persArchiveCompany = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.persArchiveJobRank = new System.Windows.Forms.TextBox();
            this.persArchiveJob = new System.Windows.Forms.TextBox();
            this.persArchiveDept = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.persArchiveJobEnd = new System.Windows.Forms.DateTimePicker();
            this.persArchiveJobStart = new System.Windows.Forms.DateTimePicker();
            this.persArchive = new System.Windows.Forms.ListBox();
            this.statusWorking = new System.Windows.Forms.RadioButton();
            this.statusFired = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.presentDept = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postgreData = new PersonnelDepartment.PostgreData();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.presentJob = new System.Windows.Forms.ComboBox();
            this.jobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presentJobRank = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.recruitPerson = new System.Windows.Forms.Button();
            this.firePerson = new System.Windows.Forms.Button();
            this.updatePersBtn = new System.Windows.Forms.Button();
            this.departmentTableAdapter1 = new PersonnelDepartment.PostgreDataTableAdapters.departmentTableAdapter();
            this.jobTableAdapter1 = new PersonnelDepartment.PostgreDataTableAdapters.jobTableAdapter();
            this.fillJobRanksToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillJobRanksToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.personalInfo.SuspendLayout();
            this.photobox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persPic)).BeginInit();
            this.archiveInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.fillJobRanksToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // persName
            // 
            this.persName.Location = new System.Drawing.Point(81, 26);
            this.persName.Name = "persName";
            this.persName.Size = new System.Drawing.Size(161, 20);
            this.persName.TabIndex = 0;
            // 
            // persSurname
            // 
            this.persSurname.Location = new System.Drawing.Point(81, 52);
            this.persSurname.Name = "persSurname";
            this.persSurname.Size = new System.Drawing.Size(173, 20);
            this.persSurname.TabIndex = 1;
            // 
            // persFatherName
            // 
            this.persFatherName.Location = new System.Drawing.Point(81, 78);
            this.persFatherName.Name = "persFatherName";
            this.persFatherName.Size = new System.Drawing.Size(173, 20);
            this.persFatherName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // persBirthDate
            // 
            this.persBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.persBirthDate.Location = new System.Drawing.Point(110, 142);
            this.persBirthDate.Name = "persBirthDate";
            this.persBirthDate.Size = new System.Drawing.Size(122, 20);
            this.persBirthDate.TabIndex = 11;
            // 
            // persMale
            // 
            this.persMale.AutoSize = true;
            this.persMale.Location = new System.Drawing.Point(82, 109);
            this.persMale.Name = "persMale";
            this.persMale.Size = new System.Drawing.Size(49, 17);
            this.persMale.TabIndex = 4;
            this.persMale.TabStop = true;
            this.persMale.Text = "муж.";
            this.persMale.UseVisualStyleBackColor = true;
            // 
            // persFemale
            // 
            this.persFemale.AutoSize = true;
            this.persFemale.Location = new System.Drawing.Point(137, 109);
            this.persFemale.Name = "persFemale";
            this.persFemale.Size = new System.Drawing.Size(48, 17);
            this.persFemale.TabIndex = 5;
            this.persFemale.TabStop = true;
            this.persFemale.Text = "жен.";
            this.persFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Семейное положение";
            // 
            // persMarried
            // 
            this.persMarried.AutoSize = true;
            this.persMarried.Location = new System.Drawing.Point(137, 172);
            this.persMarried.Name = "persMarried";
            this.persMarried.Size = new System.Drawing.Size(109, 17);
            this.persMarried.TabIndex = 15;
            this.persMarried.Text = "женат/замужем";
            this.persMarried.UseVisualStyleBackColor = true;
            // 
            // personalInfo
            // 
            this.personalInfo.Controls.Add(this.label1);
            this.personalInfo.Controls.Add(this.persMarried);
            this.personalInfo.Controls.Add(this.persName);
            this.personalInfo.Controls.Add(this.label6);
            this.personalInfo.Controls.Add(this.persSurname);
            this.personalInfo.Controls.Add(this.persBirthDate);
            this.personalInfo.Controls.Add(this.persFatherName);
            this.personalInfo.Controls.Add(this.label5);
            this.personalInfo.Controls.Add(this.persMale);
            this.personalInfo.Controls.Add(this.label4);
            this.personalInfo.Controls.Add(this.persFemale);
            this.personalInfo.Controls.Add(this.label3);
            this.personalInfo.Controls.Add(this.label2);
            this.personalInfo.Location = new System.Drawing.Point(12, 12);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(305, 212);
            this.personalInfo.TabIndex = 16;
            this.personalInfo.TabStop = false;
            this.personalInfo.Text = "Личная информация";
            // 
            // choosePicFile
            // 
            this.choosePicFile.FileName = "picFile";
            // 
            // photobox
            // 
            this.photobox.Controls.Add(this.persPic);
            this.photobox.Location = new System.Drawing.Point(323, 12);
            this.photobox.Name = "photobox";
            this.photobox.Size = new System.Drawing.Size(258, 254);
            this.photobox.TabIndex = 18;
            this.photobox.TabStop = false;
            this.photobox.Text = "Фото";
            // 
            // persPic
            // 
            this.persPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.persPic.Image = global::PersonnelDepartment.Properties.Resources.nophoto;
            this.persPic.Location = new System.Drawing.Point(4, 19);
            this.persPic.Name = "persPic";
            this.persPic.Size = new System.Drawing.Size(250, 230);
            this.persPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.persPic.TabIndex = 17;
            this.persPic.TabStop = false;
            this.persPic.Click += new System.EventHandler(this.persPic_Click);
            // 
            // archiveInfo
            // 
            this.archiveInfo.Controls.Add(this.clearArchiveBtn);
            this.archiveInfo.Controls.Add(this.addArchiveBtn);
            this.archiveInfo.Controls.Add(this.persArchiveCompany);
            this.archiveInfo.Controls.Add(this.label16);
            this.archiveInfo.Controls.Add(this.persArchiveJobRank);
            this.archiveInfo.Controls.Add(this.persArchiveJob);
            this.archiveInfo.Controls.Add(this.persArchiveDept);
            this.archiveInfo.Controls.Add(this.label12);
            this.archiveInfo.Controls.Add(this.label11);
            this.archiveInfo.Controls.Add(this.label10);
            this.archiveInfo.Controls.Add(this.label9);
            this.archiveInfo.Controls.Add(this.label8);
            this.archiveInfo.Controls.Add(this.persArchiveJobEnd);
            this.archiveInfo.Controls.Add(this.persArchiveJobStart);
            this.archiveInfo.Location = new System.Drawing.Point(13, 231);
            this.archiveInfo.Name = "archiveInfo";
            this.archiveInfo.Size = new System.Drawing.Size(304, 218);
            this.archiveInfo.TabIndex = 19;
            this.archiveInfo.TabStop = false;
            this.archiveInfo.Text = "Рабочая информация";
            // 
            // clearArchiveBtn
            // 
            this.clearArchiveBtn.Location = new System.Drawing.Point(156, 185);
            this.clearArchiveBtn.Name = "clearArchiveBtn";
            this.clearArchiveBtn.Size = new System.Drawing.Size(75, 23);
            this.clearArchiveBtn.TabIndex = 34;
            this.clearArchiveBtn.Text = "Очистить";
            this.clearArchiveBtn.UseVisualStyleBackColor = true;
            this.clearArchiveBtn.Click += new System.EventHandler(this.clearArchiveBtn_Click);
            // 
            // addArchiveBtn
            // 
            this.addArchiveBtn.Location = new System.Drawing.Point(66, 185);
            this.addArchiveBtn.Name = "addArchiveBtn";
            this.addArchiveBtn.Size = new System.Drawing.Size(75, 23);
            this.addArchiveBtn.TabIndex = 33;
            this.addArchiveBtn.Text = "Добавить";
            this.addArchiveBtn.UseVisualStyleBackColor = true;
            this.addArchiveBtn.Click += new System.EventHandler(this.addArchiveBtn_Click);
            // 
            // persArchiveCompany
            // 
            this.persArchiveCompany.Location = new System.Drawing.Point(96, 22);
            this.persArchiveCompany.Name = "persArchiveCompany";
            this.persArchiveCompany.Size = new System.Drawing.Size(198, 20);
            this.persArchiveCompany.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Компания";
            // 
            // persArchiveJobRank
            // 
            this.persArchiveJobRank.Location = new System.Drawing.Point(96, 102);
            this.persArchiveJobRank.Name = "persArchiveJobRank";
            this.persArchiveJobRank.Size = new System.Drawing.Size(171, 20);
            this.persArchiveJobRank.TabIndex = 30;
            // 
            // persArchiveJob
            // 
            this.persArchiveJob.Location = new System.Drawing.Point(96, 76);
            this.persArchiveJob.Name = "persArchiveJob";
            this.persArchiveJob.Size = new System.Drawing.Size(198, 20);
            this.persArchiveJob.TabIndex = 29;
            // 
            // persArchiveDept
            // 
            this.persArchiveDept.Location = new System.Drawing.Point(96, 48);
            this.persArchiveDept.Name = "persArchiveDept";
            this.persArchiveDept.Size = new System.Drawing.Size(198, 20);
            this.persArchiveDept.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Увольнение";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Начало работы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Разряд";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Отдел";
            // 
            // persArchiveJobEnd
            // 
            this.persArchiveJobEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.persArchiveJobEnd.Location = new System.Drawing.Point(109, 155);
            this.persArchiveJobEnd.Name = "persArchiveJobEnd";
            this.persArchiveJobEnd.Size = new System.Drawing.Size(122, 20);
            this.persArchiveJobEnd.TabIndex = 16;
            // 
            // persArchiveJobStart
            // 
            this.persArchiveJobStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.persArchiveJobStart.Location = new System.Drawing.Point(109, 129);
            this.persArchiveJobStart.Name = "persArchiveJobStart";
            this.persArchiveJobStart.Size = new System.Drawing.Size(122, 20);
            this.persArchiveJobStart.TabIndex = 15;
            // 
            // persArchive
            // 
            this.persArchive.FormattingEnabled = true;
            this.persArchive.HorizontalScrollbar = true;
            this.persArchive.Location = new System.Drawing.Point(323, 273);
            this.persArchive.Name = "persArchive";
            this.persArchive.Size = new System.Drawing.Size(258, 303);
            this.persArchive.TabIndex = 20;
            // 
            // statusWorking
            // 
            this.statusWorking.AutoSize = true;
            this.statusWorking.Location = new System.Drawing.Point(120, 536);
            this.statusWorking.Name = "statusWorking";
            this.statusWorking.Size = new System.Drawing.Size(71, 17);
            this.statusWorking.TabIndex = 11;
            this.statusWorking.TabStop = true;
            this.statusWorking.Text = "работает";
            this.statusWorking.UseVisualStyleBackColor = true;
            // 
            // statusFired
            // 
            this.statusFired.AutoSize = true;
            this.statusFired.Location = new System.Drawing.Point(192, 536);
            this.statusFired.Name = "statusFired";
            this.statusFired.Size = new System.Drawing.Size(60, 17);
            this.statusFired.TabIndex = 12;
            this.statusFired.TabStop = true;
            this.statusFired.Text = "уволен";
            this.statusFired.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Текущий статус";
            // 
            // presentDept
            // 
            this.presentDept.DataSource = this.departmentBindingSource1;
            this.presentDept.DisplayMember = "name";
            this.presentDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presentDept.FormattingEnabled = true;
            this.presentDept.Location = new System.Drawing.Point(107, 455);
            this.presentDept.Name = "presentDept";
            this.presentDept.Size = new System.Drawing.Size(200, 21);
            this.presentDept.TabIndex = 28;
            this.presentDept.ValueMember = "iddept";
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "department";
            this.departmentBindingSource1.DataSource = this.postgreData;
            // 
            // postgreData
            // 
            this.postgreData.DataSetName = "PostgreData";
            this.postgreData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            // 
            // appData
            // 
            // 
            // presentJob
            // 
            this.presentJob.DataSource = this.jobBindingSource1;
            this.presentJob.DisplayMember = "name";
            this.presentJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presentJob.FormattingEnabled = true;
            this.presentJob.Location = new System.Drawing.Point(107, 482);
            this.presentJob.Name = "presentJob";
            this.presentJob.Size = new System.Drawing.Size(199, 21);
            this.presentJob.TabIndex = 29;
            this.presentJob.ValueMember = "idjob";
            // 
            // jobBindingSource1
            // 
            this.jobBindingSource1.DataMember = "job";
            this.jobBindingSource1.DataSource = this.postgreData;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";
            // 
            // presentJobRank
            // 
            this.presentJobRank.DataSource = this.jobBindingSource;
            this.presentJobRank.DisplayMember = "jobrank";
            this.presentJobRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presentJobRank.FormattingEnabled = true;
            this.presentJobRank.Location = new System.Drawing.Point(107, 509);
            this.presentJobRank.Name = "presentJobRank";
            this.presentJobRank.Size = new System.Drawing.Size(172, 21);
            this.presentJobRank.TabIndex = 30;
            this.presentJobRank.ValueMember = "jobrank";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 455);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Отдел";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Должность";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Разряд";
            // 
            // recruitPerson
            // 
            this.recruitPerson.Location = new System.Drawing.Point(23, 559);
            this.recruitPerson.Name = "recruitPerson";
            this.recruitPerson.Size = new System.Drawing.Size(110, 23);
            this.recruitPerson.TabIndex = 34;
            this.recruitPerson.Text = "Принять на работу";
            this.recruitPerson.UseVisualStyleBackColor = true;
            this.recruitPerson.Click += new System.EventHandler(this.recruitPerson_Click);
            // 
            // firePerson
            // 
            this.firePerson.Location = new System.Drawing.Point(231, 559);
            this.firePerson.Name = "firePerson";
            this.firePerson.Size = new System.Drawing.Size(75, 23);
            this.firePerson.TabIndex = 35;
            this.firePerson.Text = "Уволить";
            this.firePerson.UseVisualStyleBackColor = true;
            this.firePerson.Click += new System.EventHandler(this.firePerson_Click);
            // 
            // jobTableAdapter
            // 
            // 
            // departmentTableAdapter
            // 
            // 
            // updatePersBtn
            // 
            this.updatePersBtn.Location = new System.Drawing.Point(145, 559);
            this.updatePersBtn.Name = "updatePersBtn";
            this.updatePersBtn.Size = new System.Drawing.Size(75, 23);
            this.updatePersBtn.TabIndex = 35;
            this.updatePersBtn.Text = "Изменить";
            this.updatePersBtn.UseVisualStyleBackColor = true;
            this.updatePersBtn.Click += new System.EventHandler(this.updatePersBtn_Click);
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // jobTableAdapter1
            // 
            this.jobTableAdapter1.ClearBeforeFill = true;
            // 
            // fillJobRanksToolStrip
            // 
            this.fillJobRanksToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillJobRanksToolStripButton});
            this.fillJobRanksToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillJobRanksToolStrip.Name = "fillJobRanksToolStrip";
            this.fillJobRanksToolStrip.Size = new System.Drawing.Size(601, 25);
            this.fillJobRanksToolStrip.TabIndex = 36;
            this.fillJobRanksToolStrip.Text = "fillJobRanksToolStrip";
            // 
            // fillJobRanksToolStripButton
            // 
            this.fillJobRanksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillJobRanksToolStripButton.Name = "fillJobRanksToolStripButton";
            this.fillJobRanksToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.fillJobRanksToolStripButton.Text = "FillJobRanks";
            this.fillJobRanksToolStripButton.Click += new System.EventHandler(this.fillJobRanksToolStripButton_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 602);
            this.Controls.Add(this.fillJobRanksToolStrip);
            this.Controls.Add(this.updatePersBtn);
            this.Controls.Add(this.firePerson);
            this.Controls.Add(this.recruitPerson);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.presentJobRank);
            this.Controls.Add(this.presentJob);
            this.Controls.Add(this.presentDept);
            this.Controls.Add(this.persArchive);
            this.Controls.Add(this.archiveInfo);
            this.Controls.Add(this.photobox);
            this.Controls.Add(this.personalInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusFired);
            this.Controls.Add(this.statusWorking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.personalInfo.ResumeLayout(false);
            this.personalInfo.PerformLayout();
            this.photobox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.persPic)).EndInit();
            this.archiveInfo.ResumeLayout(false);
            this.archiveInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.fillJobRanksToolStrip.ResumeLayout(false);
            this.fillJobRanksToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox persName;
        private System.Windows.Forms.TextBox persSurname;
        private System.Windows.Forms.TextBox persFatherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker persBirthDate;
        private System.Windows.Forms.RadioButton persMale;
        private System.Windows.Forms.RadioButton persFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox persMarried;
        private System.Windows.Forms.GroupBox personalInfo;
        private System.Windows.Forms.PictureBox persPic;
        private System.Windows.Forms.OpenFileDialog choosePicFile;
        private System.Windows.Forms.GroupBox photobox;
        private System.Windows.Forms.GroupBox archiveInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker persArchiveJobEnd;
        private System.Windows.Forms.ListBox persArchive;
        private System.Windows.Forms.Button clearArchiveBtn;
        private System.Windows.Forms.Button addArchiveBtn;
        private System.Windows.Forms.TextBox persArchiveCompany;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox persArchiveJobRank;
        private System.Windows.Forms.TextBox persArchiveJob;
        private System.Windows.Forms.TextBox persArchiveDept;
        private System.Windows.Forms.DateTimePicker persArchiveJobStart;
        private System.Windows.Forms.RadioButton statusWorking;
        private System.Windows.Forms.RadioButton statusFired;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox presentDept;
        private System.Windows.Forms.ComboBox presentJob;
        private System.Windows.Forms.ComboBox presentJobRank;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button recruitPerson;
        private System.Windows.Forms.Button firePerson;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Button updatePersBtn;
        private PostgreData postgreData;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private PostgreDataTableAdapters.departmentTableAdapter departmentTableAdapter1;
        private System.Windows.Forms.BindingSource jobBindingSource1;
        private PostgreDataTableAdapters.jobTableAdapter jobTableAdapter1;
        private System.Windows.Forms.ToolStrip fillJobRanksToolStrip;
        private System.Windows.Forms.ToolStripButton fillJobRanksToolStripButton;
    }
}