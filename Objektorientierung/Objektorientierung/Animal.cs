using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Objektorientierung
{
    public class Animal : Lebewesen
    {
        public int Beine { get; set; }

        public Animal(string name, DateTime geburtsdatum) : base(name, geburtsdatum)
        {
        }
        public virtual void GibTypischenLautVonDir()
        {
            Console.WriteLine("Laut des Tieres.");
        }
    }
}


 
