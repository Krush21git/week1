
using System;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {
        private static readonly List<string> colours = new List<string> { "Yellow", "Red", "Blue", "Green", "orange"};
        private static Random random = new Random();
        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = GetRandomColor();
            return s;
        }

        public static Shape ChangeColour(Shape s, Shape s1)
        {
            s.Colour = GetRandomColor();
            s1.Colour = GetRandomColor();
            return s;
        }

        // Helper method to get a random color from the list
        public static string GetRandomColor()
        {
            int randomIndex = random.Next(colours.Count); // Get a random index
            return colours[randomIndex]; // Return the color at the random index
        }

        // Generate an array of shapes with random colors
        public static Shape[] GenerateShapesWithRandomColors(int numberOfShapes)
        {
            Shape[] shapes = new Shape[numberOfShapes];
            for (int i = 0; i < numberOfShapes; i++)
            {
                Shape newShape = new Rectangle();
                ChangeColour(newShape); // Assign a random color
                shapes[i] = newShape;
            }
            return shapes;
        }
    }
}
