using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonnelDepartment
{
    public partial class OperationsForm : Form
    {
        DBConnect dbConnect;

        public OperationsForm()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        protected static string rules; static User user;
        internal OperationsForm(User us, string _rules)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            if (_rules.Equals("admin")) us = new Administrator();
            else if (_rules.Equals("director")) us = new Director();
            else {
                us = new Secretary();
                minusPersonBtn.Enabled = false;
                plusPersonBtn.Enabled = false;
                DeptBtn.Enabled = false;
                jobBtn.Enabled = false;
            }
            rules = _rules;
            user = us;
        }

        DepartmentForm dept = new DepartmentForm();
        private void DeptBtn_Click(object sender, EventArgs e)
        {
            dept.Close();
            dept = new DepartmentForm(rules, user);
            dept.Show();
        }

        PersonForm pers = new PersonForm();
        private void plusPersonBtn_Click(object sender, EventArgs e)
        {
            pers.Close();
            pers = new PersonForm(rules, user);
            pers.Show();
        }

        private void editPersonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                pers.Close();

                Worker transfer = new Worker();

                string item = infTable.SelectedRows[0].Cells[0].Value.ToString();
                string where = "idperson=" + dbConnect.Transform(item);
                List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("person", "", where));

                transfer.id = new Guid(selection[0][0]);
                transfer.name = selection[0][1];
                transfer.gender = selection[0][2];
                transfer.dateBirth = Convert.ToDateTime(selection[0][3]);
                transfer.married = Convert.ToBoolean(Convert.ToInt32(selection[0][4]));
                transfer.photo = selection[0][5];
                Department transfDept = new Department(); if (selection[0][6].Equals("")) transfDept.id = new Guid();
                else
                { transfDept.id = new Guid(selection[0][6]); }
                transfer.dept = transfDept;
                Job transfJob = new Job(); if (selection[0][7].Equals("")) transfJob.id = new Guid();
                else
                { transfJob.id = new Guid(selection[0][7]); }
                transfer.job = transfJob;
                transfer.statusIsFired = Convert.ToBoolean(Convert.ToInt32(selection[0][8]));
                transfer.archiveData = selection[0][9];
                Schedule transfSched = new Schedule(); if (selection[0][10].Equals("")) transfSched.id = new Guid();
                else
                { transfSched.id = new Guid(selection[0][10]); }
                transfer.schedule = transfSched;
                pers = new PersonForm(transfer, rules, user);
                pers.Show();
            }
            catch (Exception) { MessageBox.Show("Выделите всю строку"); }
        }

        JobForm job = new JobForm();
        private void jobBtn_Click(object sender, EventArgs e)
        {
            job.Close();
            job = new JobForm(rules, user);
            job.Show();
        }

        private void OperationsForm_Load(object sender, EventArgs e)
        {
            this.personTableAdapter1.Fill(this.postgreData.person);
        }

        private void minusPersonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string where = "idperson= " + dbConnect.Transform(infTable.SelectedRows[0].Cells[0].Value.ToString());
                List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("person", "", where));
                DBConnect.SendMessageFromSocket(dbConnect.Delete("person", where));
            }
            catch (Exception) { MessageBox.Show("Выделите всю строку"); };
            OperationsForm_Load(sender, e);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (rules.Equals("admin")) { Administrator report = new Administrator(); report.username = user.username; report.Report(infTable, user); }
            else if (rules.Equals("director")) { Director report = new Director(); report.username = user.username; report.Report(infTable, user); }
            else { Secretary report = new Secretary(); report.username = user.username; report.Report(infTable, user); }
            Cursor = Cursors.Default;
        }
    }
}

