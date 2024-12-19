namespace Objektorientierung
{
    public class Tierheim
    {
        private List<Animal> _animals;

        public Tierheim()
        {
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }
        public void AddCat(Cat cat)
        {
            _animals.Add(cat);
        }
        public void AddDog(Dog dog)
        {
            _animals.Add(dog);
        }
        public List<Animal> GetAllAnimals()
        {
            return _animals;
        }
        public int GetAnimalCount()
        {
            return _animals.Count;
        }
        public int NumberOfCats()
        {
            return _animals.OfType<Cat>().Count();
        }
        public int NumberOfDogs()
        {
            return _animals.OfType<Dog>().Count();
        }
        public void ListCatsByAge()
        {
            var cats = _animals.OfType<Cat>();
            foreach (var cat in cats)
            {
                Console.WriteLine($"Katze: Name = {cat.Name}, Farbe = {cat.Color}, Alter = {cat.Age} Jahre");
            }
        }
    }
}