using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    class Person
    {
        private DateTime _birthdate;

        public void setBirthdate(DateTime birthdate)
        {

            _birthdate = birthdate;
        }

        public DateTime getDate()
        {
            return _birthdate;
        }
    }

}

