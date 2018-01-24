using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    class Person
    {
        private string _name;
        private string _surname;
        private DateTime _birthdate;

        public void setBirthdate(string name, string surname, DateTime birthdate)
        {

            _birthdate = birthdate;
            _name = name;
            _surname = surname;
        }

        public string getDate()
        {
            string details;
            details = _name + " " + _surname + " " + _birthdate.ToShortDateString();

            return details;
        }
    }

}

