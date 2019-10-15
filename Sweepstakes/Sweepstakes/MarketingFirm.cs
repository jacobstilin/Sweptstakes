using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void CreateSweepstakes()
        {
            Console.WriteLine("Enter a name for this sweepstakes.");
            string name = Console.ReadLine();
            queue.CreateSweepstakes(name);
            stack.CreateSweepstakes(name);
        }
    }
}
