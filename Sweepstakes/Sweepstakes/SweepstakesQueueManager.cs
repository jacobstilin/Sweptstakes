using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<string> queue;

        public SweepstakesQueueManager()
        {
            queue = new Queue<string>();
        }


        public void InsertSweepstakes()
        {

        }

        public Sweepstakes GetSweepstakes()
        {

        }

    }
}
