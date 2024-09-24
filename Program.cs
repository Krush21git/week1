// See https://aka.ms/new-console-template for more information
using System.Drawing;
using Week1ObjectOriented.Classes;
using Week1ObjectOriented.Interfaces;


Console.WriteLine(" Create a new interface called IShape that is implemented by all shapes in the application and called GetArea()");

Console.WriteLine();

Shape circle1 = new Circle(5);
Console.WriteLine(" The area of Circle is " + circle1.GetArea());

Shape square1 = new Square(5);
Console.WriteLine(" The area of Square is " + square1.GetArea());

Shape triangle1 = new Triangle(5, 6);
Console.WriteLine(" The area of Triangle is " + triangle1.GetArea());
Console.WriteLine();



Console.WriteLine(" Extend the console application to generate an array of shapes that all have colours");
Console.WriteLine();


int numberOfShapes = 3;
Shape[] shapes = ShapeColourHelper.GenerateShapesWithRandomColors(numberOfShapes);

// Display each shape's color
for (int i = 0; i < shapes.Length; i++)
{
    Console.WriteLine($"Shape {i + 1}:");
    shapes[i].Display();

}
Console.ReadLine();