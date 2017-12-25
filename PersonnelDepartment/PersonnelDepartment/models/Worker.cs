using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment
{
    class Worker: Person
    {        
        public Job job { get; set; }
        public bool statusIsFired { get; set; }
        public string archiveData { get; set; }
        public Department dept { get; set; }
        public Schedule schedule { get; set; }

        public Worker()
        {
           
        }

        public Worker(Job _job, Department _dept, bool _isFired, string _archiveData, Schedule _schedule)
        { 
            job = _job;
            dept = _dept;
            statusIsFired = _isFired;
            archiveData = _archiveData;
            schedule = _schedule;
            
        }
    }
}
