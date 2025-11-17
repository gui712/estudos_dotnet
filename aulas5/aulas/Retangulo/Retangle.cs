using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retangulo
{
    public class Retangle
    {
        public double Width;
        public double Height;
        public double Area()
        {
            return Width * Height;
        }
        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }

        public override string ToString()
        {
            return "Area: "
                + Area()
                + "\nPerimeter: "
                + Perimeter()
                + "\nDiagonal: "
                + Diagonal();
        }
        
    }
}