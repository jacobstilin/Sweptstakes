using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        static Random random = new Random(DateTime.Now.Millisecond);

        SweepstakesStackManager stackManager;
        SweepstakesQueueManager queueManager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            
        }

        public void MakeContestants(Sweepstakes sweepstakes)
        {
            for (int i = 0; i < 20; i++)
            {
                Contestant contestant = new Contestant(random);
                sweepstakes.RegisterContestant(contestant);

            }
        }

        public void CreateSweepstakes()
        {
            Console.WriteLine("Choose a sweepstakes management method, stack or queue.");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "stack":
                    Console.WriteLine("Enter a name for this sweepstakes.");
                    string sName = Console.ReadLine();
                    Sweepstakes sSweepstakes = new Sweepstakes(sName);
                    MakeContestants(sSweepstakes);
                    stackManager.InsertSweepstakes(sSweepstakes);
                    break;
                case "queue":
                    Console.WriteLine("Enter a name for this sweepstakes.");
                    string qName = Console.ReadLine();
                    Sweepstakes qSweepstakes = new Sweepstakes(qName);
                    MakeContestants(qSweepstakes);
                    queueManager.InsertSweepstakes(qSweepstakes);
                    break;
            }
        }


        
    }
}
