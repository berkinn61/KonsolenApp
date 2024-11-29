using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
 
namespace Objektorientierung;
 
class Cat : Animal
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
 
    public Cat(string name, DateTime birthDate, string color) : base(color)
    {
        Name = name;
        BirthDate = birthDate;
    }
 
    public int Age
    {
        get
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }
}
 
class Tierheim
{
    private List<Cat> cats = new List<Cat>();
 
    public void AddCat(Cat cat)
    {
        cats.Add(cat);
    }
 
    public int CatCount
    {
        get { return cats.Count; }
    }
 
    public void ShowAllCats()
    {
        foreach (var cat in cats)
        {
            Console.WriteLine($"Name: {cat.Name}, Farbe: {cat.Color}, Alter: {cat.Age} Jahre");
        }
    }
}