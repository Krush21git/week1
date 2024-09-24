
using System.Drawing;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public abstract class Shape : IShape
    {
        private int area;

        public void SetArea(int Area)
        {
            area = Area;
        }

        public abstract double GetArea();


        public string Colour { get; set; }


        public virtual void Display()
        {
            Console.WriteLine($"This shape is {Colour}.");
        }
    }
}
