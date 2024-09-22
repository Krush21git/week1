// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;

var square = new Square(10);

try
{


    square.SetArea(2);


    Console.WriteLine("The area of Square is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}




var circle = new Circle(4);

Console.WriteLine(" The area of Circle is " + circle.GetArea());

ShapeColourHelper.AddColour(circle);


ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);


Console.ReadLine();




