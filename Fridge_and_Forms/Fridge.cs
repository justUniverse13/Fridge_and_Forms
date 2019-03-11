using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    class Fridge
    {
        public int fridgeHeightWidthDiagonal=0;
        public int fridgeWidthLengthDiagonal = 0;
        public int fridgeHeightLengthDiagonal = 0;
        public int fridgeHeight;
        public int fridgeWidth;
        public int fridgeLength;

        public int FridgeHeightWidthDiagonal(int fridgeHeight, int fridgeWidth)
        {
            fridgeHeightWidthDiagonal = Sqrt(fridgeHeight ^ 2 + fridgeWidth ^ 2);
            return fridgeHeightWidthDiagonal;
        }
        public int FridgeWidthLengthDiagonal(int fridgeWidth, int fridgeLength)
        {
            fridgeWidthLengthDiagonal = Sqrt(fridgeWidth ^ 2 + fridgeLength ^ 2);
            return fridgeWidthLengthDiagonal;
        }
        public int FridgeHeightLengthDiagonal(int fridgeHeight, int fridgeLength)
        {
            fridgeHeightLengthDiagonal = Sqrt(fridgeHeight ^ 2 + fridgeLength ^ 2);
            return fridgeHeightLengthDiagonal;
        }

        private int Sqrt(int v)
        {
            throw new NotImplementedException();
        }
    }
}
