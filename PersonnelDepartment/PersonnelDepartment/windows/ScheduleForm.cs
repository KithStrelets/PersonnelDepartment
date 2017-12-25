using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonnelDepartment
{
    public partial class ScheduleForm : Form
    {
        DBConnect dbConnect;
        List<string> listSched;
        List<CheckedListBox> cbAllControl;

        protected static string rules; static User user;
        public ScheduleForm()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        internal ScheduleForm(string _rules, User us)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            listSched = new List<string>();
            cbAllControl = new List<CheckedListBox>();
            cbAllControl.Add(firstMonCheckedList); cbAllControl.Add(firstTueCheckedList); cbAllControl.Add(firstWedCheckedList);
            cbAllControl.Add(firstThuCheckedList); cbAllControl.Add(firstFriCheckedList); cbAllControl.Add(firstSatCheckedList);
            cbAllControl.Add(firstSunCheckedList);
            cbAllControl.Add(secondMonCheckedList); cbAllControl.Add(secondTueCheckedList); cbAllControl.Add(secondWedCheckedList);
            cbAllControl.Add(secondThuCheckedList); cbAllControl.Add(secondFriCheckedList); cbAllControl.Add(secondSatCheckedList);
            cbAllControl.Add(secondSunCheckedList);
            if (_rules.Equals("admin")) us = new Administrator();
            else if (_rules.Equals("director")) us = new Director();
            else {
                us = new Secretary();
                saveScheduleBtn.Enabled = false;
                delSchedBtn.Enabled = false;
            }
            rules = _rules;
            user = us;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            this.jobTableAdapter1.Fill(this.postgreData.job);
            this.departmentTableAdapter1.Fill(this.postgreData.department);
        }

        private void saveScheduleBtn_Click(object sender, EventArgs e)
        {
            listSched.Clear();
            foreach (CheckedListBox sub in cbAllControl)
            {
                resultChecker(sub);
            }
            Department schedDept = new Department(); schedDept.id = new Guid(chooseDept.SelectedValue.ToString());
            Job schedJob = new Job(); schedJob.id = new Guid(chooseJob.SelectedValue.ToString());
            Schedule sh = new Schedule(schedDept, schedJob, listSched.ToArray());
            string where = "fk_department=" + dbConnect.Transform(sh.dept.id.ToString()) + " and fk_job=" + dbConnect.Transform(sh.job.id.ToString());
            List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("schedule", "", where));
            if (selection.Length.Equals(0))
            {
                DBConnect.SendMessageFromSocket(dbConnect.Insert("schedule", dbConnect.Transform(sh.id.ToString()), dbConnect.Transform(sh.dept.id.ToString()), dbConnect.Transform(sh.job.id.ToString()), String.Join(",", listSched)));
                MessageBox.Show("Создано новое расписание");
            }
            else
            {
                string set = "fmonday=" + sh.firstmonday + ", ftuesday=" + sh.firsttuesday +
                    ", fwednesday=" + sh.firstwednesday + ", fthursday=" + sh.firstthursday + ", ffriday=" +
                    sh.firstfriday + ", fsaturday=" + sh.firstsaturday + ", fsunday=" + sh.firstsunday +

                    ", smonday=" + sh.secondmonday + ", stuesday=" + sh.secondtuesday +
                    ", swednesday=" + sh.secondwednesday + ", sthursday=" + sh.secondthursday + ", sfriday=" +
                    sh.secondfriday + ", ssaturday=" + sh.secondsaturday + ", ssunday=" + sh.secondsunday;
                DBConnect.SendMessageFromSocket(dbConnect.Update("schedule", where, set));
                MessageBox.Show("Расписание обновлено");
            }
            ScheduleForm_Load(sender, e);
        }

        private void resultChecker(CheckedListBox cb)
        {
            List<string> checkText = new List<string>();
            foreach (object itemChecked in cb.Items)
            {
                if (cb.GetItemChecked(cb.Items.IndexOf(itemChecked))) checkText.Add(itemChecked.ToString());
                else
                {
                    checkText.Add("none");
                }
            }
            listSched.Add(dbConnect.Transform(String.Join(",", checkText)));
        }

        private void chooseDept_DropDownClosed(object sender, EventArgs e)
        {
            Guid deptId = new Guid(chooseDept.SelectedValue.ToString());
            List<string[]> selectedDays = new List<string[]>();
            if (chooseJob.SelectedItem != null)
            {
                string where = "fk_department=" + dbConnect.Transform(chooseDept.SelectedValue.ToString()) + " and fk_job=" + dbConnect.Transform(chooseJob.SelectedValue.ToString());
                List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("schedule", "", where));
                if (!selection.Length.Equals(0))
                {
                    for (int a = 3; a < selection[0].Count; a++)
                    {
                        selectedDays.Add(selection[0][a].Split(','));
                    }
                    int countCB = 0;
                    foreach (string[] sub in selectedDays)
                    {
                        for (int a = 0; a < 3; a++)
                        {
                            if (sub[a].Equals("none")) cbAllControl[countCB].SetItemChecked(a, false);
                            else
                            {
                                cbAllControl[countCB].SetItemChecked(a, true);
                            }
                        }
                        countCB++;
                    }
                }
                else {
                    MessageBox.Show("Для вашего запроса расписание ещё не назначено");
                    foreach (CheckedListBox sub in cbAllControl)
                    {
                        for (int a = 0; a < sub.Items.Count; a++)
                        {
                            sub.SetItemChecked(a, false);
                        }
                    }
                }
            }
        }

        private void chooseJob_DropDownClosed(object sender, EventArgs e)
        {
            Guid jobId = new Guid(chooseJob.SelectedValue.ToString());
            List<string[]> selectedDays = new List<string[]>();
            if (chooseDept.SelectedItem != null)
            {
                string where = "fk_department=" + dbConnect.Transform(chooseDept.SelectedValue.ToString()) + " and fk_job=" + dbConnect.Transform(chooseJob.SelectedValue.ToString());
                List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("schedule", "", where));
                if (!selection.Length.Equals(0))
                {
                    for (int a = 3; a < selection[0].Count; a++)
                    {
                        selectedDays.Add(selection[0][a].Split(','));
                    }
                    int countCB = 0;
                    foreach (string[] sub in selectedDays)
                    {
                        for (int a = 0; a < 3; a++)
                        {
                            if (sub[a].Equals("none")) cbAllControl[countCB].SetItemChecked(a, false);
                            else
                            {
                                cbAllControl[countCB].SetItemChecked(a, true);
                            }
                        }
                        countCB++;
                    }
                }
                else
                {
                    MessageBox.Show("Для вашего запроса расписание ещё не назначено");
                    foreach (CheckedListBox sub in cbAllControl)
                    {
                        for (int a = 0; a < sub.Items.Count; a++)
                        {
                            sub.SetItemChecked(a, false);
                        }
                    }
                }
            }
        }

        private void delSchedBtn_Click(object sender, EventArgs e)
        {
            Department schedDept = new Department(); schedDept.id = new Guid(chooseDept.SelectedValue.ToString());
            Job schedJob = new Job(); schedJob.id = new Guid(chooseJob.SelectedValue.ToString());
            Schedule delSched = new Schedule();
            delSched.dept = schedDept; delSched.job = schedJob;
            string where = "fk_department=" + dbConnect.Transform(delSched.dept.id.ToString()) + " and fk_job=" + dbConnect.Transform(delSched.job.id.ToString());
            List<string>[] selection = DBConnect.SendMessageFromSocket(dbConnect.Select("schedule", "", where));
            if (!selection.Length.Equals(0))
            {
                DBConnect.SendMessageFromSocket(dbConnect.Delete("schedule", where));
                MessageBox.Show("Расписание удалено");
                foreach (CheckedListBox sub in cbAllControl)
                {
                    for (int a = 0; a < sub.Items.Count; a++)
                    {
                        sub.SetItemChecked(a, false);
                    }
                }
            }
            else MessageBox.Show("Для вашего запроса расписание ещё не назначено");
            ScheduleForm_Load(sender, e);
        }
    }
}
