using System;

namespace PersonnelDepartment
{
    class Schedule
    {
        public Guid id { get; set; }
        public Department dept { get; set; }
        public Job job { get; set; }
        public string schedulename { get { return schedulename; } set { schedulename = dept.departmentName + " " + job.jobName; } }

        public string firstmonday { get; set; }
        public string firsttuesday { get; set; }
        public string firstwednesday { get; set; }
        public string firstthursday { get; set; }
        public string firstfriday { get; set; }
        public string firstsaturday { get; set; }
        public string firstsunday { get; set; }

        public string secondmonday { get; set; }
        public string secondtuesday { get; set; }
        public string secondwednesday { get; set; }
        public string secondthursday { get; set; }
        public string secondfriday { get; set; }
        public string secondsaturday { get; set; }
        public string secondsunday { get; set; }

        public Schedule()
        {
            id = Guid.NewGuid();
        }
        
        public Schedule(Department _dept, Job _job, params string[] ps)
        {
            id = Guid.NewGuid();
            dept = _dept;
            job = _job;

            firstmonday = ps[0];
            firsttuesday = ps[1];
            firstwednesday = ps[2];
            firstthursday = ps[3];
            firstfriday = ps[4];
            firstsaturday = ps[5];
            firstsunday = ps[6];

            secondmonday = ps[7];
            secondtuesday = ps[8];
            secondwednesday = ps[9];
            secondthursday = ps[10];
            secondfriday = ps[11];
            secondsaturday = ps[12];
            secondsunday = ps[13];
        }
    }
}
