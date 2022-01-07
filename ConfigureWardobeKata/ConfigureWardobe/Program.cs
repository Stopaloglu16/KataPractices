// See https://aka.ms/new-console-template for more information
using ConfigureWardobe;

Console.WriteLine("Hello, World!");


WardrobeOptions myWardrobes = new WardrobeOptions();


var myList = Calculate.CalculateBySize(myWardrobes, 225);

foreach (var item in myList)
{
    Console.WriteLine(item);
}



