using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape
    {
        private int side1;
        public Circle(int s1)
        {
            side1 = s1;
        }
        public override int GetArea()
        {
            return (int)(3.14 * side1 * side1);
        }
    }

}
