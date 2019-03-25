using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    class Program
    {
        public static int choiseSCP;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose fridge frame:  <0 - Sphere ;0 - Cylinder,>0 - Paralelepiped:");
            var choiceSCP = Convert.ToInt32(Console.ReadLine());

            if (choiseSCP < 0)
            {
                IHomeService homeService = new HomeService();
                Fridge fridge = homeService.CreateFridgeSphere();
                Console.WriteLine("Choose:0 - Window; other - Door:");
                var choiceWD = Convert.ToInt32(Console.ReadLine());

                var constructionNameSecond = choiceWD > 0 ? "Door" : "Window";

                Console.WriteLine("You Chose the " + constructionNameSecond);

                homeService.CheckIsSuccessSphereThrow(fridge);

                Console.ReadLine();
                Console.ReadLine();
            }
           else if(choiseSCP == 0)
            {
                IHomeService homeService = new HomeService();
                Fridge fridge = homeService.CreateFridgeCylinder();
                Console.WriteLine("Choose:0 - Window; other - Door:");
                var choiceWD = Convert.ToInt32(Console.ReadLine());

                var constructionNameSecond = choiceWD > 0 ? "Door" : "Window";

                Console.WriteLine("You Chose the " + constructionNameSecond);

                homeService.CheckIsSuccessCelinderThrow(fridge);

                Console.ReadLine();
                Console.ReadLine();
            
            }
            else if(choiseSCP > 0)
            {
                IHomeService homeService = new HomeService();
                Fridge fridge = homeService.CreateFridgeParalelepiped();

                Console.WriteLine("Choose:0 - Window; other - Door:");
                var choiceWD = Convert.ToInt32(Console.ReadLine());

                var constructionNameSecond = choiceWD > 0 ? "Door" : "Window";

                Console.WriteLine("You Chose the " + constructionNameSecond);

                homeService.CheckIsSuccessParalelepipedThrow(fridge);

                Console.ReadLine();
                Console.ReadLine();
            }
        }
    }
}
