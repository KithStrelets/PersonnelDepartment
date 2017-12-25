using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonnelDepartment
{
    public partial class JobForm : Form
    {
        Job targetJob { get; set; }
        private DBConnect dbConnect;
        protected static string rules; static User user;

        public JobForm()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        internal JobForm(string _rules, User us)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            if (_rules.Equals("admin")) us = new Administrator();
            else if (_rules.Equals("director")) us = new Director();
            else {
                us = new Secretary();
                addJobBtn.Enabled = false;
                deleteJobBtn.Enabled = false;
                saveJobBtn.Enabled = false;
            }
            rules = _rules;
            user = us;
        }

        private void addJobBtn_Click(object sender, EventArgs e)
        {
            if (rankCB.Text.Equals("") || jobName.Text.Equals("")) MessageBox.Show("Поле названия должности или разряда должности пустое");
            else {
                Job newJob = new Job(jobName.Text, (string)rankCB.Text, (int)salaryRank.Value);
                string where = "name=" + dbConnect.Transform(newJob.jobName) + " and salary=" + dbConnect.Transform(newJob.salary.ToString());
                List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("job", "", where));
                if (selection.Length.Equals(0))
                {
                    DBConnect.SendMessageFromSocket(dbConnect.Insert("job", dbConnect.Transform(newJob.id.ToString()), dbConnect.Transform(newJob.jobName), dbConnect.Transform(newJob.jobRank), dbConnect.Transform(newJob.salary.ToString()), dbConnect.Transform(String.Join(", ", newJob.workers))));
                    JobForm_Load(sender, e);
                }
                else { MessageBox.Show("Такая должность уже существует"); }
                jobName.Clear();
            }
        }

        private void deleteJobBtn_Click(object sender, EventArgs e)
        {
            Job delJob = new Job(chooseJob.Text, (string)rankCB.SelectedItem, (int)salaryRank.Value);
            delJob.id = new Guid(chooseJob.SelectedValue.ToString());
            string where = "idjob=" + dbConnect.Transform(delJob.id.ToString());
            DBConnect.SendMessageFromSocket(dbConnect.Delete("job", where));

            JobForm_Load(sender, e);
        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            this.jobTableAdapter1.Fill(this.postgreData.job);
        }

        private void chooseJob_DropDownClosed(object sender, EventArgs e)
        {
            try {
                string where = "idjob=" + dbConnect.Transform(chooseJob.SelectedValue.ToString());
                List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("job", "", where));
                salaryRank.Value = Int32.Parse(selection[0][3]); rankCB.Text = selection[0][2];
                targetJob = new Job(chooseJob.Text, (string)rankCB.SelectedItem, (int)salaryRank.Value);
            }
            catch (NullReferenceException) { }
        }

        private void saveJobBtn_Click(object sender, EventArgs e)
        {
            if (rankCB.Text.Equals("") || jobName.Text.Equals("")) MessageBox.Show("Поле названия должности или разряда должности пустое");
            else {
                Job changeJob = new Job(jobName.Text, (string)rankCB.SelectedItem, (int)salaryRank.Value);
                string where = "name=" + dbConnect.Transform(targetJob.jobName) + " and salary=" + dbConnect.Transform(targetJob.salary.ToString()) + " and jobrank=" + dbConnect.Transform(targetJob.jobRank);
                string set = "name=" + dbConnect.Transform(changeJob.jobName) + ", jobrank=" + dbConnect.Transform(changeJob.jobRank) + ", salary=" + dbConnect.Transform(changeJob.salary.ToString()) + ", workerslist=" + dbConnect.Transform(String.Join(", ", changeJob.workers));
                string wheresearch = "name=" + dbConnect.Transform(changeJob.jobName) + " and salary=" + dbConnect.Transform(changeJob.salary.ToString());
                List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("job", "", wheresearch));
                if (selection.Length > 0)
                { MessageBox.Show("Вы пытаетесь обновить должность до такой, которая уже существует"); }
                else DBConnect.SendMessageFromSocket(dbConnect.Update("job", where, set));

                JobForm_Load(sender, e);
            }
        }
    }
}
