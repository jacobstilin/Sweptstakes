using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class ManagerFactory
    {

        

        public static ISweepstakesManager CreateManager(string type)
        {
            ISweepstakesManager manager = null;
            switch (type)
            {
                case "stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "queue":
                    manager = new SweepstakesQueueManager();
                    break;
            }
            return manager;
        }
    }
}
