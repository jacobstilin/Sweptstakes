using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public static Random random = new Random(DateTime.Now.Millisecond);

        public ISweepstakesManager manager;
        public MarketingFirm()
        {
            
        }

        public string GetManagerType()
        {
            Console.WriteLine("Enter stack or queue to select manager");
            
            string input = Console.ReadLine();  // validation here
            if (input != "stack" && input != "queue")
            {
                Console.WriteLine("Please enter a valid choice.");
                return GetManagerType();
            }
            return input;
        }

        public void CreateManager(string type)
        {
            manager = ManagerFactory.CreateManager(type);
        }

        


        // this has to be completely reworked. the ISweepstakesManager will be created as either a stack or a queue when the program is started. 

        public void CreateSweepstakes()
        {
            Console.WriteLine("Enter a name for this sweepstakes.");
            string name = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(name, random);
            manager.InsertSweepstakes(sweepstakes);
            
        }

        public void GetSweepstakes()
        {
            Sweepstakes sweepstakes = manager.GetSweepstakes();
            if (sweepstakes == null)
            {
                Console.WriteLine("There are no sweepstakes present.");
            }
            else
            {
                sweepstakes.NotifyContestants();
            }
        }


        
    }
}
