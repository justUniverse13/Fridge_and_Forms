using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    class Rectangle:Frame
    {
        public double HeightWidthDiagonal => Diagonal(Height, Width);
        public double Height { get; set; }
        public double Width { get; set; }

        private double Diagonal(double height, double width)
        {
            return Math.Sqrt(height * height + width * width);
        }
    }
}
