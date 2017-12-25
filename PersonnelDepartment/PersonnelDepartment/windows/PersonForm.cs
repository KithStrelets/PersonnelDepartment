using PersonnelDepartment.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PersonnelDepartment
{
    public partial class PersonForm : Form
    {
        private DBConnect dbConnect;
        private string pathPhoto;
        private List<string> jobsArchive;
        Worker transferWorker;

        protected static string rules; static User user;
        public PersonForm()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        internal PersonForm(string _rules, User us)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            jobsArchive = new List<string>();
            pathPhoto = "";
            if (_rules.Equals("admin")) us = new Administrator();
            else if (_rules.Equals("director")) us = new Director();
            else {
                us = new Secretary();
                recruitPerson.Enabled = false;
                firePerson.Enabled = false;
                updatePersBtn.Enabled = false;
                addArchiveBtn.Enabled = false;
                clearArchiveBtn.Enabled = false;
            }
            rules = _rules;
            user = us;
        }

        internal PersonForm(Worker _worker, string _rules, User us)
        {
            if (_rules.Equals("admin")) us = new Administrator();
            else if (_rules.Equals("director")) us = new Director();
            else
            {
                us = new Secretary();
                recruitPerson.Enabled = false;
                firePerson.Enabled = false;
                updatePersBtn.Enabled = false;
                addArchiveBtn.Enabled = false;
                clearArchiveBtn.Enabled = false;
            }
            rules = _rules;
            user = us;
            transferWorker = _worker;
            InitializeComponent();
            dbConnect = new DBConnect();
            persName.Text = transferWorker.name.Split(' ')[1].ToString();
            persSurname.Text = transferWorker.name.Split(' ')[0].ToString();
            persFatherName.Text = transferWorker.name.Split(' ')[2].ToString();
            if (transferWorker.gender.Equals("female")) persFemale.Checked = true;
            else persMale.Checked = true;
            persBirthDate.Value = transferWorker.dateBirth;
            persMarried.Checked = transferWorker.married;
            try
            {
                if (transferWorker.photo != null) persPic.Image = Image.FromFile(transferWorker.photo.Replace('/', '\\'));
            }
            catch (Exception) { persPic.Image = Resources.nophoto; }
            if (transferWorker.statusIsFired) { statusFired.Checked = true; }
            else statusWorking.Checked = true;
            jobsArchive = transferWorker.archiveData.Split(',').ToList();
            for (int a = 0; a < jobsArchive.Count; a++)
            {
                persArchive.Items.Add(jobsArchive[a]);
            }
        }

        private void persPic_Click(object sender, EventArgs e)
        {
            try
            {
                if (choosePicFile.ShowDialog() == DialogResult.OK)
                {
                    pathPhoto = choosePicFile.FileName;
                }
                persPic.Image = (pathPhoto != null) ? Image.FromFile(pathPhoto) : Image.FromHbitmap(Resources.nophoto.GetHbitmap());
            }
            catch (ArgumentException) { }

        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            this.jobTableAdapter1.Fill(this.postgreData.job);
            this.departmentTableAdapter1.Fill(this.postgreData.department);
        }

        private void addArchiveBtn_Click(object sender, EventArgs e)
        {
            string res = "Компания: " + persArchiveCompany.Text + " Должность: " + persArchiveJob.Text + "(" + persArchiveJobRank.Text + ")" + " " + persArchiveJobStart.Value.ToShortDateString() + "-" + persArchiveJobEnd.Value.ToShortDateString();
            persArchive.Items.Add(res);
            jobsArchive.Add(res);
        }

        private void clearArchiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                jobsArchive.RemoveAt(persArchive.SelectedIndex);
                persArchive.Items.Remove(persArchive.SelectedItem);
            }
            catch (Exception) { }
        }

        private void recruitPerson_Click(object sender, EventArgs e)
        {
            string fullname = persSurname.Text + " " + persName.Text + " " + persFatherName.Text;
            string persGender = "";
            if (persMale.Checked) persGender = "male";
            if (persFemale.Checked) persGender = "female";
            Person newPerson = new Person(fullname, persGender, persBirthDate.Value, persMarried.Checked, pathPhoto);
            Worker newWorker = new Worker();
            newWorker.id = newPerson.id; newWorker.name = newPerson.name; newWorker.gender = newPerson.gender; newWorker.dateBirth = newPerson.dateBirth;
            newWorker.married = newPerson.married; if (persPic != null) newWorker.photo = newPerson.photo.Replace('\\', '/');
            newWorker.archiveData = dbConnect.Transform(String.Join(",", jobsArchive));
            Department pDept = new Department(); pDept.id = new Guid(presentDept.SelectedValue.ToString());
            Job pJob = new Job(); pJob.id = new Guid(presentJob.SelectedValue.ToString()); pJob.jobRank = presentJobRank.SelectedText;
            newWorker.dept = pDept; newWorker.job = pJob;
            string where = "fk_department=" + dbConnect.Transform(newWorker.dept.id.ToString()) + " and fk_job=" + dbConnect.Transform(newWorker.job.id.ToString());
            Schedule workSched = new Schedule();
            List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("schedule", "", where));
            if (!selection.Length.Equals(0))
            {
                workSched.id = new Guid(selection[0][0]);
                workSched.job = pJob;
                workSched.dept = pDept;
                newWorker.schedule = workSched;
                newWorker.statusIsFired = false;
                if (!statusWorking.Checked) { statusWorking.Checked = true; }
                User newUser = new User();
                where = "iddept=" + dbConnect.Transform(newWorker.dept.id.ToString());
                List<string>[] checkdept = DBConnect.SendMessageFromSocket(dbConnect.Select("department", "", where));
                newWorker.dept.departmentName = checkdept[0][1];
                if (newWorker.dept.departmentName.Equals("Personnel"))
                {
                    newUser.username = persSurname.Text;
                    newUser.passGen();
                }
                else { newUser.username = ""; newUser.password = ""; }
                where = "name=" + dbConnect.Transform(newWorker.name);
                List<string>[] check = DBConnect.SendMessageFromSocket(dbConnect.Select("person", "", where));
                if (check.Length.Equals(0))
                {
                    List<string>[] checkRules = DBConnect.SendMessageFromSocket(dbConnect.Select("job", "", "idjob=" + dbConnect.Transform(newWorker.job.id.ToString())));
                    if (checkRules[0][1].Equals("Director") & rules.Equals("director")) MessageBox.Show("Вы не можете назначать глав отделов");
                    else {
                        DBConnect.SendMessageFromSocket(dbConnect.Insert("person", dbConnect.Transform(newWorker.id.ToString()), dbConnect.Transform(newWorker.name), dbConnect.Transform(newWorker.gender), dbConnect.Transform(newWorker.dateBirth.ToString("yyyy-MM-dd"))
                            , dbConnect.Transform(dbConnect.BoolToTiny(newWorker.married)), dbConnect.Transform(newWorker.photo), dbConnect.Transform(newWorker.dept.id.ToString()), dbConnect.Transform(newWorker.job.id.ToString()),
                            dbConnect.Transform(dbConnect.BoolToTiny(newWorker.statusIsFired)), newWorker.archiveData, dbConnect.Transform(newWorker.schedule.id.ToString()), dbConnect.Transform(newUser.username), dbConnect.Transform(newUser.password)));
                        persName.Clear(); persSurname.Clear(); persFatherName.Clear();
                        jobsArchive.Clear();
                    }
                }
                else { MessageBox.Show("Такой сотрудник есть в базе"); }
            }
            else { MessageBox.Show("Расписание для данной должности еще не назначено"); }
        }

        private void firePerson_Click(object sender, EventArgs e)
        {
            Worker fireWorker = new Worker();
            fireWorker.name = persSurname.Text + " " + persName.Text + " " + persFatherName.Text;
            statusFired.Checked = true;
            fireWorker.statusIsFired = statusFired.Checked;
            string where = "name=" + dbConnect.Transform(fireWorker.name);
            List<string>[] check = DBConnect.SendMessageFromSocket(dbConnect.Select("person", "", where));
            if (!check.Length.Equals(0))
            {
                fireWorker.id = new Guid(check[0][0]);
                where = "idperson= " + dbConnect.Transform(fireWorker.id.ToString());
                string set = "isfired =" + dbConnect.Transform(dbConnect.BoolToTiny(fireWorker.statusIsFired));
                DBConnect.SendMessageFromSocket(dbConnect.Update("person", where, set));
            }
            else MessageBox.Show("Такого сотрудника нет в базе");
        }

        private void updatePersBtn_Click(object sender, EventArgs e)
        {
            Worker updWorker = new Worker();
            try
            {
                updWorker.name = persSurname.Text + " " + persName.Text + " " + persFatherName.Text;

                string where = "name=" + dbConnect.Transform(updWorker.name);
                string persGender = "";
                if (persMale.Checked) persGender = "male";
                if (persFemale.Checked) persGender = "female";
                updWorker.gender = persGender; updWorker.dateBirth = persBirthDate.Value;
                updWorker.married = persMarried.Checked;
                updWorker.photo = transferWorker.photo;
                try
                {
                    if (pathPhoto != null) updWorker.photo = pathPhoto.Replace('\\', '/');
                }
                catch (ArgumentException) { }
                updWorker.archiveData = dbConnect.Transform(String.Join(",", jobsArchive));
                Department pDept = new Department(); pDept.id = new Guid(presentDept.SelectedValue.ToString());
                Job pJob = new Job(); pJob.id = new Guid(presentJob.SelectedValue.ToString()); pJob.jobRank = presentJobRank.SelectedText;
                updWorker.dept = pDept; updWorker.job = pJob;
                where = "fk_department=" + dbConnect.Transform(updWorker.dept.id.ToString()) + " and fk_job=" + dbConnect.Transform(updWorker.job.id.ToString());
                Schedule workSched = new Schedule();
                List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("schedule", "", where));
                if (!selection.Length.Equals(0))
                {
                    workSched.id = new Guid(selection[0][0]);
                    workSched.job = pJob;
                    workSched.dept = pDept;

                    updWorker.schedule = workSched;
                    updWorker.statusIsFired = false;
                    if (!statusWorking.Checked) statusWorking.Checked = true;
                    User newUser = new User();
                    newUser.username = persSurname.Text;
                    if (!transferWorker.name.Equals(updWorker.name))
                    {
                        where = "name=" + dbConnect.Transform(updWorker.name);
                        List<string>[] check = DBConnect.SendMessageFromSocket(dbConnect.Select("person", "", where));
                        if (!check.Length.Equals(0)) MessageBox.Show("Такой сотрудник есть в базе");
                        else
                        {
                            List<string>[] checkRules = DBConnect.SendMessageFromSocket(dbConnect.Select("job", "", "idjob=" + dbConnect.Transform(updWorker.job.id.ToString())));
                            if (checkRules[0][1].Equals("Director") & rules.Equals("director")) MessageBox.Show("Вы не можете назначать глав отделов");
                            else {
                                where = "idperson=" + dbConnect.Transform(transferWorker.id.ToString());
                                string set = "name=" + dbConnect.Transform(updWorker.name) + ", gender=" + dbConnect.Transform(updWorker.gender) + ", birthdate=" + dbConnect.Transform(updWorker.dateBirth.ToString("yyyy-MM-dd")) + ", married=" + dbConnect.Transform(dbConnect.BoolToTiny(updWorker.married)) +
                                    ", photo=" + dbConnect.Transform(updWorker.photo) + ", fk_department=" + dbConnect.Transform(updWorker.dept.id.ToString()) + ", fk_job=" + dbConnect.Transform(updWorker.job.id.ToString()) + ", archive=" + updWorker.archiveData +
                                    ", fk_workerschedule=" + dbConnect.Transform(updWorker.schedule.id.ToString()) + ", username=" + dbConnect.Transform(newUser.username);
                                DBConnect.SendMessageFromSocket(dbConnect.Update("person", where, set));
                                jobsArchive.Clear();
                                MessageBox.Show("Данные обновлены");
                            }
                        }
                    }
                    else {
                        List<string>[] checkRules = DBConnect.SendMessageFromSocket(dbConnect.Select("job", "", "idjob=" + dbConnect.Transform(updWorker.job.id.ToString())));
                        if (checkRules[0][1].Equals("Director") & rules.Equals("director")) MessageBox.Show("Вы не можете назначать глав отделов");
                        else {
                            where = "idperson=" + dbConnect.Transform(transferWorker.id.ToString());
                            string set = "name=" + dbConnect.Transform(updWorker.name) + ", gender=" + dbConnect.Transform(updWorker.gender) + ", birthdate=" + dbConnect.Transform(updWorker.dateBirth.ToString("yyyy-MM-dd")) + ", married=" + dbConnect.Transform(dbConnect.BoolToTiny(updWorker.married)) +
                                ", photo=" + dbConnect.Transform(updWorker.photo) + ", fk_department=" + dbConnect.Transform(updWorker.dept.id.ToString()) + ", fk_job=" + dbConnect.Transform(updWorker.job.id.ToString()) + ", archive=" + updWorker.archiveData +
                                ", fk_workerschedule=" + dbConnect.Transform(updWorker.schedule.id.ToString()) + ", username=" + dbConnect.Transform(newUser.username);
                            DBConnect.SendMessageFromSocket(dbConnect.Update("person", where, set));
                            jobsArchive.Clear();
                            MessageBox.Show("Данные обновлены");
                        }
                    }
                }
                else { MessageBox.Show("Расписание для данной должности еще не назначено"); }
            }
            catch (Exception) { }
        }

        private void fillJobRanksToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter1.FillJobRanks(this.postgreData.job);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
