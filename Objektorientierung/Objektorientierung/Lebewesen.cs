using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Objektorientierung
{
    public class Lebewesen
    {
        public string Name { get; set; }
        public string? Color { get; set; }
        private DateTime Birthdate { get; }

        public Lebewesen(string name, DateTime birthdate, string? color = null)
        {
            Name = name;
            Birthdate = birthdate;
            Color = color;
        }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - Birthdate.Year;
                if (Birthdate > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
