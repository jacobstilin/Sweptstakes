using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<Contestant, int> dictionary;
        
        public Sweepstakes(string name)
        {
            dictionary = new Dictionary<Contestant, int>();
        }

        

        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant, contestant.registrationNumber);
        }

        public Contestant PickWinner()
        {
            
            
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.name);
        }
    }
}
