namespace PersonnelDepartment
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveScheduleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sun2Box = new System.Windows.Forms.GroupBox();
            this.secondSunCheckedList = new System.Windows.Forms.CheckedListBox();
            this.sat2Box = new System.Windows.Forms.GroupBox();
            this.secondSatCheckedList = new System.Windows.Forms.CheckedListBox();
            this.fri2Box = new System.Windows.Forms.GroupBox();
            this.secondFriCheckedList = new System.Windows.Forms.CheckedListBox();
            this.thu2Box = new System.Windows.Forms.GroupBox();
            this.secondThuCheckedList = new System.Windows.Forms.CheckedListBox();
            this.wed2Box = new System.Windows.Forms.GroupBox();
            this.secondWedCheckedList = new System.Windows.Forms.CheckedListBox();
            this.tue2Box = new System.Windows.Forms.GroupBox();
            this.secondTueCheckedList = new System.Windows.Forms.CheckedListBox();
            this.mon2Box = new System.Windows.Forms.GroupBox();
            this.secondMonCheckedList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chooseJob = new System.Windows.Forms.ComboBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chooseDept = new System.Windows.Forms.ComboBox();
            this.sundayBox = new System.Windows.Forms.GroupBox();
            this.firstSunCheckedList = new System.Windows.Forms.CheckedListBox();
            this.saturdayBox = new System.Windows.Forms.GroupBox();
            this.firstSatCheckedList = new System.Windows.Forms.CheckedListBox();
            this.fridayBox = new System.Windows.Forms.GroupBox();
            this.firstFriCheckedList = new System.Windows.Forms.CheckedListBox();
            this.thursdayBox = new System.Windows.Forms.GroupBox();
            this.firstThuCheckedList = new System.Windows.Forms.CheckedListBox();
            this.wednesdayBox = new System.Windows.Forms.GroupBox();
            this.firstWedCheckedList = new System.Windows.Forms.CheckedListBox();
            this.tuesdayBox = new System.Windows.Forms.GroupBox();
            this.firstTueCheckedList = new System.Windows.Forms.CheckedListBox();
            this.mondayBox = new System.Windows.Forms.GroupBox();
            this.firstMonCheckedList = new System.Windows.Forms.CheckedListBox();
            this.delSchedBtn = new System.Windows.Forms.Button();
            this.postgreData = new PersonnelDepartment.PostgreData();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter1 = new PersonnelDepartment.PostgreDataTableAdapters.departmentTableAdapter();
            this.jobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter1 = new PersonnelDepartment.PostgreDataTableAdapters.jobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.sun2Box.SuspendLayout();
            this.sat2Box.SuspendLayout();
            this.fri2Box.SuspendLayout();
            this.thu2Box.SuspendLayout();
            this.wed2Box.SuspendLayout();
            this.tue2Box.SuspendLayout();
            this.mon2Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.sundayBox.SuspendLayout();
            this.saturdayBox.SuspendLayout();
            this.fridayBox.SuspendLayout();
            this.thursdayBox.SuspendLayout();
            this.wednesdayBox.SuspendLayout();
            this.tuesdayBox.SuspendLayout();
            this.mondayBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            // 
            // appData
            // 
            // 
            // departmentTableAdapter
            // 
            // 
            // jobTableAdapter
            // 
            // 
            // saveScheduleBtn
            // 
            this.saveScheduleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveScheduleBtn.BackgroundImage")));
            this.saveScheduleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveScheduleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveScheduleBtn.Location = new System.Drawing.Point(387, 39);
            this.saveScheduleBtn.Name = "saveScheduleBtn";
            this.saveScheduleBtn.Size = new System.Drawing.Size(48, 43);
            this.saveScheduleBtn.TabIndex = 67;
            this.saveScheduleBtn.UseVisualStyleBackColor = true;
            this.saveScheduleBtn.Click += new System.EventHandler(this.saveScheduleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(629, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 66;
            this.label2.Text = "II неделя";
            // 
            // sun2Box
            // 
            this.sun2Box.Controls.Add(this.secondSunCheckedList);
            this.sun2Box.Location = new System.Drawing.Point(1115, 450);
            this.sun2Box.Name = "sun2Box";
            this.sun2Box.Size = new System.Drawing.Size(170, 170);
            this.sun2Box.TabIndex = 65;
            this.sun2Box.TabStop = false;
            this.sun2Box.Text = "Воскресенье";
            // 
            // secondSunCheckedList
            // 
            this.secondSunCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.secondSunCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondSunCheckedList.CheckOnClick = true;
            this.secondSunCheckedList.FormattingEnabled = true;
            this.secondSunCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.secondSunCheckedList.Location = new System.Drawing.Point(24, 59);
            this.secondSunCheckedList.Name = "secondSunCheckedList";
            this.secondSunCheckedList.Size = new System.Drawing.Size(140, 105);
            this.secondSunCheckedList.TabIndex = 1;
            // 
            // sat2Box
            // 
            this.sat2Box.Controls.Add(this.secondSatCheckedList);
            this.sat2Box.Location = new System.Drawing.Point(940, 450);
            this.sat2Box.Name = "sat2Box";
            this.sat2Box.Size = new System.Drawing.Size(170, 170);
            this.sat2Box.TabIndex = 64;
            this.sat2Box.TabStop = false;
            this.sat2Box.Text = "Суббота";
            // 
            // secondSatCheckedList
            // 
            this.secondSatCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.secondSatCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondSatCheckedList.CheckOnClick = true;
            this.secondSatCheckedList.FormattingEnabled = true;
            this.secondSatCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.secondSatCheckedList.Location = new System.Drawing.Point(24, 59);
            this.secondSatCheckedList.Name = "secondSatCheckedList";
            this.secondSatCheckedList.Size = new System.Drawing.Size(140, 105);
            this.secondSatCheckedList.TabIndex = 1;
            // 
            // fri2Box
            // 
            this.fri2Box.Controls.Add(this.secondFriCheckedList);
            this.fri2Box.Location = new System.Drawing.Point(765, 450);
            this.fri2Box.Name = "fri2Box";
            this.fri2Box.Size = new System.Drawing.Size(170, 170);
            this.fri2Box.TabIndex = 63;
            this.fri2Box.TabStop = false;
            this.fri2Box.Text = "Пятница";
            // 
            // secondFriCheckedList
            // 
            this.secondFriCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.secondFriCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondFriCheckedList.CheckOnClick = true;
            this.secondFriCheckedList.FormattingEnabled = true;
            this.secondFriCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.secondFriCheckedList.Location = new System.Drawing.Point(24, 59);
            this.secondFriCheckedList.Name = "secondFriCheckedList";
            this.secondFriCheckedList.Size = new System.Drawing.Size(140, 105);
            this.secondFriCheckedList.TabIndex = 1;
            // 
            // thu2Box
            // 
            this.thu2Box.Controls.Add(this.secondThuCheckedList);
            this.thu2Box.Location = new System.Drawing.Point(590, 450);
            this.thu2Box.Name = "thu2Box";
            this.thu2Box.Size = new System.Drawing.Size(170, 170);
            this.thu2Box.TabIndex = 62;
            this.thu2Box.TabStop = false;
            this.thu2Box.Text = "Четверг";
            // 
            // secondThuCheckedList
            // 
            this.secondThuCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.secondThuCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondThuCheckedList.CheckOnClick = true;
            this.secondThuCheckedList.FormattingEnabled = true;
            this.secondThuCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.secondThuCheckedList.Location = new System.Drawing.Point(24, 59);
            this.secondThuCheckedList.Name = "secondThuCheckedList";
            this.secondThuCheckedList.Size = new System.Drawing.Size(140, 105);
            this.secondThuCheckedList.TabIndex = 1;
            // 
            // wed2Box
            // 
            this.wed2Box.Controls.Add(this.secondWedCheckedList);
            this.wed2Box.Location = new System.Drawing.Point(415, 450);
            this.wed2Box.Name = "wed2Box";
            this.wed2Box.Size = new System.Drawing.Size(170, 170);
            this.wed2Box.TabIndex = 61;
            this.wed2Box.TabStop = false;
            this.wed2Box.Text = "Среда";
            // 
            // secondWedCheckedList
            // 
            this.secondWedCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.secondWedCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondWedCheckedList.CheckOnClick = true;
            this.secondWedCheckedList.FormattingEnabled = true;
            this.secondWedCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.secondWedCheckedList.Location = new System.Drawing.Point(24, 59);
            this.secondWedCheckedList.Name = "secondWedCheckedList";
            this.secondWedCheckedList.Size = new System.Drawing.Size(140, 105);
            this.secondWedCheckedList.TabIndex = 1;
            // 
            // tue2Box
            // 
            this.tue2Box.Controls.Add(this.secondTueCheckedList);
            this.tue2Box.Location = new System.Drawing.Point(240, 450);
            this.tue2Box.Name = "tue2Box";
            this.tue2Box.Size = new System.Drawing.Size(170, 170);
            this.tue2Box.TabIndex = 60;
            this.tue2Box.TabStop = false;
            this.tue2Box.Text = "Вторник";
            // 
            // secondTueCheckedList
            // 
            this.secondTueCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.secondTueCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondTueCheckedList.CheckOnClick = true;
            this.secondTueCheckedList.FormattingEnabled = true;
            this.secondTueCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.secondTueCheckedList.Location = new System.Drawing.Point(24, 59);
            this.secondTueCheckedList.Name = "secondTueCheckedList";
            this.secondTueCheckedList.Size = new System.Drawing.Size(140, 105);
            this.secondTueCheckedList.TabIndex = 1;
            // 
            // mon2Box
            // 
            this.mon2Box.Controls.Add(this.secondMonCheckedList);
            this.mon2Box.Location = new System.Drawing.Point(65, 450);
            this.mon2Box.Name = "mon2Box";
            this.mon2Box.Size = new System.Drawing.Size(170, 170);
            this.mon2Box.TabIndex = 59;
            this.mon2Box.TabStop = false;
            this.mon2Box.Text = "Понедельник";
            // 
            // secondMonCheckedList
            // 
            this.secondMonCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.secondMonCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondMonCheckedList.CheckOnClick = true;
            this.secondMonCheckedList.FormattingEnabled = true;
            this.secondMonCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.secondMonCheckedList.Location = new System.Drawing.Point(24, 59);
            this.secondMonCheckedList.Name = "secondMonCheckedList";
            this.secondMonCheckedList.Size = new System.Drawing.Size(140, 105);
            this.secondMonCheckedList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(629, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 36);
            this.label1.TabIndex = 58;
            this.label1.Text = "I неделя";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Должность";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Отдел";
            // 
            // chooseJob
            // 
            this.chooseJob.DataSource = this.jobBindingSource1;
            this.chooseJob.DisplayMember = "name";
            this.chooseJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseJob.FormattingEnabled = true;
            this.chooseJob.Location = new System.Drawing.Point(151, 61);
            this.chooseJob.Name = "chooseJob";
            this.chooseJob.Size = new System.Drawing.Size(199, 21);
            this.chooseJob.TabIndex = 55;
            this.chooseJob.ValueMember = "idjob";
            this.chooseJob.DropDownClosed += new System.EventHandler(this.chooseJob_DropDownClosed);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";
            // 
            // chooseDept
            // 
            this.chooseDept.DataSource = this.departmentBindingSource1;
            this.chooseDept.DisplayMember = "name";
            this.chooseDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseDept.FormattingEnabled = true;
            this.chooseDept.Location = new System.Drawing.Point(151, 34);
            this.chooseDept.Name = "chooseDept";
            this.chooseDept.Size = new System.Drawing.Size(200, 21);
            this.chooseDept.TabIndex = 54;
            this.chooseDept.ValueMember = "iddept";
            this.chooseDept.DropDownClosed += new System.EventHandler(this.chooseDept_DropDownClosed);
            // 
            // sundayBox
            // 
            this.sundayBox.Controls.Add(this.firstSunCheckedList);
            this.sundayBox.Location = new System.Drawing.Point(1115, 192);
            this.sundayBox.Name = "sundayBox";
            this.sundayBox.Size = new System.Drawing.Size(170, 170);
            this.sundayBox.TabIndex = 53;
            this.sundayBox.TabStop = false;
            this.sundayBox.Text = "Воскресенье";
            // 
            // firstSunCheckedList
            // 
            this.firstSunCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.firstSunCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstSunCheckedList.CheckOnClick = true;
            this.firstSunCheckedList.FormattingEnabled = true;
            this.firstSunCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.firstSunCheckedList.Location = new System.Drawing.Point(24, 59);
            this.firstSunCheckedList.Name = "firstSunCheckedList";
            this.firstSunCheckedList.Size = new System.Drawing.Size(140, 105);
            this.firstSunCheckedList.TabIndex = 1;
            // 
            // saturdayBox
            // 
            this.saturdayBox.Controls.Add(this.firstSatCheckedList);
            this.saturdayBox.Location = new System.Drawing.Point(940, 192);
            this.saturdayBox.Name = "saturdayBox";
            this.saturdayBox.Size = new System.Drawing.Size(170, 170);
            this.saturdayBox.TabIndex = 52;
            this.saturdayBox.TabStop = false;
            this.saturdayBox.Text = "Суббота";
            // 
            // firstSatCheckedList
            // 
            this.firstSatCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.firstSatCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstSatCheckedList.CheckOnClick = true;
            this.firstSatCheckedList.FormattingEnabled = true;
            this.firstSatCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.firstSatCheckedList.Location = new System.Drawing.Point(24, 59);
            this.firstSatCheckedList.Name = "firstSatCheckedList";
            this.firstSatCheckedList.Size = new System.Drawing.Size(140, 105);
            this.firstSatCheckedList.TabIndex = 1;
            // 
            // fridayBox
            // 
            this.fridayBox.Controls.Add(this.firstFriCheckedList);
            this.fridayBox.Location = new System.Drawing.Point(765, 192);
            this.fridayBox.Name = "fridayBox";
            this.fridayBox.Size = new System.Drawing.Size(170, 170);
            this.fridayBox.TabIndex = 51;
            this.fridayBox.TabStop = false;
            this.fridayBox.Text = "Пятница";
            // 
            // firstFriCheckedList
            // 
            this.firstFriCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.firstFriCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstFriCheckedList.CheckOnClick = true;
            this.firstFriCheckedList.FormattingEnabled = true;
            this.firstFriCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.firstFriCheckedList.Location = new System.Drawing.Point(24, 59);
            this.firstFriCheckedList.Name = "firstFriCheckedList";
            this.firstFriCheckedList.Size = new System.Drawing.Size(140, 105);
            this.firstFriCheckedList.TabIndex = 1;
            // 
            // thursdayBox
            // 
            this.thursdayBox.Controls.Add(this.firstThuCheckedList);
            this.thursdayBox.Location = new System.Drawing.Point(590, 192);
            this.thursdayBox.Name = "thursdayBox";
            this.thursdayBox.Size = new System.Drawing.Size(170, 170);
            this.thursdayBox.TabIndex = 50;
            this.thursdayBox.TabStop = false;
            this.thursdayBox.Text = "Четверг";
            // 
            // firstThuCheckedList
            // 
            this.firstThuCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.firstThuCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstThuCheckedList.CheckOnClick = true;
            this.firstThuCheckedList.FormattingEnabled = true;
            this.firstThuCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.firstThuCheckedList.Location = new System.Drawing.Point(24, 59);
            this.firstThuCheckedList.Name = "firstThuCheckedList";
            this.firstThuCheckedList.Size = new System.Drawing.Size(140, 105);
            this.firstThuCheckedList.TabIndex = 1;
            // 
            // wednesdayBox
            // 
            this.wednesdayBox.Controls.Add(this.firstWedCheckedList);
            this.wednesdayBox.Location = new System.Drawing.Point(415, 192);
            this.wednesdayBox.Name = "wednesdayBox";
            this.wednesdayBox.Size = new System.Drawing.Size(170, 170);
            this.wednesdayBox.TabIndex = 49;
            this.wednesdayBox.TabStop = false;
            this.wednesdayBox.Text = "Среда";
            // 
            // firstWedCheckedList
            // 
            this.firstWedCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.firstWedCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstWedCheckedList.CheckOnClick = true;
            this.firstWedCheckedList.FormattingEnabled = true;
            this.firstWedCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.firstWedCheckedList.Location = new System.Drawing.Point(24, 59);
            this.firstWedCheckedList.Name = "firstWedCheckedList";
            this.firstWedCheckedList.Size = new System.Drawing.Size(140, 105);
            this.firstWedCheckedList.TabIndex = 1;
            // 
            // tuesdayBox
            // 
            this.tuesdayBox.Controls.Add(this.firstTueCheckedList);
            this.tuesdayBox.Location = new System.Drawing.Point(240, 192);
            this.tuesdayBox.Name = "tuesdayBox";
            this.tuesdayBox.Size = new System.Drawing.Size(170, 170);
            this.tuesdayBox.TabIndex = 48;
            this.tuesdayBox.TabStop = false;
            this.tuesdayBox.Text = "Вторник";
            // 
            // firstTueCheckedList
            // 
            this.firstTueCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.firstTueCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstTueCheckedList.CheckOnClick = true;
            this.firstTueCheckedList.FormattingEnabled = true;
            this.firstTueCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.firstTueCheckedList.Location = new System.Drawing.Point(24, 59);
            this.firstTueCheckedList.Name = "firstTueCheckedList";
            this.firstTueCheckedList.Size = new System.Drawing.Size(140, 105);
            this.firstTueCheckedList.TabIndex = 1;
            // 
            // mondayBox
            // 
            this.mondayBox.Controls.Add(this.firstMonCheckedList);
            this.mondayBox.Location = new System.Drawing.Point(65, 192);
            this.mondayBox.Name = "mondayBox";
            this.mondayBox.Size = new System.Drawing.Size(170, 170);
            this.mondayBox.TabIndex = 47;
            this.mondayBox.TabStop = false;
            this.mondayBox.Text = "Понедельник";
            // 
            // firstMonCheckedList
            // 
            this.firstMonCheckedList.BackColor = System.Drawing.SystemColors.Control;
            this.firstMonCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstMonCheckedList.CheckOnClick = true;
            this.firstMonCheckedList.FormattingEnabled = true;
            this.firstMonCheckedList.Items.AddRange(new object[] {
            "9:00 - 14:00",
            "13:00 - 18:00",
            "17:00 - 22:00"});
            this.firstMonCheckedList.Location = new System.Drawing.Point(29, 59);
            this.firstMonCheckedList.Name = "firstMonCheckedList";
            this.firstMonCheckedList.Size = new System.Drawing.Size(140, 105);
            this.firstMonCheckedList.TabIndex = 0;
            // 
            // delSchedBtn
            // 
            this.delSchedBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delSchedBtn.BackgroundImage")));
            this.delSchedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delSchedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delSchedBtn.Location = new System.Drawing.Point(450, 39);
            this.delSchedBtn.Name = "delSchedBtn";
            this.delSchedBtn.Size = new System.Drawing.Size(47, 43);
            this.delSchedBtn.TabIndex = 68;
            this.delSchedBtn.UseVisualStyleBackColor = true;
            this.delSchedBtn.Click += new System.EventHandler(this.delSchedBtn_Click);
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
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.delSchedBtn);
            this.Controls.Add(this.saveScheduleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sun2Box);
            this.Controls.Add(this.sat2Box);
            this.Controls.Add(this.fri2Box);
            this.Controls.Add(this.thu2Box);
            this.Controls.Add(this.wed2Box);
            this.Controls.Add(this.tue2Box);
            this.Controls.Add(this.mon2Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chooseJob);
            this.Controls.Add(this.chooseDept);
            this.Controls.Add(this.sundayBox);
            this.Controls.Add(this.saturdayBox);
            this.Controls.Add(this.fridayBox);
            this.Controls.Add(this.thursdayBox);
            this.Controls.Add(this.wednesdayBox);
            this.Controls.Add(this.tuesdayBox);
            this.Controls.Add(this.mondayBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.sun2Box.ResumeLayout(false);
            this.sat2Box.ResumeLayout(false);
            this.fri2Box.ResumeLayout(false);
            this.thu2Box.ResumeLayout(false);
            this.wed2Box.ResumeLayout(false);
            this.tue2Box.ResumeLayout(false);
            this.mon2Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.sundayBox.ResumeLayout(false);
            this.saturdayBox.ResumeLayout(false);
            this.fridayBox.ResumeLayout(false);
            this.thursdayBox.ResumeLayout(false);
            this.wednesdayBox.ResumeLayout(false);
            this.tuesdayBox.ResumeLayout(false);
            this.mondayBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postgreData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Button saveScheduleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox sun2Box;
        private System.Windows.Forms.CheckedListBox secondSunCheckedList;
        private System.Windows.Forms.GroupBox sat2Box;
        private System.Windows.Forms.CheckedListBox secondSatCheckedList;
        private System.Windows.Forms.GroupBox fri2Box;
        private System.Windows.Forms.CheckedListBox secondFriCheckedList;
        private System.Windows.Forms.GroupBox thu2Box;
        private System.Windows.Forms.CheckedListBox secondThuCheckedList;
        private System.Windows.Forms.GroupBox wed2Box;
        private System.Windows.Forms.CheckedListBox secondWedCheckedList;
        private System.Windows.Forms.GroupBox tue2Box;
        private System.Windows.Forms.CheckedListBox secondTueCheckedList;
        private System.Windows.Forms.GroupBox mon2Box;
        private System.Windows.Forms.CheckedListBox secondMonCheckedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox chooseJob;
        private System.Windows.Forms.ComboBox chooseDept;
        private System.Windows.Forms.GroupBox sundayBox;
        private System.Windows.Forms.CheckedListBox firstSunCheckedList;
        private System.Windows.Forms.GroupBox saturdayBox;
        private System.Windows.Forms.CheckedListBox firstSatCheckedList;
        private System.Windows.Forms.GroupBox fridayBox;
        private System.Windows.Forms.CheckedListBox firstFriCheckedList;
        private System.Windows.Forms.GroupBox thursdayBox;
        private System.Windows.Forms.CheckedListBox firstThuCheckedList;
        private System.Windows.Forms.GroupBox wednesdayBox;
        private System.Windows.Forms.CheckedListBox firstWedCheckedList;
        private System.Windows.Forms.GroupBox tuesdayBox;
        private System.Windows.Forms.CheckedListBox firstTueCheckedList;
        private System.Windows.Forms.GroupBox mondayBox;
        private System.Windows.Forms.CheckedListBox firstMonCheckedList;
        private System.Windows.Forms.Button delSchedBtn;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private PostgreData postgreData;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private PostgreDataTableAdapters.departmentTableAdapter departmentTableAdapter1;
        private System.Windows.Forms.BindingSource jobBindingSource1;
        private PostgreDataTableAdapters.jobTableAdapter jobTableAdapter1;
    }
}