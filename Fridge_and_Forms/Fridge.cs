using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    public class Fridge
    {
        public double HeightWidthDiagonal => Diagonal(Height, Width); 
        public double WidthLengthDiagonal => Diagonal(Width, Length);
        public double HeightLengthDiagonal => Diagonal(Height, Length);
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public Fridge(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        private double Diagonal(double height, double width)
        {
            return Math.Sqrt(height * height + width * width);
        }
    }
}
