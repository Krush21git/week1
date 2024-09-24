using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Triangle : Shape, IFaces
    {
        public double Base { get; set; }
        public double Height {  get; set; }


        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
        }

        public override double GetArea()
        {
            return (Base * Height) / 2;
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }
    }
}
