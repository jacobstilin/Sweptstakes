using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface

    {
        static string input;

        public static void Introduction()
        {
            Console.WriteLine("Welcome, sweepstakes manager, to the sweekstakes manager. Press enter to continue");
            Console.ReadLine();
        }

        public static void MainMenu(MarketingFirm marketingFirm)
        {
            
            bool quit = false;

            do
            {
                Console.WriteLine("Enter 1 to create a sweepstakes. Enter 2 to pull a sweepstakes and check the winner. Enter 3 to quit.");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        marketingFirm.CreateSweepstakes();
                        break;
                    case "2":
                        marketingFirm.GetSweepstakes();
                        break;
                    case "3":
                        quit = true;
                        break;
                    default:
                        break;
                }
            } while (quit == false);
        }
        
    }
}
