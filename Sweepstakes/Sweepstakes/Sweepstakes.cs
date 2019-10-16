using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> dictionary;
        public Random random;

        public Sweepstakes(string name, Random random)
        {
            dictionary = new Dictionary<int, Contestant>();
            this.random = random;
            MakeContestants();
            PickWinner();
        }

        

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = (dictionary.Count + 1);
            dictionary.Add(contestant.registrationNumber, contestant);
        }

        public void MakeContestants()
        {
            for (int i = 0; i < 20; i++)
            {
                Contestant contestant = new Contestant(random);
                contestant.registrationNumber = (i + 1);
                RegisterContestant(contestant);

            }
        }

        public Contestant PickWinner()
        {
            Contestant winner = dictionary[random.Next(dictionary.Count)];
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.name);
        }
    }
}
