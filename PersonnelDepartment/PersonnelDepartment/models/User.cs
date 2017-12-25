using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment
{
     class User: Worker
    {
        public string username { get; set; }
        public string password { get; set; }

        public User()
        {

        }

        internal virtual string sendRules()
        {
            string res = "";
            return res;
        }  

        public string passGen()
        {
            Random rnd = new Random();
            char[] arr = new char[6];
            for (int i = 0; i < arr.Length; i++)
            {
                char symb = (char)rnd.Next(33, 125);
                if (Char.IsLetterOrDigit(symb)) arr[i] = symb;
                else { i--; }
            }            
            password = String.Join("", arr);
            return password;
        }
    }
}
