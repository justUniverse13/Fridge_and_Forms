using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    public class HomeService : IHomeService
    {
        public Fridge CreateFridgeParalelepiped()
        {
            Console.WriteLine("Input Paralelepiped fridge's parameters.");
            Console.WriteLine("Input fridge's height:");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input fridge's width:");
            var width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input fridge's length:");
            var length = Convert.ToDouble(Console.ReadLine());

            return new Fridge(height, width, length);
        }
        public Fridge CreateFridgeSphere()
        {
            Console.WriteLine("Input Sphere fridge's parameters.");
            Console.WriteLine("Input fridge's Radius:");
            var radius = Convert.ToDouble(Console.ReadLine());

            return new Fridge(radius);
        }
        public Fridge CreateFridgeCylinder ()
        {
            Console.WriteLine("Input Cylinder fridge's parameters.");
            Console.WriteLine("Input fridge's height:");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input fridge's Radius:");
            var radius = Convert.ToDouble(Console.ReadLine());

            return new Fridge(height,radius);
        }

        public bool CheckIsSuccessParalelepipedThrow(Fridge fridge)
        {
            Console.WriteLine("Choose:0 - Circle; other - Rectangle:");

            var choiceCR = Convert.ToInt32(Console.ReadLine());

            bool isThrow;

            if (choiceCR > 0)
            {
                var rectangle = CreateRectangle();

                isThrow = IsSuccessParalelepipedThrowFrame(fridge, rectangle);

                Console.WriteLine(isThrow ? "Success throw the Rectangle!" : "There is no way to go outside Rectangle!");
            }
            else
            {
                var circle = CreateCircle();

                isThrow = IsSuccessParalelepipedThrowFrame(fridge, circle);

                Console.WriteLine(isThrow ? "Success throw the Circle!" : "There is no way to go outside Circle!");
            }

            return isThrow;
        }

        public bool CheckIsSuccessSphereThrow(Fridge fridge)
        {
            Console.WriteLine("Choose:0 - Circle; other - Rectangle:");

            var choiceCR = Convert.ToInt32(Console.ReadLine());

            bool isThrow;

            if (choiceCR > 0)
            {
                var rectangle = CreateRectangle();

                isThrow = IsSuccessSphereThrowFrame(fridge, rectangle);

                Console.WriteLine(isThrow ? "Success throw the Rectangle!" : "There is no way to go outside Rectangle!");
            }
            else
            {
                var circle = CreateCircle();

                isThrow = IsSuccessSphereThrowFrame(fridge, circle);

                Console.WriteLine(isThrow ? "Success throw the Circle!" : "There is no way to go outside Circle!");
            }

            return isThrow;
        }

        public bool CheckIsSuccessCelinderThrow(Fridge fridge)
        {
            Console.WriteLine("Choose:0 - Circle; other - Rectangle:");

            var choiceCR = Convert.ToInt32(Console.ReadLine());

            bool isThrow;

            if (choiceCR > 0)
            {
                var rectangle = CreateRectangle();

                isThrow = IsSuccessCelinderThrowFrame(fridge, rectangle);

                Console.WriteLine(isThrow ? "Success throw the Rectangle!" : "There is no way to go outside Rectangle!");
            }
            else
            {
                var circle = CreateCircle();

                isThrow = IsSuccessCelinderThrowFrame(fridge, circle);

                Console.WriteLine(isThrow ? "Success throw the Circle!" : "There is no way to go outside Circle!");
            }

            return isThrow;
        }

        private Circle CreateCircle()
        {
            Console.WriteLine("You Chose the Circle");
            Circle circle = new Circle();

            Console.WriteLine("Input Window(Circle) radius:");
            circle.Radius = Convert.ToDouble(Console.ReadLine());

            return circle;
        }

        private Rectangle CreateRectangle()
        {
            Console.WriteLine("You Chose the Rectangle");
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Input Window(Rectangle) width:");
            rectangle.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Window(Rectangle) length:");
            rectangle.Height = Convert.ToDouble(Console.ReadLine());

            return rectangle;
        }

        private bool IsSuccessParalelepipedThrowFrame(Fridge fridge, Frame frame)
        {
            if(frame is Circle circle)
            {
                return IsSuccessThrowCircle(fridge.HeightWidthDiagonal, circle)
                    || IsSuccessThrowCircle(fridge.WidthLengthDiagonal, circle)
                    || IsSuccessThrowCircle(fridge.HeightLengthDiagonal, circle);
            }
            else if(frame is Rectangle rectangle)
            {
                return IsSuccessThrowRectangle(fridge.Height, fridge.Width, rectangle)
                    || IsSuccessThrowRectangle(fridge.Height, fridge.Length, rectangle)
                    || IsSuccessThrowRectangle(fridge.Width, fridge.Length, rectangle);
            }

            return false;
        }
        private bool IsSuccessSphereThrowFrame(Fridge fridge, Frame frame)
        {
            if (frame is Circle circle)
            {
                return ComparisonRadiusesSphereCircle(fridge.Radius, circle);
            }
            else if (frame is Rectangle rectangle)
            {
                return ComparisonDiagonalRectangleRadiusSphere(fridge.Radius, rectangle);
            }

            return false;
        }

        private bool IsSuccessCelinderThrowFrame(Fridge fridge, Frame frame)
        {
            if (frame is Circle circle)
            {
                return (ComparisonRadiusesCircleCelinder(fridge.Radius, circle))||(IsSuccessThrowCircle(2*fridge.Radius,circle));
            }
            else if (frame is Rectangle rectangle)
            {
                return (ComparisonCelinderRadiusRectangle(fridge.Radius, rectangle))
                    ||(ComparisonCelinderParametrsRectangle(fridge.Radius,fridge.Height,rectangle));
            }

            return false;
        }



        private bool IsSuccessThrowRectangle(double height, double width, Rectangle rectangle)
        {
            return height < rectangle.Height && width < rectangle.Width
                || width < rectangle.Height && height < rectangle.Width;
        }
        private bool IsSuccessThrowCircle(double diagonal, Circle circle)
        {
            return diagonal <= 2 * circle.Radius;
        }
        private bool ComparisonRadiusesSphereCircle(double radius,Circle circle)
        {
            return radius < circle.Radius;
        }
        private bool ComparisonDiagonalRectangleRadiusSphere(double radius,Rectangle rectangle)
        {
            return rectangle.HeightWidthDiagonal > 2 * radius;
        }
        private bool ComparisonRadiusesCircleCelinder(double radius, Circle circle)
        {
            return radius<circle.Radius;
        }
        private bool ComparisonCelinderRadiusRectangle(double radius,Rectangle rectangle)
        {
            return ( radius < rectangle.Width )|| ( radius < rectangle.Height);
        }
        private bool ComparisonCelinderParametrsRectangle(double radius, double height, Rectangle rectangle)
        {
            return 2*radius < rectangle.Height && height < rectangle.Width
                || height < rectangle.Height && 2 * radius < rectangle.Width;
        }
    }
}
