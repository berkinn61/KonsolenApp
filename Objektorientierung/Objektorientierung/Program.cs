using System;
using Objektorientierung;
 
class Program
{
    static void Main()
    {
        Tierheim tierheim = new Tierheim();
 
        Cat cat1 = new Cat("Kitty", new DateTime(2015, 12, 09), "black");
        Cat cat2 = new Cat("Max", new DateTime(2019, 12, 11), "orange");
        Cat cat3 = new Cat("Hans", new DateTime(2024, 01, 12), "gray");
 
        tierheim.AddCat(cat1);
        tierheim.AddCat(cat2);
        tierheim.AddCat(cat3);
 
        Console.WriteLine($"Anzahl der Katzen im Tierheim: {tierheim.CatCount}");
        tierheim.ShowAllCats();
 
        Console.ReadLine();
    }
}