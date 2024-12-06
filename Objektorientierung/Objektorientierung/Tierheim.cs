using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientierung
{
    class Tierheim
    {
        public List<Animal> tiere = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            tiere.Add(animal);
            Console.WriteLine($"\nEs wurde neues {animal.TierTyp} {animal} hinzugefügt!\n");
        }
        public void ShowAnimals()
        {
            int index = 1;
            foreach (var cat in tiere)
            {
                Console.WriteLine(cat);
            }
        }
        public int NumberOfCats
        {
            get { return tiere.Select(a => a.GetType() == typeof(Cat)).Count(); }
        }

        public int NumberOfDogs
        {
            get { return tiere.Select(a => a.GetType() == typeof(Dog)).Count(); }
        }
    }
}
