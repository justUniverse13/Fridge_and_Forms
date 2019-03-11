using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int valueWD = 0;
            int valueCR = 0;

            Fridge fridge = new Fridge();
            Console.WriteLine("Input fridge's parameters.");
            Console.WriteLine("Input fridge's height:");
            fridge.fridgeHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input fridge's width:");
            fridge.fridgeWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input fridge's length:");
            fridge.fridgeLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose:1 - Window;2-Door:");
            valueWD = Convert.ToInt32(Console.ReadLine());
            if (valueWD == 1)//Window
            {
                Console.WriteLine("You Chose the Window");
                Console.WriteLine("Choose:1 - Circle;2-Rectangle:");
                if (valueCR == 1)//Circle window
                {
                    Console.WriteLine("You Chose the Circle");
                    Circle circle = new Circle();
                    Console.WriteLine("Input Window(Circle) radius:");
                    circle.Radius = Convert.ToInt32(Console.ReadLine());
                    fridge.FridgeHeightLengthDiagonal(fridge.fridgeHeight,fridge.fridgeLength);
                    fridge.FridgeHeightWidthDiagonal(fridge.fridgeHeight,fridge.fridgeWidth);
                    fridge.FridgeWidthLengthDiagonal(fridge.fridgeWidth,fridge.fridgeLength);

                    if (fridge.fridgeHeightWidthDiagonal <= 2 * circle.Radius || fridge.fridgeWidthLengthDiagonal <= 2 * circle.Radius || fridge.fridgeHeightLengthDiagonal <= 2 * circle.Radius)
                    {
                        Console.WriteLine("Success throw the Circle!");
                    }
                    else
                        Console.WriteLine("There is no way to go outside Circle!");
                }
                else//Rectangle window
                {
                    Console.WriteLine("You Chose the Rectangle");
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Input Window(Rectangle) width:");
                    rectangle.Width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Window(Rectangle) length:");
                    rectangle.Length = Convert.ToInt32(Console.ReadLine());
                    if (fridge.fridgeHeight < rectangle.Length && fridge.fridgeWidth < rectangle.Width || fridge.fridgeLength <rectangle.Length && fridge.fridgeWidth < rectangle.Width || fridge.fridgeHeight < rectangle.Length && fridge.fridgeLength < rectangle.Width || fridge.fridgeHeight < rectangle.Width && fridge.fridgeWidth < rectangle.Length || fridge.fridgeLength < rectangle.Width && fridge.fridgeWidth < rectangle.Length || fridge.fridgeHeight < rectangle.Width && fridge.fridgeLength < rectangle.Length)
                    {
                        Console.WriteLine("Success throw the Rectangle!");
                    }
                    else
                        Console.WriteLine("There is no way to go outside Rectangle!");

                }
            }
            else//Door 
            {
                Console.WriteLine("You Chose the Door");
                Console.WriteLine("Choose:1 - Circle;2-Rectangle:");
                if (valueCR == 1)//Circle door
                {
                    Console.WriteLine("You Chose the Circle");
                    Circle circle = new Circle();
                    Console.WriteLine("Input Window(Circle) radius:");
                    circle.Radius = Convert.ToInt32(Console.ReadLine());
                    fridge.FridgeHeightLengthDiagonal(fridge.fridgeHeight, fridge.fridgeLength);
                    fridge.FridgeHeightWidthDiagonal(fridge.fridgeHeight, fridge.fridgeWidth);
                    fridge.FridgeWidthLengthDiagonal(fridge.fridgeWidth, fridge.fridgeLength);

                    if (fridge.fridgeHeightWidthDiagonal <= 2 * circle.Radius || fridge.fridgeWidthLengthDiagonal <= 2 * circle.Radius || fridge.fridgeHeightLengthDiagonal <= 2 * circle.Radius)
                    {
                        Console.WriteLine("Success throw the Circle!");
                    }
                    else
                        Console.WriteLine("There is no way to go outside Circle!");
                }
                else// Rectangle door
                {
                    Console.WriteLine("You Chose the Rectangle");
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Input Window(Rectangle) width:");
                    rectangle.Width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Window(Rectangle) length:");
                    rectangle.Length = Convert.ToInt32(Console.ReadLine());
                    if (fridge.fridgeHeight < rectangle.Length && fridge.fridgeWidth < rectangle.Width || fridge.fridgeLength < rectangle.Length && fridge.fridgeWidth < rectangle.Width || fridge.fridgeHeight < rectangle.Length && fridge.fridgeLength < rectangle.Width || fridge.fridgeHeight < rectangle.Width && fridge.fridgeWidth < rectangle.Length || fridge.fridgeLength < rectangle.Width && fridge.fridgeWidth < rectangle.Length || fridge.fridgeHeight < rectangle.Width && fridge.fridgeLength < rectangle.Length)
                    {
                        Console.WriteLine("Success throw the Rectangle!");
                    }
                    else
                        Console.WriteLine("There is no way to go outside Rectangle!");

                }
            }



        }

    }
}
