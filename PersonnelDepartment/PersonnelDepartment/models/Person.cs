using System;

namespace PersonnelDepartment
{
    internal class Person
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public DateTime dateBirth { get; set; }
        public bool married { get; set; }
        public string photo { get; set; }

        public Person()
        {
            id = Guid.NewGuid();
        }

        public Person(string _name, string _gender, DateTime _birthdate, bool _married, string _photo)
        {
            id = Guid.NewGuid();
            name = _name;
            gender = _gender;
            dateBirth = _birthdate;
            married = _married;
            photo = _photo;
        }
    }
}
