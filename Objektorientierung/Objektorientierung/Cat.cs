using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung
{
    class Cat
    {
        private string _Color;
        private DateTime _BirthDate;

        public string Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - _BirthDate.Year;
                if (_BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public Cat(DateTime birthdate)
        {
            _BirthDate = birthdate;
        }
    }
}