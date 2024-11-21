// See https://aka.ms/new-console-template for more information
using Objektorientierung;

Console.WriteLine("Hello, World!");

Cat myCat = new Cat(new DateTime(2007, 11, 11));
myCat.Color = "black";
Console.WriteLine("The color of my Cat is " + myCat.Color);
Console.WriteLine("The age of my Cat is " + myCat.Age + " years.");