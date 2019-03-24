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
            IHomeService homeService = new HomeService();
            Fridge fridge = homeService.CreateFridge();

            Console.WriteLine("Choose:0 - Window; other - Door:");
            var choiceWD = Convert.ToInt32(Console.ReadLine());

            var constructionName = choiceWD > 0 ? "Door" : "Window";

            Console.WriteLine("You Chose the " + constructionName);

            homeService.CheckIsSuccessThrow(fridge);

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
