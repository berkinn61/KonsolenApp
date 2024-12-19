using System;
using Objektorientierung;

Tierheim tierheim = new Tierheim();
List<Animal> cat = new List<Animal>();
 
tierheim.AddAnimal(new Cat("Mario", "rot", new DateTime(2020, 3, 19)));
tierheim.AddAnimal(new Cat("Luigi", "grün", new DateTime(2019, 7, 25)));
 
tierheim.AddAnimal(new Dog("Kitten", "braun", new DateTime(2017, 6, 5)));
tierheim.AddAnimal(new Dog("Puppy", "schwarz", new DateTime(2021, 1, 20)));
 
 
Console.WriteLine($"Gesamte Tieranzahl im Tierheim: {tierheim.GetAnimalCount()}");
Console.WriteLine($"Anzahl der Katzen im Tierheim: {tierheim.NumberOfCats()}");
Console.WriteLine($"Anzahl der Hunde im Tierheim: {tierheim.NumberOfDogs()}");
 
Console.WriteLine($"\nDurchschnittsalter aller Tiere: {tierheim.GetAverageAge():0.00} Jahre");
 
Console.WriteLine("\nTiere im Tierheim:");
foreach (var animal in tierheim.GetAllAnimals())
{
    Console.WriteLine($"Tier: Art = {animal.GetType().Name}, Name = {animal.Name}, Beine = {animal.Beine}");
}
 
Console.WriteLine("\nLaute der Tiere:");
foreach (var animal in tierheim.GetAllAnimals())
{
    animal.GibTypischenLautVonDir();
}   